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
    /// CreatePlayerRequestInput
    /// </summary>
    [DataContract(Name = "CreatePlayerRequestInput")]
    public partial class CreatePlayerRequestInput : IEquatable<CreatePlayerRequestInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePlayerRequestInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreatePlayerRequestInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePlayerRequestInput" /> class.
        /// </summary>
        /// <param name="identifier">identifier (required).</param>
        public CreatePlayerRequestInput(string identifier = default(string))
        {
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier is a required property for CreatePlayerRequestInput and cannot be null");
            }
            this.Identifier = identifier;
        }

        /// <summary>
        /// Gets or Sets Identifier
        /// </summary>
        [DataMember(Name = "identifier", IsRequired = true, EmitDefaultValue = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreatePlayerRequestInput {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
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
            return this.Equals(input as CreatePlayerRequestInput);
        }

        /// <summary>
        /// Returns true if CreatePlayerRequestInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePlayerRequestInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePlayerRequestInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
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
                if (this.Identifier != null)
                {
                    hashCode = (hashCode * 59) + this.Identifier.GetHashCode();
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
