/*
 * Reflection-driven guards over the whole model surface, replacing the generated
 * per-model stub files (which asserted nothing):
 *   - every constructible DTO must survive a serialize -> deserialize -> serialize
 *     round-trip through SerializerOptions.Default unchanged, and
 *   - every enum member must round-trip through its [EnumMember] wire value.
 *
 * MangaDex models expose a single public ctor with all-optional parameters (no
 * parameterless ctor), and some enforce required properties with null-checks, so
 * instances are built by invoking that ctor with each parameter's default; types
 * whose ctor rejects defaults (required-property null-checks) or that have no
 * usable ctor (the abstract oneOf/anyOf wrappers) are excluded by TryCreate.
 * A floor assertion keeps that exclusion honest.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using MangaDex.Client;
using MangaDex.Model;
using Xunit;

namespace MangaDex.Test.Model
{
    public class AllModelsRoundTripTests
    {
        private static IEnumerable<Type> AllModelClasses() =>
            typeof(MangaDex.Model.Author).Assembly.GetTypes()
                .Where(t => t.Namespace == "MangaDex.Model" && t.IsClass && !t.IsAbstract && !t.IsNested
                            // the oneOf/anyOf helper converters live in the Model namespace but are not DTOs
                            && !typeof(System.Text.Json.Serialization.JsonConverter).IsAssignableFrom(t));

        public static IEnumerable<object[]> ModelTypes() =>
            AllModelClasses().Where(t => TryCreate(t, out _)).Select(t => new object[] { t });

        public static IEnumerable<object[]> EnumTypes() =>
            typeof(MangaDex.Model.Author).Assembly.GetTypes()
                .Where(t => t.Namespace == "MangaDex.Model")
                .SelectMany(t => t.IsEnum ? new[] { t } : t.GetNestedTypes().Where(n => n.IsEnum))
                .Distinct()
                .Select(t => new object[] { t });

        [Fact]
        public void Most_Models_Are_Constructible_For_RoundTripping()
        {
            var all = AllModelClasses().Count();
            var constructible = ModelTypes().Count();
            Assert.True(constructible >= all * 3 / 4,
                $"only {constructible} of {all} model types are default-constructible; the round-trip theory is losing coverage");
        }

        [Theory]
        [MemberData(nameof(ModelTypes))]
        public void Model_Survives_Serialize_Deserialize_RoundTrip(Type modelType)
        {
            Assert.True(TryCreate(modelType, out var instance));

            var json = JsonSerializer.Serialize(instance, modelType, SerializerOptions.Default);
            var back = JsonSerializer.Deserialize(json, modelType, SerializerOptions.Default);
            var json2 = JsonSerializer.Serialize(back, modelType, SerializerOptions.Default);

            Assert.NotNull(back);
            Assert.Equal(json, json2);
        }

        [Theory]
        [MemberData(nameof(EnumTypes))]
        public void Enum_Members_RoundTrip_Through_EnumMember_Values(Type enumType)
        {
            foreach (var value in Enum.GetValues(enumType))
            {
                var json = JsonSerializer.Serialize(value, enumType, SerializerOptions.Default);
                var back = JsonSerializer.Deserialize(json, enumType, SerializerOptions.Default);
                Assert.Equal(value, back);
            }
        }

        private static bool TryCreate(Type type, out object instance)
        {
            instance = null;

            // a parameterless ctor (any visibility) wins
            if (type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                    binder: null, Type.EmptyTypes, modifiers: null) != null)
            {
                instance = Activator.CreateInstance(type, nonPublic: true);
                return true;
            }

            var ctors = type.GetConstructors();
            if (ctors.Length != 1) return false;

            try
            {
                var args = ctors[0].GetParameters().Select(SafeDefault).ToArray();
                instance = ctors[0].Invoke(args);
                return true;
            }
            catch
            {
                return false; // required-property null-check or otherwise unconstructible from defaults
            }
        }

        private static object SafeDefault(ParameterInfo parameter)
        {
            // DefaultValue reflection can throw on .NET Framework for struct-typed defaults
            try
            {
                if (parameter.HasDefaultValue && parameter.DefaultValue != null)
                {
                    return parameter.DefaultValue;
                }
            }
            catch (FormatException) { }

            var t = parameter.ParameterType;
            return t.IsValueType ? Activator.CreateInstance(t) : null;
        }
    }
}
