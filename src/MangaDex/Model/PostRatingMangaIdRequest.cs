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
    /// PostRatingMangaIdRequest
    /// </summary>
    [DataContract(Name = "post_rating_manga_id_request")]
    public partial class PostRatingMangaIdRequest : IEquatable<PostRatingMangaIdRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostRatingMangaIdRequest" /> class.
        /// </summary>
        /// <param name="rating">rating.</param>
        public PostRatingMangaIdRequest(int rating = default(int))
        {
            this.Rating = rating;
        }

        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name = "rating", EmitDefaultValue = false)]
        [JsonPropertyName("rating")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Rating { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostRatingMangaIdRequest {\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
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
            return this.Equals(input as PostRatingMangaIdRequest);
        }

        /// <summary>
        /// Returns true if PostRatingMangaIdRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PostRatingMangaIdRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostRatingMangaIdRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Rating == input.Rating ||
                    this.Rating.Equals(input.Rating)
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
                hashCode = (hashCode * 59) + this.Rating.GetHashCode();
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
            // Rating (int) maximum
            if (this.Rating > (int)10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Rating, must be a value less than or equal to 10.", new [] { "Rating" });
            }

            // Rating (int) minimum
            if (this.Rating < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Rating, must be a value greater than or equal to 1.", new [] { "Rating" });
            }

            yield break;
        }
    }

}
