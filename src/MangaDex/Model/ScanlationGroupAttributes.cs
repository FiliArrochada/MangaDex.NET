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
using System.Text.RegularExpressions;

namespace MangaDex.Model
{
    /// <summary>
    /// ScanlationGroupAttributes
    /// </summary>
    [DataContract(Name = "ScanlationGroupAttributes")]
    public partial class ScanlationGroupAttributes : IEquatable<ScanlationGroupAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScanlationGroupAttributes" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="altNames">altNames.</param>
        /// <param name="website">website.</param>
        /// <param name="ircServer">ircServer.</param>
        /// <param name="ircChannel">ircChannel.</param>
        /// <param name="discord">discord.</param>
        /// <param name="contactEmail">contactEmail.</param>
        /// <param name="description">description.</param>
        /// <param name="twitter">twitter.</param>
        /// <param name="mangaUpdates">mangaUpdates.</param>
        /// <param name="focusedLanguage">focusedLanguage.</param>
        /// <param name="locked">locked.</param>
        /// <param name="official">official.</param>
        /// <param name="verified">verified.</param>
        /// <param name="inactive">inactive.</param>
        /// <param name="exLicensed">exLicensed.</param>
        /// <param name="publishDelay">Should respected ISO 8601 duration specification: https://en.wikipedia.org/wiki/ISO_8601#Durations.</param>
        /// <param name="varVersion">varVersion.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public ScanlationGroupAttributes(string name = default(string), List<Dictionary<string, string>> altNames = default(List<Dictionary<string, string>>), string website = default(string), string ircServer = default(string), string ircChannel = default(string), string discord = default(string), string contactEmail = default(string), string description = default(string), string twitter = default(string), string mangaUpdates = default(string), List<string> focusedLanguage = default(List<string>), bool locked = default(bool), bool official = default(bool), bool verified = default(bool), bool inactive = default(bool), bool exLicensed = default(bool), string publishDelay = default(string), int varVersion = default(int), string createdAt = default(string), string updatedAt = default(string))
        {
            this.Name = name;
            this.AltNames = altNames;
            this.Website = website;
            this.IrcServer = ircServer;
            this.IrcChannel = ircChannel;
            this.Discord = discord;
            this.ContactEmail = contactEmail;
            this.Description = description;
            this.Twitter = twitter;
            this.MangaUpdates = mangaUpdates;
            this.FocusedLanguage = focusedLanguage;
            this.Locked = locked;
            this.Official = official;
            this.Verified = verified;
            this.Inactive = inactive;
            this.ExLicensed = exLicensed;
            this.PublishDelay = publishDelay;
            this.VarVersion = varVersion;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AltNames
        /// </summary>
        [DataMember(Name = "altNames", EmitDefaultValue = false)]
        [JsonPropertyName("altNames")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<Dictionary<string, string>> AltNames { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name = "website", EmitDefaultValue = true)]
        [JsonPropertyName("website")]
        public string Website { get; set; }

        /// <summary>
        /// Gets or Sets IrcServer
        /// </summary>
        [DataMember(Name = "ircServer", EmitDefaultValue = true)]
        [JsonPropertyName("ircServer")]
        public string IrcServer { get; set; }

        /// <summary>
        /// Gets or Sets IrcChannel
        /// </summary>
        [DataMember(Name = "ircChannel", EmitDefaultValue = true)]
        [JsonPropertyName("ircChannel")]
        public string IrcChannel { get; set; }

        /// <summary>
        /// Gets or Sets Discord
        /// </summary>
        [DataMember(Name = "discord", EmitDefaultValue = true)]
        [JsonPropertyName("discord")]
        public string Discord { get; set; }

        /// <summary>
        /// Gets or Sets ContactEmail
        /// </summary>
        [DataMember(Name = "contactEmail", EmitDefaultValue = true)]
        [JsonPropertyName("contactEmail")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Twitter
        /// </summary>
        [DataMember(Name = "twitter", EmitDefaultValue = true)]
        [JsonPropertyName("twitter")]
        public string Twitter { get; set; }

        /// <summary>
        /// Gets or Sets MangaUpdates
        /// </summary>
        [DataMember(Name = "mangaUpdates", EmitDefaultValue = true)]
        [JsonPropertyName("mangaUpdates")]
        public string MangaUpdates { get; set; }

        /// <summary>
        /// Gets or Sets FocusedLanguage
        /// </summary>
        [DataMember(Name = "focusedLanguage", EmitDefaultValue = true)]
        [JsonPropertyName("focusedLanguage")]
        public List<string> FocusedLanguage { get; set; }

        /// <summary>
        /// Gets or Sets Locked
        /// </summary>
        [DataMember(Name = "locked", EmitDefaultValue = true)]
        [JsonPropertyName("locked")]
        public bool Locked { get; set; }

        /// <summary>
        /// Gets or Sets Official
        /// </summary>
        [DataMember(Name = "official", EmitDefaultValue = true)]
        [JsonPropertyName("official")]
        public bool Official { get; set; }

        /// <summary>
        /// Gets or Sets Verified
        /// </summary>
        [DataMember(Name = "verified", EmitDefaultValue = true)]
        [JsonPropertyName("verified")]
        public bool Verified { get; set; }

        /// <summary>
        /// Gets or Sets Inactive
        /// </summary>
        [DataMember(Name = "inactive", EmitDefaultValue = true)]
        [JsonPropertyName("inactive")]
        public bool Inactive { get; set; }

        /// <summary>
        /// Gets or Sets ExLicensed
        /// </summary>
        [DataMember(Name = "exLicensed", EmitDefaultValue = true)]
        [JsonPropertyName("exLicensed")]
        public bool ExLicensed { get; set; }

        /// <summary>
        /// Should respected ISO 8601 duration specification: https://en.wikipedia.org/wiki/ISO_8601#Durations
        /// </summary>
        /// <value>Should respected ISO 8601 duration specification: https://en.wikipedia.org/wiki/ISO_8601#Durations</value>
        /// <example>P4D</example>
        [DataMember(Name = "publishDelay", EmitDefaultValue = false)]
        [JsonPropertyName("publishDelay")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string PublishDelay { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        [JsonPropertyName("version")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int VarVersion { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        [JsonPropertyName("createdAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        [JsonPropertyName("updatedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScanlationGroupAttributes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AltNames: ").Append(AltNames).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  IrcServer: ").Append(IrcServer).Append("\n");
            sb.Append("  IrcChannel: ").Append(IrcChannel).Append("\n");
            sb.Append("  Discord: ").Append(Discord).Append("\n");
            sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Twitter: ").Append(Twitter).Append("\n");
            sb.Append("  MangaUpdates: ").Append(MangaUpdates).Append("\n");
            sb.Append("  FocusedLanguage: ").Append(FocusedLanguage).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  Official: ").Append(Official).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
            sb.Append("  Inactive: ").Append(Inactive).Append("\n");
            sb.Append("  ExLicensed: ").Append(ExLicensed).Append("\n");
            sb.Append("  PublishDelay: ").Append(PublishDelay).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as ScanlationGroupAttributes);
        }

        /// <summary>
        /// Returns true if ScanlationGroupAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of ScanlationGroupAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScanlationGroupAttributes input)
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
                    this.AltNames == input.AltNames ||
                    this.AltNames != null &&
                    input.AltNames != null &&
                    this.AltNames.SequenceEqual(input.AltNames)
                ) &&
                (
                    this.Website == input.Website ||
                    (this.Website != null &&
                    this.Website.Equals(input.Website))
                ) &&
                (
                    this.IrcServer == input.IrcServer ||
                    (this.IrcServer != null &&
                    this.IrcServer.Equals(input.IrcServer))
                ) &&
                (
                    this.IrcChannel == input.IrcChannel ||
                    (this.IrcChannel != null &&
                    this.IrcChannel.Equals(input.IrcChannel))
                ) &&
                (
                    this.Discord == input.Discord ||
                    (this.Discord != null &&
                    this.Discord.Equals(input.Discord))
                ) &&
                (
                    this.ContactEmail == input.ContactEmail ||
                    (this.ContactEmail != null &&
                    this.ContactEmail.Equals(input.ContactEmail))
                ) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) &&
                (
                    this.Twitter == input.Twitter ||
                    (this.Twitter != null &&
                    this.Twitter.Equals(input.Twitter))
                ) &&
                (
                    this.MangaUpdates == input.MangaUpdates ||
                    (this.MangaUpdates != null &&
                    this.MangaUpdates.Equals(input.MangaUpdates))
                ) &&
                (
                    this.FocusedLanguage == input.FocusedLanguage ||
                    this.FocusedLanguage != null &&
                    input.FocusedLanguage != null &&
                    this.FocusedLanguage.SequenceEqual(input.FocusedLanguage)
                ) &&
                (
                    this.Locked == input.Locked ||
                    this.Locked.Equals(input.Locked)
                ) &&
                (
                    this.Official == input.Official ||
                    this.Official.Equals(input.Official)
                ) &&
                (
                    this.Verified == input.Verified ||
                    this.Verified.Equals(input.Verified)
                ) &&
                (
                    this.Inactive == input.Inactive ||
                    this.Inactive.Equals(input.Inactive)
                ) &&
                (
                    this.ExLicensed == input.ExLicensed ||
                    this.ExLicensed.Equals(input.ExLicensed)
                ) &&
                (
                    this.PublishDelay == input.PublishDelay ||
                    (this.PublishDelay != null &&
                    this.PublishDelay.Equals(input.PublishDelay))
                ) &&
                (
                    this.VarVersion == input.VarVersion ||
                    this.VarVersion.Equals(input.VarVersion)
                ) &&
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.AltNames != null)
                {
                    hashCode = (hashCode * 59) + this.AltNames.GetHashCode();
                }
                if (this.Website != null)
                {
                    hashCode = (hashCode * 59) + this.Website.GetHashCode();
                }
                if (this.IrcServer != null)
                {
                    hashCode = (hashCode * 59) + this.IrcServer.GetHashCode();
                }
                if (this.IrcChannel != null)
                {
                    hashCode = (hashCode * 59) + this.IrcChannel.GetHashCode();
                }
                if (this.Discord != null)
                {
                    hashCode = (hashCode * 59) + this.Discord.GetHashCode();
                }
                if (this.ContactEmail != null)
                {
                    hashCode = (hashCode * 59) + this.ContactEmail.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Twitter != null)
                {
                    hashCode = (hashCode * 59) + this.Twitter.GetHashCode();
                }
                if (this.MangaUpdates != null)
                {
                    hashCode = (hashCode * 59) + this.MangaUpdates.GetHashCode();
                }
                if (this.FocusedLanguage != null)
                {
                    hashCode = (hashCode * 59) + this.FocusedLanguage.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Locked.GetHashCode();
                hashCode = (hashCode * 59) + this.Official.GetHashCode();
                hashCode = (hashCode * 59) + this.Verified.GetHashCode();
                hashCode = (hashCode * 59) + this.Inactive.GetHashCode();
                hashCode = (hashCode * 59) + this.ExLicensed.GetHashCode();
                if (this.PublishDelay != null)
                {
                    hashCode = (hashCode * 59) + this.PublishDelay.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VarVersion.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
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
            if (this.Twitter != null)
            {
                // Twitter (string) pattern
                Regex regexTwitter = new Regex(@"^https?://", RegexOptions.CultureInvariant);
                if (!regexTwitter.Match(this.Twitter).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Twitter, must match a pattern of " + regexTwitter, new[] { "Twitter" });
                }
            }

            // MangaUpdates (string) maxLength
            if (this.MangaUpdates != null && this.MangaUpdates.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MangaUpdates, length must be less than 128.", new[] { "MangaUpdates" });
            }

            if (this.MangaUpdates != null)
            {
                // MangaUpdates (string) pattern
                Regex regexMangaUpdates = new Regex(@"^https:\/\/www\.mangaupdates\.com\/(group|publisher)(s\.html\?id=\d+|\/[\w-]+\/?([\w-]+)?(\/)?)$", RegexOptions.CultureInvariant);
                if (!regexMangaUpdates.Match(this.MangaUpdates).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MangaUpdates, must match a pattern of " + regexMangaUpdates, new[] { "MangaUpdates" });
                }
            }

            if (this.PublishDelay != null)
            {
                // PublishDelay (string) pattern
                Regex regexPublishDelay = new Regex(@"^(P([1-9]|[1-9][0-9])D)?(P?([1-9])W)?(P?T(([1-9]|1[0-9]|2[0-4])H)?(([1-9]|[1-5][0-9]|60)M)?(([1-9]|[1-5][0-9]|60)S)?)?$", RegexOptions.CultureInvariant);
                if (!regexPublishDelay.Match(this.PublishDelay).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PublishDelay, must match a pattern of " + regexPublishDelay, new[] { "PublishDelay" });
                }
            }

            // VarVersion (int) minimum
            if (this.VarVersion < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VarVersion, must be a value greater than or equal to 1.", new[] { "VarVersion" });
            }

            yield break;
        }
    }
}