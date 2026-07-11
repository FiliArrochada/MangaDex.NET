/*
 * MangaDex API
 *
 * MangaDex is an ad-free manga reader offering high-quality images!  This document details our API as it is right now. It is in no way a promise to never change it, although we will endeavour to publicly notify any major change.  # Acceptable use policy  Usage of our services implies acceptance of the following: - You **MUST** credit us - You **MUST** credit scanlation groups if you offer the ability to read chapters - You **CANNOT** run ads or paid services on your website and/or apps  These may change at any time for any and no reason and it is up to you check for updates from time to time.  # Security issues  If you believe you found a security issue in our API, please check our [security.txt](/security.txt) to get in touch privately.
 *
 * The version of the OpenAPI document: 5.13.1
 * Contact: support@mangadex.org
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace MangaDex.Model
{
    /// <summary>
    /// ChapterEdit
    /// </summary>
    [DataContract(Name = "ChapterEdit")]
    public partial class ChapterEdit : IEquatable<ChapterEdit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterEdit" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChapterEdit()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterEdit" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="volume">volume.</param>
        /// <param name="chapter">chapter.</param>
        /// <param name="translatedLanguage">translatedLanguage.</param>
        /// <param name="groups">groups.</param>
        /// <param name="varVersion">varVersion (required).</param>
        public ChapterEdit(string title = default(string), string volume = default(string), string chapter = default(string), string translatedLanguage = default(string), List<Guid> groups = default(List<Guid>), int varVersion = default(int))
        {
            this.VarVersion = varVersion;
            this.Title = title;
            this.Volume = volume;
            this.Chapter = chapter;
            this.TranslatedLanguage = translatedLanguage;
            this.Groups = groups;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Volume
        /// </summary>
        [DataMember(Name = "volume", EmitDefaultValue = true)]
        [JsonPropertyName("volume")]
        public string Volume { get; set; }

        /// <summary>
        /// Gets or Sets Chapter
        /// </summary>
        [DataMember(Name = "chapter", EmitDefaultValue = true)]
        [JsonPropertyName("chapter")]
        public string Chapter { get; set; }

        /// <summary>
        /// Gets or Sets TranslatedLanguage
        /// </summary>
        [DataMember(Name = "translatedLanguage", EmitDefaultValue = false)]
        [JsonPropertyName("translatedLanguage")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string TranslatedLanguage { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name = "groups", EmitDefaultValue = false)]
        [JsonPropertyName("groups")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<Guid> Groups { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        [JsonPropertyName("version")]
        public int VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChapterEdit {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  Chapter: ").Append(Chapter).Append("\n");
            sb.Append("  TranslatedLanguage: ").Append(TranslatedLanguage).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return System.Text.Json.JsonSerializer.Serialize(this, MangaDex.Client.SerializerOptions.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChapterEdit);
        }

        /// <summary>
        /// Returns true if ChapterEdit instances are equal
        /// </summary>
        /// <param name="input">Instance of ChapterEdit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChapterEdit input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) &&
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) &&
                (
                    this.Chapter == input.Chapter ||
                    (this.Chapter != null &&
                    this.Chapter.Equals(input.Chapter))
                ) &&
                (
                    this.TranslatedLanguage == input.TranslatedLanguage ||
                    (this.TranslatedLanguage != null &&
                    this.TranslatedLanguage.Equals(input.TranslatedLanguage))
                ) &&
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) &&
                (
                    this.VarVersion == input.VarVersion ||
                    this.VarVersion.Equals(input.VarVersion)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Volume != null)
                {
                    hashCode = (hashCode * 59) + this.Volume.GetHashCode();
                }
                if (this.Chapter != null)
                {
                    hashCode = (hashCode * 59) + this.Chapter.GetHashCode();
                }
                if (this.TranslatedLanguage != null)
                {
                    hashCode = (hashCode * 59) + this.TranslatedLanguage.GetHashCode();
                }
                if (this.Groups != null)
                {
                    hashCode = (hashCode * 59) + this.Groups.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VarVersion.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Title (string) maxLength
            if (this.Title != null && this.Title.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than 255.", new[] { "Title" });
            }

            // Chapter (string) maxLength
            if (this.Chapter != null && this.Chapter.Length > 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Chapter, length must be less than 8.", new[] { "Chapter" });
            }

            if (this.TranslatedLanguage != null)
            {
                // TranslatedLanguage (string) pattern
                Regex regexTranslatedLanguage = new Regex(@"^[a-z]{2}(-[a-z]{2})?$", RegexOptions.CultureInvariant);
                if (!regexTranslatedLanguage.Match(this.TranslatedLanguage).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TranslatedLanguage, must match a pattern of " + regexTranslatedLanguage, new[] { "TranslatedLanguage" });
                }
            }

            // VarVersion (int) minimum
            if (this.VarVersion < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VarVersion, must be a value greater than or equal to 1.", new[] { "VarVersion" });
            }

            yield break;
        }
    }
}