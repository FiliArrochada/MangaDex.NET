/*
 * MangaDex API
 *
 * MangaDex is an ad-free manga reader offering high-quality images!  This document details our API as it is right now. It is in no way a promise to never change it, although we will endeavour to publicly notify any major change.  # Acceptable use policy  Usage of our services implies acceptance of the following: - You **MUST** credit us - You **MUST** credit scanlation groups if you offer the ability to read chapters - You **CANNOT** run ads or paid services on your website and/or apps  These may change at any time for any and no reason and it is up to you check for updates from time to time.  # Security issues  If you believe you found a security issue in our API, please check our [security.txt](/security.txt) to get in touch privately.
 *
 * The version of the OpenAPI document: 5.13.1
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
    /// UploadCheckApprovalRequiredRequest
    /// </summary>
    [DataContract(Name = "upload_check_approval_required_request")]
    public partial class UploadCheckApprovalRequiredRequest : IEquatable<UploadCheckApprovalRequiredRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadCheckApprovalRequiredRequest" /> class.
        /// </summary>
        /// <param name="manga">manga.</param>
        /// <param name="locale">locale.</param>
        public UploadCheckApprovalRequiredRequest(Guid manga = default(Guid), string locale = default(string))
        {
            this.Manga = manga;
            this.Locale = locale;
        }

        /// <summary>
        /// Gets or Sets Manga
        /// </summary>
        [DataMember(Name = "manga", EmitDefaultValue = false)]
        [JsonPropertyName("manga")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Guid Manga { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        [JsonPropertyName("locale")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Locale { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UploadCheckApprovalRequiredRequest {\n");
            sb.Append("  Manga: ").Append(Manga).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
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
            return this.Equals(input as UploadCheckApprovalRequiredRequest);
        }

        /// <summary>
        /// Returns true if UploadCheckApprovalRequiredRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UploadCheckApprovalRequiredRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadCheckApprovalRequiredRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Manga == input.Manga ||
                    (this.Manga != null &&
                    this.Manga.Equals(input.Manga))
                ) &&
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
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
                if (this.Manga != null)
                {
                    hashCode = (hashCode * 59) + this.Manga.GetHashCode();
                }
                if (this.Locale != null)
                {
                    hashCode = (hashCode * 59) + this.Locale.GetHashCode();
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
