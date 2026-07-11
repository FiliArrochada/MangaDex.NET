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
    /// MangaRelationRequest
    /// </summary>
    [DataContract(Name = "MangaRelationRequest")]
    public partial class MangaRelationRequest : IEquatable<MangaRelationRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines Relation
        /// </summary>
        [JsonConverter(typeof(MangaDex.Client.StringEnumMemberConverter))]
        public enum RelationEnum
        {
            /// <summary>
            /// Enum Monochrome for value: monochrome
            /// </summary>
            [EnumMember(Value = "monochrome")]
            Monochrome = 1,

            /// <summary>
            /// Enum MainStory for value: main_story
            /// </summary>
            [EnumMember(Value = "main_story")]
            MainStory = 2,

            /// <summary>
            /// Enum AdaptedFrom for value: adapted_from
            /// </summary>
            [EnumMember(Value = "adapted_from")]
            AdaptedFrom = 3,

            /// <summary>
            /// Enum BasedOn for value: based_on
            /// </summary>
            [EnumMember(Value = "based_on")]
            BasedOn = 4,

            /// <summary>
            /// Enum Prequel for value: prequel
            /// </summary>
            [EnumMember(Value = "prequel")]
            Prequel = 5,

            /// <summary>
            /// Enum SideStory for value: side_story
            /// </summary>
            [EnumMember(Value = "side_story")]
            SideStory = 6,

            /// <summary>
            /// Enum Doujinshi for value: doujinshi
            /// </summary>
            [EnumMember(Value = "doujinshi")]
            Doujinshi = 7,

            /// <summary>
            /// Enum SameFranchise for value: same_franchise
            /// </summary>
            [EnumMember(Value = "same_franchise")]
            SameFranchise = 8,

            /// <summary>
            /// Enum SharedUniverse for value: shared_universe
            /// </summary>
            [EnumMember(Value = "shared_universe")]
            SharedUniverse = 9,

            /// <summary>
            /// Enum Sequel for value: sequel
            /// </summary>
            [EnumMember(Value = "sequel")]
            Sequel = 10,

            /// <summary>
            /// Enum SpinOff for value: spin_off
            /// </summary>
            [EnumMember(Value = "spin_off")]
            SpinOff = 11,

            /// <summary>
            /// Enum AlternateStory for value: alternate_story
            /// </summary>
            [EnumMember(Value = "alternate_story")]
            AlternateStory = 12,

            /// <summary>
            /// Enum AlternateVersion for value: alternate_version
            /// </summary>
            [EnumMember(Value = "alternate_version")]
            AlternateVersion = 13,

            /// <summary>
            /// Enum Preserialization for value: preserialization
            /// </summary>
            [EnumMember(Value = "preserialization")]
            Preserialization = 14,

            /// <summary>
            /// Enum Colored for value: colored
            /// </summary>
            [EnumMember(Value = "colored")]
            Colored = 15,

            /// <summary>
            /// Enum Serialization for value: serialization
            /// </summary>
            [EnumMember(Value = "serialization")]
            Serialization = 16
        }

        /// <summary>
        /// Gets or Sets Relation
        /// </summary>
        [DataMember(Name = "relation", EmitDefaultValue = false)]
        [JsonPropertyName("relation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public RelationEnum? Relation { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MangaRelationRequest" /> class.
        /// </summary>
        /// <param name="targetManga">targetManga.</param>
        /// <param name="relation">relation.</param>
        public MangaRelationRequest(Guid targetManga = default(Guid), RelationEnum? relation = default(RelationEnum?))
        {
            this.TargetManga = targetManga;
            this.Relation = relation;
        }

        /// <summary>
        /// Gets or Sets TargetManga
        /// </summary>
        [DataMember(Name = "targetManga", EmitDefaultValue = false)]
        [JsonPropertyName("targetManga")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Guid TargetManga { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MangaRelationRequest {\n");
            sb.Append("  TargetManga: ").Append(TargetManga).Append("\n");
            sb.Append("  Relation: ").Append(Relation).Append("\n");
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
            return this.Equals(input as MangaRelationRequest);
        }

        /// <summary>
        /// Returns true if MangaRelationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MangaRelationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MangaRelationRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.TargetManga == input.TargetManga ||
                    (this.TargetManga != null &&
                    this.TargetManga.Equals(input.TargetManga))
                ) &&
                (
                    this.Relation == input.Relation ||
                    this.Relation.Equals(input.Relation)
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
                if (this.TargetManga != null)
                {
                    hashCode = (hashCode * 59) + this.TargetManga.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Relation.GetHashCode();
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