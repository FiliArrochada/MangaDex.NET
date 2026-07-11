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
    /// GetCoverOrderParameter
    /// </summary>
    [DataContract(Name = "get_cover_order_parameter")]
    public partial class GetCoverOrderParameter : IEquatable<GetCoverOrderParameter>, IValidatableObject
    {
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
        /// Defines Volume
        /// </summary>
        [JsonConverter(typeof(MangaDex.Client.StringEnumMemberConverter))]
        public enum VolumeEnum
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
        /// Gets or Sets Volume
        /// </summary>
        [DataMember(Name = "volume", EmitDefaultValue = false)]
        [JsonPropertyName("volume")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public VolumeEnum? Volume { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCoverOrderParameter" /> class.
        /// </summary>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="volume">volume.</param>
        public GetCoverOrderParameter(CreatedAtEnum? createdAt = default(CreatedAtEnum?), UpdatedAtEnum? updatedAt = default(UpdatedAtEnum?), VolumeEnum? volume = default(VolumeEnum?))
        {
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Volume = volume;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetCoverOrderParameter {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
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
            return this.Equals(input as GetCoverOrderParameter);
        }

        /// <summary>
        /// Returns true if GetCoverOrderParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCoverOrderParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCoverOrderParameter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    this.UpdatedAt.Equals(input.UpdatedAt)
                ) && 
                (
                    this.Volume == input.Volume ||
                    this.Volume.Equals(input.Volume)
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
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                hashCode = (hashCode * 59) + this.Volume.GetHashCode();
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
