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
    /// UploadSessionFileAttributes
    /// </summary>
    [DataContract(Name = "UploadSessionFileAttributes")]
    public partial class UploadSessionFileAttributes : IEquatable<UploadSessionFileAttributes>, IValidatableObject
    {
        /// <summary>
        /// Defines Source
        /// </summary>
        [JsonConverter(typeof(MangaDex.Client.StringEnumMemberConverter))]
        public enum SourceEnum
        {
            /// <summary>
            /// Enum Local for value: local
            /// </summary>
            [EnumMember(Value = "local")]
            Local = 1,

            /// <summary>
            /// Enum Remote for value: remote
            /// </summary>
            [EnumMember(Value = "remote")]
            Remote = 2
        }


        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        [JsonPropertyName("source")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public SourceEnum? Source { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadSessionFileAttributes" /> class.
        /// </summary>
        /// <param name="originalFileName">originalFileName.</param>
        /// <param name="fileHash">fileHash.</param>
        /// <param name="fileSize">fileSize.</param>
        /// <param name="mimeType">mimeType.</param>
        /// <param name="source">source.</param>
        /// <param name="varVersion">varVersion.</param>
        public UploadSessionFileAttributes(string originalFileName = default(string), string fileHash = default(string), decimal fileSize = default(decimal), string mimeType = default(string), SourceEnum? source = default(SourceEnum?), int varVersion = default(int))
        {
            this.OriginalFileName = originalFileName;
            this.FileHash = fileHash;
            this.FileSize = fileSize;
            this.MimeType = mimeType;
            this.Source = source;
            this.VarVersion = varVersion;
        }

        /// <summary>
        /// Gets or Sets OriginalFileName
        /// </summary>
        [DataMember(Name = "originalFileName", EmitDefaultValue = false)]
        [JsonPropertyName("originalFileName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string OriginalFileName { get; set; }

        /// <summary>
        /// Gets or Sets FileHash
        /// </summary>
        [DataMember(Name = "fileHash", EmitDefaultValue = false)]
        [JsonPropertyName("fileHash")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string FileHash { get; set; }

        /// <summary>
        /// Gets or Sets FileSize
        /// </summary>
        [DataMember(Name = "fileSize", EmitDefaultValue = false)]
        [JsonPropertyName("fileSize")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public decimal FileSize { get; set; }

        /// <summary>
        /// Gets or Sets MimeType
        /// </summary>
        [DataMember(Name = "mimeType", EmitDefaultValue = false)]
        [JsonPropertyName("mimeType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string MimeType { get; set; }

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
            sb.Append("class UploadSessionFileAttributes {\n");
            sb.Append("  OriginalFileName: ").Append(OriginalFileName).Append("\n");
            sb.Append("  FileHash: ").Append(FileHash).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(input as UploadSessionFileAttributes);
        }

        /// <summary>
        /// Returns true if UploadSessionFileAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of UploadSessionFileAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadSessionFileAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OriginalFileName == input.OriginalFileName ||
                    (this.OriginalFileName != null &&
                    this.OriginalFileName.Equals(input.OriginalFileName))
                ) && 
                (
                    this.FileHash == input.FileHash ||
                    (this.FileHash != null &&
                    this.FileHash.Equals(input.FileHash))
                ) && 
                (
                    this.FileSize == input.FileSize ||
                    this.FileSize.Equals(input.FileSize)
                ) && 
                (
                    this.MimeType == input.MimeType ||
                    (this.MimeType != null &&
                    this.MimeType.Equals(input.MimeType))
                ) && 
                (
                    this.Source == input.Source ||
                    this.Source.Equals(input.Source)
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
                if (this.OriginalFileName != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalFileName.GetHashCode();
                }
                if (this.FileHash != null)
                {
                    hashCode = (hashCode * 59) + this.FileHash.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FileSize.GetHashCode();
                if (this.MimeType != null)
                {
                    hashCode = (hashCode * 59) + this.MimeType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Source.GetHashCode();
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
            // VarVersion (int) minimum
            if (this.VarVersion < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VarVersion, must be a value greater than or equal to 1.", new [] { "VarVersion" });
            }

            yield break;
        }
    }

}
