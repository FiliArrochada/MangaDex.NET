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
    /// ApiClientCreate
    /// </summary>
    [DataContract(Name = "ApiClientCreate")]
    public partial class ApiClientCreate : IEquatable<ApiClientCreate>, IValidatableObject
    {
        /// <summary>
        /// Defines Profile
        /// </summary>
        [JsonConverter(typeof(MangaDex.Client.StringEnumMemberConverter))]
        public enum ProfileEnum
        {
            /// <summary>
            /// Enum Personal for value: personal
            /// </summary>
            [EnumMember(Value = "personal")]
            Personal = 1
        }


        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name = "profile", IsRequired = true, EmitDefaultValue = true)]
        [JsonPropertyName("profile")]
        public ProfileEnum Profile { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClientCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiClientCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClientCreate" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="description">description.</param>
        /// <param name="profile">profile (required).</param>
        /// <param name="varVersion">varVersion.</param>
        public ApiClientCreate(string name = default(string), string description = default(string), ProfileEnum profile = default(ProfileEnum), int varVersion = default(int))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ApiClientCreate and cannot be null");
            }
            this.Name = name;
            this.Profile = profile;
            this.Description = description;
            this.VarVersion = varVersion;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        [JsonPropertyName("description")]
        public string Description { get; set; }

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
            sb.Append("class ApiClientCreate {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
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
            return this.Equals(input as ApiClientCreate);
        }

        /// <summary>
        /// Returns true if ApiClientCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiClientCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiClientCreate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Profile == input.Profile ||
                    this.Profile.Equals(input.Profile)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Profile.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 32.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 5.", new [] { "Name" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 1024.", new [] { "Description" });
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
