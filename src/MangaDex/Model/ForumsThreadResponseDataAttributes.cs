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
    /// ForumsThreadResponseDataAttributes
    /// </summary>
    [DataContract(Name = "ForumsThreadResponse_data_attributes")]
    public partial class ForumsThreadResponseDataAttributes : IEquatable<ForumsThreadResponseDataAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForumsThreadResponseDataAttributes" /> class.
        /// </summary>
        /// <param name="repliesCount">The number of replies so far in the forums thread returned.</param>
        public ForumsThreadResponseDataAttributes(int repliesCount = default(int))
        {
            this.RepliesCount = repliesCount;
        }

        /// <summary>
        /// The number of replies so far in the forums thread returned
        /// </summary>
        /// <value>The number of replies so far in the forums thread returned</value>
        [DataMember(Name = "repliesCount", EmitDefaultValue = false)]
        [JsonPropertyName("repliesCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int RepliesCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ForumsThreadResponseDataAttributes {\n");
            sb.Append("  RepliesCount: ").Append(RepliesCount).Append("\n");
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
            return this.Equals(input as ForumsThreadResponseDataAttributes);
        }

        /// <summary>
        /// Returns true if ForumsThreadResponseDataAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of ForumsThreadResponseDataAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForumsThreadResponseDataAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.RepliesCount == input.RepliesCount ||
                    this.RepliesCount.Equals(input.RepliesCount)
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
                hashCode = (hashCode * 59) + this.RepliesCount.GetHashCode();
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