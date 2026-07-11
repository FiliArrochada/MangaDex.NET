#!/usr/bin/env dotnet run
/*
 * gen-refit.cs — .NET 10 file-based app (run: dotnet run scripts/gen-refit.cs -- <out-dir>)
 *
 * Generates Refit interface scaffolds (one I{X}Api.cs per API) from the existing
 * src/MangaDex/Api/*.cs classes. Pure text processing — no runtime dependency beyond the .NET
 * SDK already required to build this repo. Faithful port of the earlier Node generator, plus
 * direct handling of multipart (file/form) uploads.
 *
 * Rules:
 *   - reads sync-interface signatures for names/params/return types;
 *   - unions query/path/body/auth facts from BOTH sync and async impls (some sync impls omit
 *     query-param building); string/comment-aware brace matching so braces in "/user/{id}" etc.
 *     don't miscount;
 *   - arrays -> [Query(CollectionFormat.X), AliasAs("key[]")]; deepObject order -> IDictionary;
 *     bodies -> [Body] + [Headers Content-Type]; multipart -> [Multipart] + StreamPart/form fields;
 *   - drops contentType/operationIndex params; renames path params to the URL token.
 */

using System.Text;
using System.Text.RegularExpressions;

var repoRoot = FindRepoRoot(Directory.GetCurrentDirectory());
var apiDir = Path.Combine(repoRoot, "src", "MangaDex", "Api");
var outDir = args.Length > 0 ? args[0] : Path.Combine(repoRoot, "refit-out");
Directory.CreateDirectory(outDir);

int files = 0, totalOps = 0;
foreach (var path in Directory.GetFiles(apiDir, "*Api.cs").OrderBy(p => p, StringComparer.Ordinal))
{
    var (iface, ops, todos) = Gen.GenFile(path, outDir);
    files++; totalOps += ops;
    Console.WriteLine($"{iface,-26} {ops,3} ops  {(todos > 0 ? $"TODOs:{todos}" : "")}");
}
Console.WriteLine($"TOTAL: {files} interfaces, {totalOps} operations  ->  {outDir}");

static string FindRepoRoot(string start)
{
    var d = new DirectoryInfo(start);
    while (d != null && !File.Exists(Path.Combine(d.FullName, "api", "openapi.yaml"))) d = d.Parent;
    return d?.FullName ?? start;
}

static class Gen
{
    static readonly Dictionary<string, string> CF = new()
    { ["multi"] = "Multi", ["csv"] = "Csv", ["ssv"] = "Ssv", ["tsv"] = "Tsv", ["pipes"] = "Pipes" };

    public static List<string> SplitParams(string s)
    {
        var outp = new List<string>(); int depth = 0; var cur = new StringBuilder();
        foreach (var c in s)
        {
            if (c is '<' or '(' or '[') depth++;
            else if (c is '>' or ')' or ']') depth--;
            if (c == ',' && depth == 0) { if (cur.ToString().Trim().Length > 0) outp.Add(cur.ToString().Trim()); cur.Clear(); }
            else cur.Append(c);
        }
        if (cur.ToString().Trim().Length > 0) outp.Add(cur.ToString().Trim());
        return outp;
    }

    public static (string type, string name) ParseParam(string p)
    {
        var left = p; var eq = p.IndexOf('=');
        if (eq >= 0) left = p[..eq].Trim();
        var parts = left.Split((char[])null!, StringSplitOptions.RemoveEmptyEntries);
        var name = parts[^1];
        var type = string.Join(" ", parts[..^1]);
        return (type, name);
    }

    // string/comment-aware: return the source of the block starting at line i (must contain '{')
    public static string MethodBody(string[] lines, int i)
    {
        int depth = 0, end = -1; bool seen = false; string state = "code";
        for (int j = i; j < lines.Length && end < 0; j++)
        {
            var sref = lines[j];
            for (int k = 0; k < sref.Length; k++)
            {
                char c = sref[k], n = k + 1 < sref.Length ? sref[k + 1] : '\0';
                if (state == "line") break;
                if (state == "block") { if (c == '*' && n == '/') { state = "code"; k++; } continue; }
                if (state == "str") { if (c == '\\') k++; else if (c == '"') state = "code"; continue; }
                if (state == "verb") { if (c == '"' && n == '"') k++; else if (c == '"') state = "code"; continue; }
                if (state == "chr") { if (c == '\\') k++; else if (c == '\'') state = "code"; continue; }
                if (c == '/' && n == '/') { state = "line"; k++; continue; }
                if (c == '/' && n == '*') { state = "block"; k++; continue; }
                if (c == '@' && n == '"') { state = "verb"; k++; continue; }
                if (c == '"') { state = "str"; continue; }
                if (c == '\'') { state = "chr"; continue; }
                if (c == '{') { depth++; seen = true; }
                else if (c == '}') { depth--; if (seen && depth == 0) { end = j; break; } }
            }
            if (state == "line") state = "code";
        }
        return string.Join("\n", lines[i..(end + 1)]);
    }

    class Facts
    {
        public string? Verb, Path, BodyVar;
        public bool Auth, Form, File;
        public Dictionary<string, string> PathMap = new(), Scalar = new(), FileMap = new(), FormMap = new();
        public Dictionary<string, (string key, string cf)> Arr = new();
        public HashSet<string> DeepObj = new();
    }

    static Facts Extract(string body)
    {
        var f = new Facts();
        var vp = Regex.Match(body, @"this\.(?:Client|AsynchronousClient)\.(Get|Post|Put|Delete|Patch|Head|Options)(?:Async)?<[^>]*>\(""([^""]*)""");
        if (vp.Success) { f.Verb = vp.Groups[1].Value; f.Path = vp.Groups[2].Value; }
        foreach (Match m in Regex.Matches(body, @"PathParameters\.Add\(""([^""]+)"",\s*MangaDex\.Client\.ClientUtils\.ParameterToString\(([A-Za-z0-9_]+)\)"))
            f.PathMap[m.Groups[2].Value] = m.Groups[1].Value;
        var bv = Regex.Match(body, @"localVarRequestOptions\.Data\s*=\s*([A-Za-z0-9_]+)\s*;");
        if (bv.Success) f.BodyVar = bv.Groups[1].Value;
        f.Auth = body.Contains("authentication (Bearer) required");
        f.Form = body.Contains("FormParameters.Add");
        f.File = body.Contains("FileParameters");
        foreach (Match m in Regex.Matches(body, @"FileParameters\.Add\(""([^""]+)"",\s*([A-Za-z0-9_]+)\)"))
            f.FileMap[m.Groups[2].Value] = m.Groups[1].Value;
        foreach (Match m in Regex.Matches(body, @"FormParameters\.Add\(""([^""]+)"",\s*MangaDex\.Client\.ClientUtils\.ParameterToString\(([A-Za-z0-9_]+)\)"))
            f.FormMap[m.Groups[2].Value] = m.Groups[1].Value;
        foreach (Match m in Regex.Matches(body, @"ParameterToMultiMap\(\s*""([^""]*)"",\s*""([^""]+)"",\s*([A-Za-z0-9_]+)(\.[A-Za-z0-9_]+)?\s*\)"))
        {
            string fmt = m.Groups[1].Value, key = m.Groups[2].Value, var = m.Groups[3].Value;
            bool prop = m.Groups[4].Success;
            if (prop) { f.DeepObj.Add(var); continue; }
            if (fmt.Length > 0 && CF.TryGetValue(fmt, out var cf)) f.Arr[var] = (key, cf);
            else f.Scalar[var] = key;
        }
        return f;
    }

    static void Merge<T>(Dictionary<string, T> into, Dictionary<string, T> from)
    { foreach (var kv in from) if (!into.ContainsKey(kv.Key)) into[kv.Key] = kv.Value; }

    public static (string iface, int ops, int todos) GenFile(string filePath, string outDir)
    {
        var text = File.ReadAllText(filePath);
        var lines = text.Split('\n');
        var apiBase = Path.GetFileNameWithoutExtension(filePath);   // MangaApi
        var iface = "I" + apiBase;

        var region = Regex.Match(text, @"#region Synchronous Operations(.*?)#endregion Synchronous Operations", RegexOptions.Singleline);
        var regionText = region.Success ? region.Groups[1].Value : "";

        var sigs = new List<(string ret, string name, List<(string type, string name)> ps)>();
        foreach (Match m in Regex.Matches(regionText, @"(?m)^\s{8}([A-Za-z][\w<>,.\?\[\] ]*?)\s+([A-Za-z0-9]+)\((.*)\);[ \t\r]*$"))
        {
            if (m.Groups[2].Value.EndsWith("WithHttpInfo")) continue;
            var ps = SplitParams(m.Groups[3].Value).Select(ParseParam).ToList();
            sigs.Add((m.Groups[1].Value.Trim(), m.Groups[2].Value, ps));
        }

        var L = new List<string>
        {
            $"// GENERATED Refit scaffold for {apiBase} — prototype, not wired into the build (needs Refit).",
            "using System;", "using System.Collections.Generic;", "using System.Threading.Tasks;",
            "using Refit;", "using MangaDex.Model;", "",
            "namespace MangaDex.Api.Refit", "{", $"    public interface {iface}", "    {",
        };
        int ops = 0;

        foreach (var (ret, name, ps) in sigs)
        {
            ops++;
            int si = Array.FindIndex(lines, l => Regex.IsMatch(l, $@"public\s+(?!.*Task<)[\w<>.,\? ]*\b{name}WithHttpInfo\s*\("));
            int ai = Array.FindIndex(lines, l => Regex.IsMatch(l, $@"public\s+async[\w<>.,\? ]*\b{name}WithHttpInfoAsync\s*\("));
            if (si < 0 && ai < 0) { L.Add($"        // TODO {name}: no-impl"); L.Add(""); continue; }
            var f = si >= 0 ? Extract(MethodBody(lines, si)) : new Facts();
            var g = ai >= 0 ? Extract(MethodBody(lines, ai)) : new Facts();

            var verb = f.Verb ?? g.Verb ?? "Get";
            var path = f.Path ?? g.Path ?? "";
            var bodyVar = f.BodyVar ?? g.BodyVar;
            bool auth = f.Auth || g.Auth;
            bool hasContentType = ps.Any(p => p.name == "contentType");
            bool multipart = f.Form || g.Form || f.File || g.File;
            var pathMap = new Dictionary<string, string>(f.PathMap); Merge(pathMap, g.PathMap);
            var arr = new Dictionary<string, (string, string)>(f.Arr); Merge(arr, g.Arr);
            var scalar = new Dictionary<string, string>(f.Scalar); Merge(scalar, g.Scalar);
            var fileMap = new Dictionary<string, string>(f.FileMap); Merge(fileMap, g.FileMap);
            var formMap = new Dictionary<string, string>(f.FormMap); Merge(formMap, g.FormMap);
            var deepObj = new HashSet<string>(f.DeepObj); deepObj.UnionWith(g.DeepObj);

            var emitted = new List<string>();
            foreach (var (type, pname) in ps)
            {
                if (pname is "operationIndex" or "contentType") continue;
                if (pathMap.ContainsKey(pname) || path.Contains($"{{{pname}}}"))
                { emitted.Add($"{type} {(pathMap.TryGetValue(pname, out var pk) ? pk : pname)}"); continue; }
                if (pname == bodyVar) { emitted.Add($"[Body] {type} {pname} = null"); continue; }
                if (fileMap.TryGetValue(pname, out var fk))
                { emitted.Add($"[AliasAs(\"{fk}\")] StreamPart {pname}"); continue; }
                if (formMap.TryGetValue(pname, out var frk))
                { emitted.Add(frk == pname ? $"{type} {pname} = null" : $"[AliasAs(\"{frk}\")] {type} {pname} = null"); continue; }
                if (deepObj.Contains(pname))
                { emitted.Add($"[Query] IDictionary<string, string> {pname} = null /* deepObject */"); continue; }
                if (arr.TryGetValue(pname, out var a))
                { var alias = a.Item1 == pname ? "" : $", AliasAs(\"{a.Item1}\")"; emitted.Add($"[Query(CollectionFormat.{a.Item2}){alias}] {type} {pname} = null"); continue; }
                if (scalar.TryGetValue(pname, out var sk))
                { emitted.Add(sk == pname ? $"{type} {pname} = null" : $"[AliasAs(\"{sk}\")] {type} {pname} = null"); continue; }
                emitted.Add($"{type} {pname} = null /* TODO verify */");
            }

            var attrs = new List<string> { $"[{verb}(\"{path}\")]" };
            if (multipart) attrs.Add("[Multipart]");
            else if (bodyVar != null || hasContentType) attrs.Add("[Headers(\"Content-Type: application/json\")]");
            L.Add("        " + string.Join(" ", attrs));
            L.Add($"        Task<{ret}> {name}({string.Join(", ", emitted)});");
            L.Add("");
        }
        L.Add("    }");
        L.Add("}");
        File.WriteAllText(Path.Combine(outDir, iface + ".cs"), string.Join("\n", L));
        int todos = L.Count(l => l.Contains("TODO"));
        return (iface, ops, todos);
    }
}
