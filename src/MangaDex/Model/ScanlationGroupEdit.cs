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
    /// ScanlationGroupEdit
    /// </summary>
    [DataContract(Name = "ScanlationGroupEdit")]
    public partial class ScanlationGroupEdit : IEquatable<ScanlationGroupEdit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScanlationGroupEdit" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScanlationGroupEdit() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScanlationGroupEdit" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="leader">leader.</param>
        /// <param name="members">members.</param>
        /// <param name="website">website.</param>
        /// <param name="ircServer">ircServer.</param>
        /// <param name="ircChannel">ircChannel.</param>
        /// <param name="discord">discord.</param>
        /// <param name="contactEmail">contactEmail.</param>
        /// <param name="description">description.</param>
        /// <param name="twitter">twitter.</param>
        /// <param name="mangaUpdates">mangaUpdates.</param>
        /// <param name="focusedLanguages">focusedLanguages.</param>
        /// <param name="inactive">inactive.</param>
        /// <param name="locked">locked.</param>
        /// <param name="publishDelay">publishDelay.</param>
        /// <param name="varVersion">varVersion (required).</param>
        public ScanlationGroupEdit(string name = default(string), Guid leader = default(Guid), List<Guid> members = default(List<Guid>), string website = default(string), string ircServer = default(string), string ircChannel = default(string), string discord = default(string), string contactEmail = default(string), string description = default(string), string twitter = default(string), string mangaUpdates = default(string), List<string> focusedLanguages = default(List<string>), bool inactive = default(bool), bool locked = default(bool), string publishDelay = default(string), int varVersion = default(int))
        {
            this.VarVersion = varVersion;
            this.Name = name;
            this.Leader = leader;
            this.Members = members;
            this.Website = website;
            this.IrcServer = ircServer;
            this.IrcChannel = ircChannel;
            this.Discord = discord;
            this.ContactEmail = contactEmail;
            this.Description = description;
            this.Twitter = twitter;
            this.MangaUpdates = mangaUpdates;
            this.FocusedLanguages = focusedLanguages;
            this.Inactive = inactive;
            this.Locked = locked;
            this.PublishDelay = publishDelay;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Leader
        /// </summary>
        [DataMember(Name = "leader", EmitDefaultValue = false)]
        [JsonPropertyName("leader")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Guid Leader { get; set; }

        /// <summary>
        /// Gets or Sets Members
        /// </summary>
        [DataMember(Name = "members", EmitDefaultValue = false)]
        [JsonPropertyName("members")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<Guid> Members { get; set; }

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
        /// Gets or Sets FocusedLanguages
        /// </summary>
        [DataMember(Name = "focusedLanguages", EmitDefaultValue = true)]
        [JsonPropertyName("focusedLanguages")]
        public List<string> FocusedLanguages { get; set; }

        /// <summary>
        /// Gets or Sets Inactive
        /// </summary>
        [DataMember(Name = "inactive", EmitDefaultValue = true)]
        [JsonPropertyName("inactive")]
        public bool Inactive { get; set; }

        /// <summary>
        /// Gets or Sets Locked
        /// </summary>
        [DataMember(Name = "locked", EmitDefaultValue = true)]
        [JsonPropertyName("locked")]
        public bool Locked { get; set; }

        /// <summary>
        /// Gets or Sets PublishDelay
        /// </summary>
        [DataMember(Name = "publishDelay", EmitDefaultValue = false)]
        [JsonPropertyName("publishDelay")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string PublishDelay { get; set; }

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
            sb.Append("class ScanlationGroupEdit {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Leader: ").Append(Leader).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  IrcServer: ").Append(IrcServer).Append("\n");
            sb.Append("  IrcChannel: ").Append(IrcChannel).Append("\n");
            sb.Append("  Discord: ").Append(Discord).Append("\n");
            sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Twitter: ").Append(Twitter).Append("\n");
            sb.Append("  MangaUpdates: ").Append(MangaUpdates).Append("\n");
            sb.Append("  FocusedLanguages: ").Append(FocusedLanguages).Append("\n");
            sb.Append("  Inactive: ").Append(Inactive).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  PublishDelay: ").Append(PublishDelay).Append("\n");
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
            return this.Equals(input as ScanlationGroupEdit);
        }

        /// <summary>
        /// Returns true if ScanlationGroupEdit instances are equal
        /// </summary>
        /// <param name="input">Instance of ScanlationGroupEdit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScanlationGroupEdit input)
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
                    this.Leader == input.Leader ||
                    (this.Leader != null &&
                    this.Leader.Equals(input.Leader))
                ) && 
                (
                    this.Members == input.Members ||
                    this.Members != null &&
                    input.Members != null &&
                    this.Members.SequenceEqual(input.Members)
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
                    this.FocusedLanguages == input.FocusedLanguages ||
                    this.FocusedLanguages != null &&
                    input.FocusedLanguages != null &&
                    this.FocusedLanguages.SequenceEqual(input.FocusedLanguages)
                ) && 
                (
                    this.Inactive == input.Inactive ||
                    this.Inactive.Equals(input.Inactive)
                ) && 
                (
                    this.Locked == input.Locked ||
                    this.Locked.Equals(input.Locked)
                ) && 
                (
                    this.PublishDelay == input.PublishDelay ||
                    (this.PublishDelay != null &&
                    this.PublishDelay.Equals(input.PublishDelay))
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
                if (this.Leader != null)
                {
                    hashCode = (hashCode * 59) + this.Leader.GetHashCode();
                }
                if (this.Members != null)
                {
                    hashCode = (hashCode * 59) + this.Members.GetHashCode();
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
                if (this.FocusedLanguages != null)
                {
                    hashCode = (hashCode * 59) + this.FocusedLanguages.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Inactive.GetHashCode();
                hashCode = (hashCode * 59) + this.Locked.GetHashCode();
                if (this.PublishDelay != null)
                {
                    hashCode = (hashCode * 59) + this.PublishDelay.GetHashCode();
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
            if (this.Twitter != null) {
                // Twitter (string) pattern
Regex regexTwitter = new Regex(@"^https?://", RegexOptions.CultureInvariant);
if (!regexTwitter.Match(this.Twitter).Success)
{
    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Twitter, must match a pattern of " + regexTwitter, new [] { "Twitter" });
}
            }

            // MangaUpdates (string) maxLength
            if (this.MangaUpdates != null && this.MangaUpdates.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MangaUpdates, length must be less than 128.", new [] { "MangaUpdates" });
            }

            if (this.MangaUpdates != null) {
                // MangaUpdates (string) pattern
Regex regexMangaUpdates = new Regex(@"^https:\/\/www\.mangaupdates\.com\/(group|publisher)(s\.html\?id=\d+|\/[\w-]+\/?([\w-]+)?(\/)?)$", RegexOptions.CultureInvariant);
if (!regexMangaUpdates.Match(this.MangaUpdates).Success)
{
    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MangaUpdates, must match a pattern of " + regexMangaUpdates, new [] { "MangaUpdates" });
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
