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
    /// BeginUploadSession
    /// </summary>
    [DataContract(Name = "BeginUploadSession")]
    public partial class BeginUploadSession : IEquatable<BeginUploadSession>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeginUploadSession" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BeginUploadSession()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="BeginUploadSession" /> class.
        /// </summary>
        /// <param name="groups">groups (required).</param>
        /// <param name="manga">manga (required).</param>
        public BeginUploadSession(List<Guid> groups = default(List<Guid>), Guid manga = default(Guid))
        {
            // to ensure "groups" is required (not null)
            if (groups == null)
            {
                throw new ArgumentNullException("groups is a required property for BeginUploadSession and cannot be null");
            }
            this.Groups = groups;
            this.Manga = manga;
        }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name = "groups", IsRequired = true, EmitDefaultValue = true)]
        [JsonPropertyName("groups")]
        public List<Guid> Groups { get; set; }

        /// <summary>
        /// Gets or Sets Manga
        /// </summary>
        [DataMember(Name = "manga", IsRequired = true, EmitDefaultValue = true)]
        [JsonPropertyName("manga")]
        public Guid Manga { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BeginUploadSession {\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Manga: ").Append(Manga).Append("\n");
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
            return this.Equals(input as BeginUploadSession);
        }

        /// <summary>
        /// Returns true if BeginUploadSession instances are equal
        /// </summary>
        /// <param name="input">Instance of BeginUploadSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeginUploadSession input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) &&
                (
                    this.Manga == input.Manga ||
                    (this.Manga != null &&
                    this.Manga.Equals(input.Manga))
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
                if (this.Groups != null)
                {
                    hashCode = (hashCode * 59) + this.Groups.GetHashCode();
                }
                if (this.Manga != null)
                {
                    hashCode = (hashCode * 59) + this.Manga.GetHashCode();
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
            // Manga is a Guid, which is always a valid 36-character UUID; no length validation required.
            yield break;
        }
    }
}