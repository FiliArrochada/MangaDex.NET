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
    /// GetStatisticsManga200Response
    /// </summary>
    [DataContract(Name = "get_statistics_manga_200_response")]
    public partial class GetStatisticsManga200Response : IEquatable<GetStatisticsManga200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatisticsManga200Response" /> class.
        /// </summary>
        /// <param name="result">result (default to &quot;ok&quot;).</param>
        /// <param name="statistics">statistics.</param>
        public GetStatisticsManga200Response(string result = @"ok", Dictionary<string, GetStatisticsManga200ResponseStatisticsValue> statistics = default(Dictionary<string, GetStatisticsManga200ResponseStatisticsValue>))
        {
            // use default value if no "result" provided
            this.Result = result ?? @"ok";
            this.Statistics = statistics;
        }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        [JsonPropertyName("result")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Result { get; set; }

        /// <summary>
        /// Gets or Sets Statistics
        /// </summary>
        [DataMember(Name = "statistics", EmitDefaultValue = false)]
        [JsonPropertyName("statistics")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Dictionary<string, GetStatisticsManga200ResponseStatisticsValue> Statistics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetStatisticsManga200Response {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Statistics: ").Append(Statistics).Append("\n");
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
            return this.Equals(input as GetStatisticsManga200Response);
        }

        /// <summary>
        /// Returns true if GetStatisticsManga200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of GetStatisticsManga200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetStatisticsManga200Response input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) &&
                (
                    this.Statistics == input.Statistics ||
                    this.Statistics != null &&
                    input.Statistics != null &&
                    this.Statistics.SequenceEqual(input.Statistics)
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
                if (this.Result != null)
                {
                    hashCode = (hashCode * 59) + this.Result.GetHashCode();
                }
                if (this.Statistics != null)
                {
                    hashCode = (hashCode * 59) + this.Statistics.GetHashCode();
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