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
    /// PostSettingsRequest
    /// </summary>
    [DataContract(Name = "post_settings_request")]
    public partial class PostSettingsRequest : IEquatable<PostSettingsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostSettingsRequest" /> class.
        /// </summary>
        /// <param name="settings">A JSON object that can be validated against the lastest available template.</param>
        /// <param name="updatedAt">Format: 2022-03-14T13:19:37.</param>
        public PostSettingsRequest(Object settings = default(Object), DateTime updatedAt = default(DateTime))
        {
            this.Settings = settings;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// A JSON object that can be validated against the lastest available template
        /// </summary>
        /// <value>A JSON object that can be validated against the lastest available template</value>
        [DataMember(Name = "settings", EmitDefaultValue = false)]
        [JsonPropertyName("settings")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Object Settings { get; set; }

        /// <summary>
        /// Format: 2022-03-14T13:19:37
        /// </summary>
        /// <value>Format: 2022-03-14T13:19:37</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        [JsonPropertyName("updatedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostSettingsRequest {\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
            return this.Equals(input as PostSettingsRequest);
        }

        /// <summary>
        /// Returns true if PostSettingsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PostSettingsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostSettingsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.Equals(input.Settings))
                ) &&
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Settings != null)
                {
                    hashCode = (hashCode * 59) + this.Settings.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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