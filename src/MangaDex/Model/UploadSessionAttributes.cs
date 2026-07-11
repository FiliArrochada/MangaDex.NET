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
    /// UploadSessionAttributes
    /// </summary>
    [DataContract(Name = "UploadSessionAttributes")]
    public partial class UploadSessionAttributes : IEquatable<UploadSessionAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadSessionAttributes" /> class.
        /// </summary>
        /// <param name="isCommitted">isCommitted.</param>
        /// <param name="isProcessed">isProcessed.</param>
        /// <param name="isDeleted">isDeleted.</param>
        /// <param name="varVersion">varVersion.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public UploadSessionAttributes(bool isCommitted = default(bool), bool isProcessed = default(bool), bool isDeleted = default(bool), int varVersion = default(int), string createdAt = default(string), string updatedAt = default(string))
        {
            this.IsCommitted = isCommitted;
            this.IsProcessed = isProcessed;
            this.IsDeleted = isDeleted;
            this.VarVersion = varVersion;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets IsCommitted
        /// </summary>
        [DataMember(Name = "isCommitted", EmitDefaultValue = true)]
        [JsonPropertyName("isCommitted")]
        public bool IsCommitted { get; set; }

        /// <summary>
        /// Gets or Sets IsProcessed
        /// </summary>
        [DataMember(Name = "isProcessed", EmitDefaultValue = true)]
        [JsonPropertyName("isProcessed")]
        public bool IsProcessed { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        [JsonPropertyName("isDeleted")]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        [JsonPropertyName("version")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int VarVersion { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        [JsonPropertyName("createdAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        [JsonPropertyName("updatedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UploadSessionAttributes {\n");
            sb.Append("  IsCommitted: ").Append(IsCommitted).Append("\n");
            sb.Append("  IsProcessed: ").Append(IsProcessed).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as UploadSessionAttributes);
        }

        /// <summary>
        /// Returns true if UploadSessionAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of UploadSessionAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadSessionAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IsCommitted == input.IsCommitted ||
                    this.IsCommitted.Equals(input.IsCommitted)
                ) && 
                (
                    this.IsProcessed == input.IsProcessed ||
                    this.IsProcessed.Equals(input.IsProcessed)
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    this.IsDeleted.Equals(input.IsDeleted)
                ) && 
                (
                    this.VarVersion == input.VarVersion ||
                    this.VarVersion.Equals(input.VarVersion)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                hashCode = (hashCode * 59) + this.IsCommitted.GetHashCode();
                hashCode = (hashCode * 59) + this.IsProcessed.GetHashCode();
                hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
                hashCode = (hashCode * 59) + this.VarVersion.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
            // VarVersion (int) minimum
            if (this.VarVersion < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VarVersion, must be a value greater than or equal to 1.", new [] { "VarVersion" });
            }

            yield break;
        }
    }

}
