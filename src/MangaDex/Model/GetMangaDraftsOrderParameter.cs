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
    /// GetMangaDraftsOrderParameter
    /// </summary>
    [DataContract(Name = "get_manga_drafts_order_parameter")]
    public partial class GetMangaDraftsOrderParameter : IEquatable<GetMangaDraftsOrderParameter>, IValidatableObject
    {
        /// <summary>
        /// Defines Title
        /// </summary>
        [JsonConverter(typeof(MangaDex.Client.StringEnumMemberConverter))]
        public enum TitleEnum
        {
            /// <summary>
            /// Enum Asc for value: asc
            /// </summary>
            [EnumMember(Value = "asc")]
            Asc = 1,

            /// <summary>
            /// Enum Desc for value: desc
            /// </summary>
            [EnumMember(Value = "desc")]
            Desc = 2
        }


        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        [JsonPropertyName("title")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public TitleEnum? Title { get; set; }
        /// <summary>
        /// Defines Year
        /// </summary>
        [JsonConverter(typeof(MangaDex.Client.StringEnumMemberConverter))]
        public enum YearEnum
        {
            /// <summary>
            /// Enum Asc for value: asc
            /// </summary>
            [EnumMember(Value = "asc")]
            Asc = 1,

            /// <summary>
            /// Enum Desc for value: desc
            /// </summary>
            [EnumMember(Value = "desc")]
            Desc = 2
        }


        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name = "year", EmitDefaultValue = false)]
        [JsonPropertyName("year")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public YearEnum? Year { get; set; }
        /// <summary>
        /// Defines CreatedAt
        /// </summary>
        [JsonConverter(typeof(MangaDex.Client.StringEnumMemberConverter))]
        public enum CreatedAtEnum
        {
            /// <summary>
            /// Enum Asc for value: asc
            /// </summary>
            [EnumMember(Value = "asc")]
            Asc = 1,

            /// <summary>
            /// Enum Desc for value: desc
            /// </summary>
            [EnumMember(Value = "desc")]
            Desc = 2
        }


        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        [JsonPropertyName("createdAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public CreatedAtEnum? CreatedAt { get; set; }
        /// <summary>
        /// Defines UpdatedAt
        /// </summary>
        [JsonConverter(typeof(MangaDex.Client.StringEnumMemberConverter))]
        public enum UpdatedAtEnum
        {
            /// <summary>
            /// Enum Asc for value: asc
            /// </summary>
            [EnumMember(Value = "asc")]
            Asc = 1,

            /// <summary>
            /// Enum Desc for value: desc
            /// </summary>
            [EnumMember(Value = "desc")]
            Desc = 2
        }


        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        [JsonPropertyName("updatedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public UpdatedAtEnum? UpdatedAt { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMangaDraftsOrderParameter" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="year">year.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public GetMangaDraftsOrderParameter(TitleEnum? title = default(TitleEnum?), YearEnum? year = default(YearEnum?), CreatedAtEnum? createdAt = default(CreatedAtEnum?), UpdatedAtEnum? updatedAt = default(UpdatedAtEnum?))
        {
            this.Title = title;
            this.Year = year;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetMangaDraftsOrderParameter {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
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
            return this.Equals(input as GetMangaDraftsOrderParameter);
        }

        /// <summary>
        /// Returns true if GetMangaDraftsOrderParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of GetMangaDraftsOrderParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetMangaDraftsOrderParameter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Title == input.Title ||
                    this.Title.Equals(input.Title)
                ) && 
                (
                    this.Year == input.Year ||
                    this.Year.Equals(input.Year)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    this.UpdatedAt.Equals(input.UpdatedAt)
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
                hashCode = (hashCode * 59) + this.Title.GetHashCode();
                hashCode = (hashCode * 59) + this.Year.GetHashCode();
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
