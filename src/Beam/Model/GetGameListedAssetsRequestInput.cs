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
using FileParameter = Beam.Client.FileParameter;
using OpenAPIDateConverter = Beam.Client.OpenAPIDateConverter;

namespace Beam.Model
{
    /// <summary>
    /// GetGameListedAssetsRequestInput
    /// </summary>
    [DataContract(Name = "GetGameListedAssetsRequestInput")]
    public partial class GetGameListedAssetsRequestInput : IEquatable<GetGameListedAssetsRequestInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetGameListedAssetsRequestInput" /> class.
        /// </summary>
        /// <param name="contracts">contracts.</param>
        public GetGameListedAssetsRequestInput(List<string> contracts = default(List<string>))
        {
            this.Contracts = contracts;
        }

        /// <summary>
        /// Gets or Sets Contracts
        /// </summary>
        [DataMember(Name = "contracts", EmitDefaultValue = false)]
        public List<string> Contracts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetGameListedAssetsRequestInput {\n");
            sb.Append("  Contracts: ").Append(Contracts).Append("\n");
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
            return this.Equals(input as GetGameListedAssetsRequestInput);
        }

        /// <summary>
        /// Returns true if GetGameListedAssetsRequestInput instances are equal
        /// </summary>
        /// <param name="input">Instance of GetGameListedAssetsRequestInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetGameListedAssetsRequestInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Contracts == input.Contracts ||
                    this.Contracts != null &&
                    input.Contracts != null &&
                    this.Contracts.SequenceEqual(input.Contracts)
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
                if (this.Contracts != null)
                {
                    hashCode = (hashCode * 59) + this.Contracts.GetHashCode();
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