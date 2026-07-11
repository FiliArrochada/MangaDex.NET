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
    /// CoverEdit
    /// </summary>
    [DataContract(Name = "CoverEdit")]
    public partial class CoverEdit : IEquatable<CoverEdit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoverEdit" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CoverEdit() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CoverEdit" /> class.
        /// </summary>
        /// <param name="volume">volume (required).</param>
        /// <param name="description">description.</param>
        /// <param name="locale">locale.</param>
        /// <param name="varVersion">varVersion (required).</param>
        public CoverEdit(string volume = default(string), string description = default(string), string locale = default(string), int varVersion = default(int))
        {
            // to ensure "volume" is required (not null)
            if (volume == null)
            {
                throw new ArgumentNullException("volume is a required property for CoverEdit and cannot be null");
            }
            this.Volume = volume;
            this.VarVersion = varVersion;
            this.Description = description;
            this.Locale = locale;
        }

        /// <summary>
        /// Gets or Sets Volume
        /// </summary>
        [DataMember(Name = "volume", IsRequired = true, EmitDefaultValue = true)]
        [JsonPropertyName("volume")]
        public string Volume { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name = "locale", EmitDefaultValue = true)]
        [JsonPropertyName("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        [JsonPropertyName("version")]
        public int VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CoverEdit {\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
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
            return this.Equals(input as CoverEdit);
        }

        /// <summary>
        /// Returns true if CoverEdit instances are equal
        /// </summary>
        /// <param name="input">Instance of CoverEdit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CoverEdit input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
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
                if (this.Volume != null)
                {
                    hashCode = (hashCode * 59) + this.Volume.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Locale != null)
                {
                    hashCode = (hashCode * 59) + this.Locale.GetHashCode();
                }
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
            // Volume (string) maxLength
            if (this.Volume != null && this.Volume.Length > 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Volume, length must be less than 8.", new [] { "Volume" });
            }

            // Volume (string) minLength
            if (this.Volume != null && this.Volume.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Volume, length must be greater than 0.", new [] { "Volume" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 512.", new [] { "Description" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
            }

            if (this.Locale != null) {
                // Locale (string) pattern
Regex regexLocale = new Regex(@"^[a-z]{2}(-[a-z]{2})?$", RegexOptions.CultureInvariant);
if (!regexLocale.Match(this.Locale).Success)
{
    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Locale, must match a pattern of " + regexLocale, new [] { "Locale" });
}
            }

            // VarVersion (int) minimum
            if (this.VarVersion < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VarVersion, must be a value greater than or equal to 1.", new [] { "VarVersion" });
            }

            yield break;
        }
    }

}
