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
    /// GetStatisticsMangaUuid200ResponseStatisticsValueRatingDistribution
    /// </summary>
    [DataContract(Name = "get_statistics_manga_uuid_200_response_statistics_value_rating_distribution")]
    public partial class GetStatisticsMangaUuid200ResponseStatisticsValueRatingDistribution : IEquatable<GetStatisticsMangaUuid200ResponseStatisticsValueRatingDistribution>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatisticsMangaUuid200ResponseStatisticsValueRatingDistribution" /> class.
        /// </summary>
        /// <param name="var1">var1.</param>
        /// <param name="var2">var2.</param>
        /// <param name="var3">var3.</param>
        /// <param name="var4">var4.</param>
        /// <param name="var5">var5.</param>
        /// <param name="var6">var6.</param>
        /// <param name="var7">var7.</param>
        /// <param name="var8">var8.</param>
        /// <param name="var9">var9.</param>
        /// <param name="var10">var10.</param>
        public GetStatisticsMangaUuid200ResponseStatisticsValueRatingDistribution(int var1 = default(int), int var2 = default(int), int var3 = default(int), int var4 = default(int), int var5 = default(int), int var6 = default(int), int var7 = default(int), int var8 = default(int), int var9 = default(int), int var10 = default(int))
        {
            this.Var1 = var1;
            this.Var2 = var2;
            this.Var3 = var3;
            this.Var4 = var4;
            this.Var5 = var5;
            this.Var6 = var6;
            this.Var7 = var7;
            this.Var8 = var8;
            this.Var9 = var9;
            this.Var10 = var10;
        }

        /// <summary>
        /// Gets or Sets Var1
        /// </summary>
        [DataMember(Name = "1", EmitDefaultValue = false)]
        [JsonPropertyName("1")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Var1 { get; set; }

        /// <summary>
        /// Gets or Sets Var2
        /// </summary>
        [DataMember(Name = "2", EmitDefaultValue = false)]
        [JsonPropertyName("2")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Var2 { get; set; }

        /// <summary>
        /// Gets or Sets Var3
        /// </summary>
        [DataMember(Name = "3", EmitDefaultValue = false)]
        [JsonPropertyName("3")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Var3 { get; set; }

        /// <summary>
        /// Gets or Sets Var4
        /// </summary>
        [DataMember(Name = "4", EmitDefaultValue = false)]
        [JsonPropertyName("4")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Var4 { get; set; }

        /// <summary>
        /// Gets or Sets Var5
        /// </summary>
        [DataMember(Name = "5", EmitDefaultValue = false)]
        [JsonPropertyName("5")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Var5 { get; set; }

        /// <summary>
        /// Gets or Sets Var6
        /// </summary>
        [DataMember(Name = "6", EmitDefaultValue = false)]
        [JsonPropertyName("6")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Var6 { get; set; }

        /// <summary>
        /// Gets or Sets Var7
        /// </summary>
        [DataMember(Name = "7", EmitDefaultValue = false)]
        [JsonPropertyName("7")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Var7 { get; set; }

        /// <summary>
        /// Gets or Sets Var8
        /// </summary>
        [DataMember(Name = "8", EmitDefaultValue = false)]
        [JsonPropertyName("8")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Var8 { get; set; }

        /// <summary>
        /// Gets or Sets Var9
        /// </summary>
        [DataMember(Name = "9", EmitDefaultValue = false)]
        [JsonPropertyName("9")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Var9 { get; set; }

        /// <summary>
        /// Gets or Sets Var10
        /// </summary>
        [DataMember(Name = "10", EmitDefaultValue = false)]
        [JsonPropertyName("10")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Var10 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetStatisticsMangaUuid200ResponseStatisticsValueRatingDistribution {\n");
            sb.Append("  Var1: ").Append(Var1).Append("\n");
            sb.Append("  Var2: ").Append(Var2).Append("\n");
            sb.Append("  Var3: ").Append(Var3).Append("\n");
            sb.Append("  Var4: ").Append(Var4).Append("\n");
            sb.Append("  Var5: ").Append(Var5).Append("\n");
            sb.Append("  Var6: ").Append(Var6).Append("\n");
            sb.Append("  Var7: ").Append(Var7).Append("\n");
            sb.Append("  Var8: ").Append(Var8).Append("\n");
            sb.Append("  Var9: ").Append(Var9).Append("\n");
            sb.Append("  Var10: ").Append(Var10).Append("\n");
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
            return this.Equals(input as GetStatisticsMangaUuid200ResponseStatisticsValueRatingDistribution);
        }

        /// <summary>
        /// Returns true if GetStatisticsMangaUuid200ResponseStatisticsValueRatingDistribution instances are equal
        /// </summary>
        /// <param name="input">Instance of GetStatisticsMangaUuid200ResponseStatisticsValueRatingDistribution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetStatisticsMangaUuid200ResponseStatisticsValueRatingDistribution input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Var1 == input.Var1 ||
                    this.Var1.Equals(input.Var1)
                ) &&
                (
                    this.Var2 == input.Var2 ||
                    this.Var2.Equals(input.Var2)
                ) &&
                (
                    this.Var3 == input.Var3 ||
                    this.Var3.Equals(input.Var3)
                ) &&
                (
                    this.Var4 == input.Var4 ||
                    this.Var4.Equals(input.Var4)
                ) &&
                (
                    this.Var5 == input.Var5 ||
                    this.Var5.Equals(input.Var5)
                ) &&
                (
                    this.Var6 == input.Var6 ||
                    this.Var6.Equals(input.Var6)
                ) &&
                (
                    this.Var7 == input.Var7 ||
                    this.Var7.Equals(input.Var7)
                ) &&
                (
                    this.Var8 == input.Var8 ||
                    this.Var8.Equals(input.Var8)
                ) &&
                (
                    this.Var9 == input.Var9 ||
                    this.Var9.Equals(input.Var9)
                ) &&
                (
                    this.Var10 == input.Var10 ||
                    this.Var10.Equals(input.Var10)
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
                hashCode = (hashCode * 59) + this.Var1.GetHashCode();
                hashCode = (hashCode * 59) + this.Var2.GetHashCode();
                hashCode = (hashCode * 59) + this.Var3.GetHashCode();
                hashCode = (hashCode * 59) + this.Var4.GetHashCode();
                hashCode = (hashCode * 59) + this.Var5.GetHashCode();
                hashCode = (hashCode * 59) + this.Var6.GetHashCode();
                hashCode = (hashCode * 59) + this.Var7.GetHashCode();
                hashCode = (hashCode * 59) + this.Var8.GetHashCode();
                hashCode = (hashCode * 59) + this.Var9.GetHashCode();
                hashCode = (hashCode * 59) + this.Var10.GetHashCode();
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