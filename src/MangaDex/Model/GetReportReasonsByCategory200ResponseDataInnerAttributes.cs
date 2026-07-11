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
    /// GetReportReasonsByCategory200ResponseDataInnerAttributes
    /// </summary>
    [DataContract(Name = "get_report_reasons_by_category_200_response_data_inner_attributes")]
    public partial class GetReportReasonsByCategory200ResponseDataInnerAttributes : IEquatable<GetReportReasonsByCategory200ResponseDataInnerAttributes>, IValidatableObject
    {
        /// <summary>
        /// Defines Category
        /// </summary>
        [JsonConverter(typeof(MangaDex.Client.StringEnumMemberConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Enum Manga for value: manga
            /// </summary>
            [EnumMember(Value = "manga")]
            Manga = 1,

            /// <summary>
            /// Enum Chapter for value: chapter
            /// </summary>
            [EnumMember(Value = "chapter")]
            Chapter = 2,

            /// <summary>
            /// Enum ScanlationGroup for value: scanlation_group
            /// </summary>
            [EnumMember(Value = "scanlation_group")]
            ScanlationGroup = 3,

            /// <summary>
            /// Enum User for value: user
            /// </summary>
            [EnumMember(Value = "user")]
            User = 4,

            /// <summary>
            /// Enum Author for value: author
            /// </summary>
            [EnumMember(Value = "author")]
            Author = 5
        }


        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        [JsonPropertyName("category")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportReasonsByCategory200ResponseDataInnerAttributes" /> class.
        /// </summary>
        /// <param name="reason">reason.</param>
        /// <param name="detailsRequired">detailsRequired.</param>
        /// <param name="category">category.</param>
        /// <param name="varVersion">varVersion.</param>
        public GetReportReasonsByCategory200ResponseDataInnerAttributes(Dictionary<string, string> reason = default(Dictionary<string, string>), bool detailsRequired = default(bool), CategoryEnum? category = default(CategoryEnum?), int varVersion = default(int))
        {
            this.Reason = reason;
            this.DetailsRequired = detailsRequired;
            this.Category = category;
            this.VarVersion = varVersion;
        }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        [JsonPropertyName("reason")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Dictionary<string, string> Reason { get; set; }

        /// <summary>
        /// Gets or Sets DetailsRequired
        /// </summary>
        [DataMember(Name = "detailsRequired", EmitDefaultValue = true)]
        [JsonPropertyName("detailsRequired")]
        public bool DetailsRequired { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        [JsonPropertyName("version")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetReportReasonsByCategory200ResponseDataInnerAttributes {\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  DetailsRequired: ").Append(DetailsRequired).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
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
            return this.Equals(input as GetReportReasonsByCategory200ResponseDataInnerAttributes);
        }

        /// <summary>
        /// Returns true if GetReportReasonsByCategory200ResponseDataInnerAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of GetReportReasonsByCategory200ResponseDataInnerAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetReportReasonsByCategory200ResponseDataInnerAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Reason == input.Reason ||
                    this.Reason != null &&
                    input.Reason != null &&
                    this.Reason.SequenceEqual(input.Reason)
                ) && 
                (
                    this.DetailsRequired == input.DetailsRequired ||
                    this.DetailsRequired.Equals(input.DetailsRequired)
                ) && 
                (
                    this.Category == input.Category ||
                    this.Category.Equals(input.Category)
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
                if (this.Reason != null)
                {
                    hashCode = (hashCode * 59) + this.Reason.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DetailsRequired.GetHashCode();
                hashCode = (hashCode * 59) + this.Category.GetHashCode();
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
            // VarVersion (int) minimum
            if (this.VarVersion < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VarVersion, must be a value greater than or equal to 1.", new [] { "VarVersion" });
            }

            yield break;
        }
    }

}
