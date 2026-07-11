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
using System.Reflection;

namespace MangaDex.Model
{
    /// <summary>
    /// GetChapterUploaderParameter
    /// </summary>
    [JsonConverter(typeof(GetChapterUploaderParameterJsonConverter))]
    [DataContract(Name = "get_chapter_uploader_parameter")]
    public partial class GetChapterUploaderParameter : AbstractOpenAPISchema, IEquatable<GetChapterUploaderParameter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetChapterUploaderParameter" /> class
        /// with the <see cref="Guid" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Guid.</param>
        public GetChapterUploaderParameter(Guid actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChapterUploaderParameter" /> class
        /// with the <see cref="List{Guid}" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of List&lt;Guid&gt;.</param>
        public GetChapterUploaderParameter(List<Guid> actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(Guid))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(List<Guid>))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Guid, List<Guid>");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Guid`. If the actual instance is not `Guid`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Guid</returns>
        public Guid GetGuid()
        {
            return (Guid)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `List&lt;Guid&gt;`. If the actual instance is not `List&lt;Guid&gt;`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of List&lt;Guid&gt;</returns>
        public List<Guid> GetListUuid()
        {
            return (List<Guid>)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetChapterUploaderParameter {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonSerializer.Serialize(this.ActualInstance, this.ActualInstance.GetType(), GetChapterUploaderParameter.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of GetChapterUploaderParameter
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of GetChapterUploaderParameter</returns>
        public static GetChapterUploaderParameter FromJson(string jsonString)
        {
            GetChapterUploaderParameter newGetChapterUploaderParameter = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newGetChapterUploaderParameter;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Guid).GetProperty("AdditionalProperties") == null)
                {
                    newGetChapterUploaderParameter = new GetChapterUploaderParameter(JsonSerializer.Deserialize<Guid>(jsonString, GetChapterUploaderParameter.SerializerSettings));
                }
                else
                {
                    newGetChapterUploaderParameter = new GetChapterUploaderParameter(JsonSerializer.Deserialize<Guid>(jsonString, GetChapterUploaderParameter.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Guid");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Guid: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(List<Guid>).GetProperty("AdditionalProperties") == null)
                {
                    newGetChapterUploaderParameter = new GetChapterUploaderParameter(JsonSerializer.Deserialize<List<Guid>>(jsonString, GetChapterUploaderParameter.SerializerSettings));
                }
                else
                {
                    newGetChapterUploaderParameter = new GetChapterUploaderParameter(JsonSerializer.Deserialize<List<Guid>>(jsonString, GetChapterUploaderParameter.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("List<Guid>");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into List<Guid>: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newGetChapterUploaderParameter;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetChapterUploaderParameter);
        }

        /// <summary>
        /// Returns true if GetChapterUploaderParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of GetChapterUploaderParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetChapterUploaderParameter input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for GetChapterUploaderParameter
    /// </summary>
    public class GetChapterUploaderParameterJsonConverter : JsonConverter<GetChapterUploaderParameter>
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="options">Serializer options</param>
        
        public override void Write(Utf8JsonWriter writer, GetChapterUploaderParameter value, JsonSerializerOptions options)
        {
            writer.WriteRawValue(value.ToJson());
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="typeToConvert">Type to convert (Read) — unused</param>
        /// <param name="options">Serializer options</param>
        /// <returns>The object converted from the JSON string</returns>
        
        public override GetChapterUploaderParameter Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.Null)
            {
                using (var doc = JsonDocument.ParseValue(ref reader))
                {
                    return GetChapterUploaderParameter.FromJson(doc.RootElement.GetRawText());
                }
            }
            return null;
        }
    }

}
