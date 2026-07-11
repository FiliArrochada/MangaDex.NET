/*
 * MangaDex API
 *
 * MangaDex is an ad-free manga reader offering high-quality images!  This document details our API as it is right now. It is in no way a promise to never change it, although we will endeavour to publicly notify any major change.  # Acceptable use policy  Usage of our services implies acceptance of the following: - You **MUST** credit us - You **MUST** credit scanlation groups if you offer the ability to read chapters - You **CANNOT** run ads or paid services on your website and/or apps  These may change at any time for any and no reason and it is up to you check for updates from time to time.  # Security issues  If you believe you found a security issue in our API, please check our [security.txt](/security.txt) to get in touch privately. 
 *
 * The version of the OpenAPI document: 5.10.0
 * Contact: support@mangadex.org
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = MangaDex.Client.OpenAPIDateConverter;

namespace MangaDex.Model
{
    /// <summary>
    /// ChapterReadMarkerBatch
    /// </summary>
    [DataContract(Name = "ChapterReadMarkerBatch")]
    public partial class ChapterReadMarkerBatch : IEquatable<ChapterReadMarkerBatch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterReadMarkerBatch" /> class.
        /// </summary>
        /// <param name="chapterIdsRead">chapterIdsRead.</param>
        /// <param name="chapterIdsUnread">chapterIdsUnread.</param>
        public ChapterReadMarkerBatch(List<Guid> chapterIdsRead = default(List<Guid>), List<Guid> chapterIdsUnread = default(List<Guid>))
        {
            this.ChapterIdsRead = chapterIdsRead;
            this.ChapterIdsUnread = chapterIdsUnread;
        }

        /// <summary>
        /// Gets or Sets ChapterIdsRead
        /// </summary>
        [DataMember(Name = "chapterIdsRead", EmitDefaultValue = false)]
        [JsonPropertyName("chapterIdsRead")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<Guid> ChapterIdsRead { get; set; }

        /// <summary>
        /// Gets or Sets ChapterIdsUnread
        /// </summary>
        [DataMember(Name = "chapterIdsUnread", EmitDefaultValue = false)]
        [JsonPropertyName("chapterIdsUnread")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<Guid> ChapterIdsUnread { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChapterReadMarkerBatch {\n");
            sb.Append("  ChapterIdsRead: ").Append(ChapterIdsRead).Append("\n");
            sb.Append("  ChapterIdsUnread: ").Append(ChapterIdsUnread).Append("\n");
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
            return this.Equals(input as ChapterReadMarkerBatch);
        }

        /// <summary>
        /// Returns true if ChapterReadMarkerBatch instances are equal
        /// </summary>
        /// <param name="input">Instance of ChapterReadMarkerBatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChapterReadMarkerBatch input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ChapterIdsRead == input.ChapterIdsRead ||
                    this.ChapterIdsRead != null &&
                    input.ChapterIdsRead != null &&
                    this.ChapterIdsRead.SequenceEqual(input.ChapterIdsRead)
                ) && 
                (
                    this.ChapterIdsUnread == input.ChapterIdsUnread ||
                    this.ChapterIdsUnread != null &&
                    input.ChapterIdsUnread != null &&
                    this.ChapterIdsUnread.SequenceEqual(input.ChapterIdsUnread)
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
                if (this.ChapterIdsRead != null)
                {
                    hashCode = (hashCode * 59) + this.ChapterIdsRead.GetHashCode();
                }
                if (this.ChapterIdsUnread != null)
                {
                    hashCode = (hashCode * 59) + this.ChapterIdsUnread.GetHashCode();
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
            yield break;
        }
    }

}
