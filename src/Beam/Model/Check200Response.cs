/*
 * Beam game development API
 *
 * The Beam game development API is a service to integrate your game with Beam
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Beam.Client.OpenAPIDateConverter;

namespace Beam.Model
{
    /// <summary>
    /// Check200Response
    /// </summary>
    [DataContract(Name = "check_200_response")]
    public partial class Check200Response : IEquatable<Check200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Check200Response" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="info">info.</param>
        /// <param name="error">error.</param>
        /// <param name="details">details.</param>
        public Check200Response(string status = default(string), Dictionary<string, Check200ResponseInfoValue> info = default(Dictionary<string, Check200ResponseInfoValue>), Dictionary<string, Check200ResponseInfoValue> error = default(Dictionary<string, Check200ResponseInfoValue>), Dictionary<string, Check200ResponseInfoValue> details = default(Dictionary<string, Check200ResponseInfoValue>))
        {
            this.Status = status;
            this.Info = info;
            this.Error = error;
            this.Details = details;
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        /// <example>ok</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        /// <example>{&quot;database&quot;:{&quot;status&quot;:&quot;up&quot;}}</example>
        [DataMember(Name = "info", EmitDefaultValue = true)]
        public Dictionary<string, Check200ResponseInfoValue> Info { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        /// <example>{}</example>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public Dictionary<string, Check200ResponseInfoValue> Error { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        /// <example>{&quot;database&quot;:{&quot;status&quot;:&quot;up&quot;}}</example>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public Dictionary<string, Check200ResponseInfoValue> Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Check200Response {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Check200Response);
        }

        /// <summary>
        /// Returns true if Check200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of Check200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Check200Response input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Info == input.Info ||
                    this.Info != null &&
                    input.Info != null &&
                    this.Info.SequenceEqual(input.Info)
                ) && 
                (
                    this.Error == input.Error ||
                    this.Error != null &&
                    input.Error != null &&
                    this.Error.SequenceEqual(input.Error)
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    input.Details != null &&
                    this.Details.SequenceEqual(input.Details)
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
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Info != null)
                {
                    hashCode = (hashCode * 59) + this.Info.GetHashCode();
                }
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
                }
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
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
