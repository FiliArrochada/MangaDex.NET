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
    /// GetMangaChapterReadmarkers200Response
    /// </summary>
    [DataContract(Name = "get_manga_chapter_readmarkers_200_response")]
    public partial class GetMangaChapterReadmarkers200Response : IEquatable<GetMangaChapterReadmarkers200Response>, IValidatableObject
    {
        /// <summary>
        /// Defines Result
        /// </summary>
        [JsonConverter(typeof(MangaDex.Client.StringEnumMemberConverter))]
        public enum ResultEnum
        {
            /// <summary>
            /// Enum Ok for value: ok
            /// </summary>
            [EnumMember(Value = "ok")]
            Ok = 1
        }


        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        [JsonPropertyName("result")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public ResultEnum? Result { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMangaChapterReadmarkers200Response" /> class.
        /// </summary>
        /// <param name="result">result.</param>
        /// <param name="data">data.</param>
        public GetMangaChapterReadmarkers200Response(ResultEnum? result = default(ResultEnum?), List<Guid> data = default(List<Guid>))
        {
            this.Result = result;
            this.Data = data;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        [JsonPropertyName("data")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<Guid> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetMangaChapterReadmarkers200Response {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as GetMangaChapterReadmarkers200Response);
        }

        /// <summary>
        /// Returns true if GetMangaChapterReadmarkers200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of GetMangaChapterReadmarkers200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetMangaChapterReadmarkers200Response input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Result == input.Result ||
                    this.Result.Equals(input.Result)
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                hashCode = (hashCode * 59) + this.Result.GetHashCode();
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
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
