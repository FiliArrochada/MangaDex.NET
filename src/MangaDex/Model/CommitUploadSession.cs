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
    /// CommitUploadSession
    /// </summary>
    [DataContract(Name = "CommitUploadSession")]
    public partial class CommitUploadSession : IEquatable<CommitUploadSession>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommitUploadSession" /> class.
        /// </summary>
        /// <param name="chapterDraft">chapterDraft.</param>
        /// <param name="pageOrder">ordered list of Upload Session File ids.</param>
        /// <param name="termsAccepted">termsAccepted.</param>
        public CommitUploadSession(ChapterDraft chapterDraft = default(ChapterDraft), List<Guid> pageOrder = default(List<Guid>), bool termsAccepted = default(bool))
        {
            this.ChapterDraft = chapterDraft;
            this.PageOrder = pageOrder;
            this.TermsAccepted = termsAccepted;
        }

        /// <summary>
        /// Gets or Sets ChapterDraft
        /// </summary>
        [DataMember(Name = "chapterDraft", EmitDefaultValue = false)]
        [JsonPropertyName("chapterDraft")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public ChapterDraft ChapterDraft { get; set; }

        /// <summary>
        /// ordered list of Upload Session File ids
        /// </summary>
        /// <value>ordered list of Upload Session File ids</value>
        [DataMember(Name = "pageOrder", EmitDefaultValue = false)]
        [JsonPropertyName("pageOrder")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<Guid> PageOrder { get; set; }

        /// <summary>
        /// Gets or Sets TermsAccepted
        /// </summary>
        [DataMember(Name = "termsAccepted", EmitDefaultValue = true)]
        [JsonPropertyName("termsAccepted")]
        public bool TermsAccepted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CommitUploadSession {\n");
            sb.Append("  ChapterDraft: ").Append(ChapterDraft).Append("\n");
            sb.Append("  PageOrder: ").Append(PageOrder).Append("\n");
            sb.Append("  TermsAccepted: ").Append(TermsAccepted).Append("\n");
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
            return this.Equals(input as CommitUploadSession);
        }

        /// <summary>
        /// Returns true if CommitUploadSession instances are equal
        /// </summary>
        /// <param name="input">Instance of CommitUploadSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommitUploadSession input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ChapterDraft == input.ChapterDraft ||
                    (this.ChapterDraft != null &&
                    this.ChapterDraft.Equals(input.ChapterDraft))
                ) && 
                (
                    this.PageOrder == input.PageOrder ||
                    this.PageOrder != null &&
                    input.PageOrder != null &&
                    this.PageOrder.SequenceEqual(input.PageOrder)
                ) &&
                (
                    this.TermsAccepted == input.TermsAccepted ||
                    this.TermsAccepted.Equals(input.TermsAccepted)
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
                if (this.ChapterDraft != null)
                {
                    hashCode = (hashCode * 59) + this.ChapterDraft.GetHashCode();
                }
                if (this.PageOrder != null)
                {
                    hashCode = (hashCode * 59) + this.PageOrder.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TermsAccepted.GetHashCode();
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
