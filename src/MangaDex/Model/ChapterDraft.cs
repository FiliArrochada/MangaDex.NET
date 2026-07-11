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
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace MangaDex.Model
{
    /// <summary>
    /// ChapterDraft
    /// </summary>
    [DataContract(Name = "ChapterDraft")]
    public partial class ChapterDraft : IEquatable<ChapterDraft>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterDraft" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChapterDraft()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterDraft" /> class.
        /// </summary>
        /// <param name="volume">volume (required).</param>
        /// <param name="chapter">chapter (required).</param>
        /// <param name="title">title (required).</param>
        /// <param name="translatedLanguage">translatedLanguage (required).</param>
        /// <param name="externalUrl">externalUrl.</param>
        /// <param name="publishAt">publishAt.</param>
        public ChapterDraft(string volume = default(string), string chapter = default(string), string title = default(string), string translatedLanguage = default(string), string externalUrl = default(string), string publishAt = default(string))
        {
            // to ensure "volume" is required (not null)
            if (volume == null)
            {
                throw new ArgumentNullException("volume is a required property for ChapterDraft and cannot be null");
            }
            this.Volume = volume;
            // to ensure "chapter" is required (not null)
            if (chapter == null)
            {
                throw new ArgumentNullException("chapter is a required property for ChapterDraft and cannot be null");
            }
            this.Chapter = chapter;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for ChapterDraft and cannot be null");
            }
            this.Title = title;
            // to ensure "translatedLanguage" is required (not null)
            if (translatedLanguage == null)
            {
                throw new ArgumentNullException("translatedLanguage is a required property for ChapterDraft and cannot be null");
            }
            this.TranslatedLanguage = translatedLanguage;
            this.ExternalUrl = externalUrl;
            this.PublishAt = publishAt;
        }

        /// <summary>
        /// Gets or Sets Volume
        /// </summary>
        [DataMember(Name = "volume", IsRequired = true, EmitDefaultValue = true)]
        [JsonPropertyName("volume")]
        public string Volume { get; set; }

        /// <summary>
        /// Gets or Sets Chapter
        /// </summary>
        [DataMember(Name = "chapter", IsRequired = true, EmitDefaultValue = true)]
        [JsonPropertyName("chapter")]
        public string Chapter { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets TranslatedLanguage
        /// </summary>
        [DataMember(Name = "translatedLanguage", IsRequired = true, EmitDefaultValue = true)]
        [JsonPropertyName("translatedLanguage")]
        public string TranslatedLanguage { get; set; }

        /// <summary>
        /// Gets or Sets ExternalUrl
        /// </summary>
        [DataMember(Name = "externalUrl", EmitDefaultValue = true)]
        [JsonPropertyName("externalUrl")]
        public string ExternalUrl { get; set; }

        /// <summary>
        /// Gets or Sets PublishAt
        /// </summary>
        [DataMember(Name = "publishAt", EmitDefaultValue = false)]
        [JsonPropertyName("publishAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string PublishAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChapterDraft {\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  Chapter: ").Append(Chapter).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  TranslatedLanguage: ").Append(TranslatedLanguage).Append("\n");
            sb.Append("  ExternalUrl: ").Append(ExternalUrl).Append("\n");
            sb.Append("  PublishAt: ").Append(PublishAt).Append("\n");
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
            return this.Equals(input as ChapterDraft);
        }

        /// <summary>
        /// Returns true if ChapterDraft instances are equal
        /// </summary>
        /// <param name="input">Instance of ChapterDraft to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChapterDraft input)
        {
            if (input == null)
            {
                return false;
            }
            return
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
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) &&
                (
                    this.TranslatedLanguage == input.TranslatedLanguage ||
                    (this.TranslatedLanguage != null &&
                    this.TranslatedLanguage.Equals(input.TranslatedLanguage))
                ) &&
                (
                    this.ExternalUrl == input.ExternalUrl ||
                    (this.ExternalUrl != null &&
                    this.ExternalUrl.Equals(input.ExternalUrl))
                ) &&
                (
                    this.PublishAt == input.PublishAt ||
                    (this.PublishAt != null &&
                    this.PublishAt.Equals(input.PublishAt))
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
                if (this.Volume != null)
                {
                    hashCode = (hashCode * 59) + this.Volume.GetHashCode();
                }
                if (this.Chapter != null)
                {
                    hashCode = (hashCode * 59) + this.Chapter.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.TranslatedLanguage != null)
                {
                    hashCode = (hashCode * 59) + this.TranslatedLanguage.GetHashCode();
                }
                if (this.ExternalUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalUrl.GetHashCode();
                }
                if (this.PublishAt != null)
                {
                    hashCode = (hashCode * 59) + this.PublishAt.GetHashCode();
                }
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
            // Volume (string) maxLength
            if (this.Volume != null && this.Volume.Length > 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Volume, length must be less than 8.", new[] { "Volume" });
            }

            if (this.Volume != null)
            {
                // Volume (string) pattern
                Regex regexVolume = new Regex(@"^((0|[1-9]\d*)(\.\d+)?[a-z]?)?$", RegexOptions.CultureInvariant);
                if (!regexVolume.Match(this.Volume).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Volume, must match a pattern of " + regexVolume, new[] { "Volume" });
                }
            }

            // Chapter (string) maxLength
            if (this.Chapter != null && this.Chapter.Length > 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Chapter, length must be less than 8.", new[] { "Chapter" });
            }

            if (this.Chapter != null)
            {
                // Chapter (string) pattern
                Regex regexChapter = new Regex(@"^((0|[1-9]\d*)(\.\d+)?[a-z]?)?$", RegexOptions.CultureInvariant);
                if (!regexChapter.Match(this.Chapter).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Chapter, must match a pattern of " + regexChapter, new[] { "Chapter" });
                }
            }

            // Title (string) maxLength
            if (this.Title != null && this.Title.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than 255.", new[] { "Title" });
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

            // ExternalUrl (string) maxLength
            if (this.ExternalUrl != null && this.ExternalUrl.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExternalUrl, length must be less than 512.", new[] { "ExternalUrl" });
            }

            if (this.ExternalUrl != null)
            {
                // ExternalUrl (string) pattern
                Regex regexExternalUrl = new Regex(@"^https?://", RegexOptions.CultureInvariant);
                if (!regexExternalUrl.Match(this.ExternalUrl).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExternalUrl, must match a pattern of " + regexExternalUrl, new[] { "ExternalUrl" });
                }
            }

            if (this.PublishAt != null)
            {
                // PublishAt (string) pattern
                Regex regexPublishAt = new Regex(@"^\d{4}-[0-1]\d-([0-2]\d|3[0-1])T([0-1]\d|2[0-3]):[0-5]\d:[0-5]\d$", RegexOptions.CultureInvariant);
                if (!regexPublishAt.Match(this.PublishAt).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PublishAt, must match a pattern of " + regexPublishAt, new[] { "PublishAt" });
                }
            }

            yield break;
        }
    }
}