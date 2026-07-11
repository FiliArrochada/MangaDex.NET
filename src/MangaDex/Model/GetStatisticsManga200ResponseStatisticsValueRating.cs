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
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace MangaDex.Model
{
    /// <summary>
    /// GetStatisticsManga200ResponseStatisticsValueRating
    /// </summary>
    [DataContract(Name = "get_statistics_manga_200_response_statistics_value_rating")]
    public partial class GetStatisticsManga200ResponseStatisticsValueRating : IEquatable<GetStatisticsManga200ResponseStatisticsValueRating>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatisticsManga200ResponseStatisticsValueRating" /> class.
        /// </summary>
        /// <param name="average">Will be nullable if no ratings has been done.</param>
        /// <param name="bayesian">Average weighted on all the Manga population.</param>
        public GetStatisticsManga200ResponseStatisticsValueRating(decimal? average = default(decimal?), decimal bayesian = default(decimal))
        {
            this.Average = average;
            this.Bayesian = bayesian;
        }

        /// <summary>
        /// Will be nullable if no ratings has been done
        /// </summary>
        /// <value>Will be nullable if no ratings has been done</value>
        [DataMember(Name = "average", EmitDefaultValue = true)]
        [JsonPropertyName("average")]
        public decimal? Average { get; set; }

        /// <summary>
        /// Average weighted on all the Manga population
        /// </summary>
        /// <value>Average weighted on all the Manga population</value>
        [DataMember(Name = "bayesian", EmitDefaultValue = false)]
        [JsonPropertyName("bayesian")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public decimal Bayesian { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetStatisticsManga200ResponseStatisticsValueRating {\n");
            sb.Append("  Average: ").Append(Average).Append("\n");
            sb.Append("  Bayesian: ").Append(Bayesian).Append("\n");
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
            return this.Equals(input as GetStatisticsManga200ResponseStatisticsValueRating);
        }

        /// <summary>
        /// Returns true if GetStatisticsManga200ResponseStatisticsValueRating instances are equal
        /// </summary>
        /// <param name="input">Instance of GetStatisticsManga200ResponseStatisticsValueRating to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetStatisticsManga200ResponseStatisticsValueRating input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Average == input.Average ||
                    (this.Average != null &&
                    this.Average.Equals(input.Average))
                ) &&
                (
                    this.Bayesian == input.Bayesian ||
                    this.Bayesian.Equals(input.Bayesian)
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
                if (this.Average != null)
                {
                    hashCode = (hashCode * 59) + this.Average.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Bayesian.GetHashCode();
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