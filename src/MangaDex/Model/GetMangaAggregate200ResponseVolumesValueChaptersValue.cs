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

namespace MangaDex.Model
{
    /// <summary>
    /// GetMangaAggregate200ResponseVolumesValueChaptersValue
    /// </summary>
    [DataContract(Name = "get_manga_aggregate_200_response_volumes_value_chapters_value")]
    public partial class GetMangaAggregate200ResponseVolumesValueChaptersValue : IEquatable<GetMangaAggregate200ResponseVolumesValueChaptersValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMangaAggregate200ResponseVolumesValueChaptersValue" /> class.
        /// </summary>
        /// <param name="chapter">chapter.</param>
        /// <param name="id">id.</param>
        /// <param name="others">others.</param>
        /// <param name="count">count.</param>
        public GetMangaAggregate200ResponseVolumesValueChaptersValue(string chapter = default(string), Guid id = default(Guid), List<Guid> others = default(List<Guid>), int count = default(int))
        {
            this.Chapter = chapter;
            this.Id = id;
            this.Others = others;
            this.Count = count;
        }

        /// <summary>
        /// Gets or Sets Chapter
        /// </summary>
        [DataMember(Name = "chapter", EmitDefaultValue = false)]
        [JsonPropertyName("chapter")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Chapter { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonPropertyName("id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Others
        /// </summary>
        [DataMember(Name = "others", EmitDefaultValue = false)]
        [JsonPropertyName("others")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<Guid> Others { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        [JsonPropertyName("count")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetMangaAggregate200ResponseVolumesValueChaptersValue {\n");
            sb.Append("  Chapter: ").Append(Chapter).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Others: ").Append(Others).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as GetMangaAggregate200ResponseVolumesValueChaptersValue);
        }

        /// <summary>
        /// Returns true if GetMangaAggregate200ResponseVolumesValueChaptersValue instances are equal
        /// </summary>
        /// <param name="input">Instance of GetMangaAggregate200ResponseVolumesValueChaptersValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetMangaAggregate200ResponseVolumesValueChaptersValue input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Chapter == input.Chapter ||
                    (this.Chapter != null &&
                    this.Chapter.Equals(input.Chapter))
                ) &&
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) &&
                (
                    this.Others == input.Others ||
                    this.Others != null &&
                    input.Others != null &&
                    this.Others.SequenceEqual(input.Others)
                ) &&
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
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
                if (this.Chapter != null)
                {
                    hashCode = (hashCode * 59) + this.Chapter.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Others != null)
                {
                    hashCode = (hashCode * 59) + this.Others.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Count.GetHashCode();
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
            yield break;
        }
    }
}