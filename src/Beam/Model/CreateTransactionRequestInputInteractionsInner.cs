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
    /// CreateTransactionRequestInputInteractionsInner
    /// </summary>
    [DataContract(Name = "CreateTransactionRequestInput_interactions_inner")]
    public partial class CreateTransactionRequestInputInteractionsInner : IEquatable<CreateTransactionRequestInputInteractionsInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransactionRequestInputInteractionsInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTransactionRequestInputInteractionsInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransactionRequestInputInteractionsInner" /> class.
        /// </summary>
        /// <param name="contract">contract (required).</param>
        /// <param name="functionName">functionName (required).</param>
        /// <param name="functionArgs">functionArgs (required).</param>
        public CreateTransactionRequestInputInteractionsInner(string contract = default(string), string functionName = default(string), List<Object> functionArgs = default(List<Object>))
        {
            // to ensure "contract" is required (not null)
            if (contract == null)
            {
                throw new ArgumentNullException("contract is a required property for CreateTransactionRequestInputInteractionsInner and cannot be null");
            }
            this.Contract = contract;
            // to ensure "functionName" is required (not null)
            if (functionName == null)
            {
                throw new ArgumentNullException("functionName is a required property for CreateTransactionRequestInputInteractionsInner and cannot be null");
            }
            this.FunctionName = functionName;
            // to ensure "functionArgs" is required (not null)
            if (functionArgs == null)
            {
                throw new ArgumentNullException("functionArgs is a required property for CreateTransactionRequestInputInteractionsInner and cannot be null");
            }
            this.FunctionArgs = functionArgs;
        }

        /// <summary>
        /// Gets or Sets Contract
        /// </summary>
        [DataMember(Name = "contract", IsRequired = true, EmitDefaultValue = true)]
        public string Contract { get; set; }

        /// <summary>
        /// Gets or Sets FunctionName
        /// </summary>
        [DataMember(Name = "functionName", IsRequired = true, EmitDefaultValue = true)]
        public string FunctionName { get; set; }

        /// <summary>
        /// Gets or Sets FunctionArgs
        /// </summary>
        [DataMember(Name = "functionArgs", IsRequired = true, EmitDefaultValue = true)]
        public List<Object> FunctionArgs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateTransactionRequestInputInteractionsInner {\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  FunctionName: ").Append(FunctionName).Append("\n");
            sb.Append("  FunctionArgs: ").Append(FunctionArgs).Append("\n");
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
            return this.Equals(input as CreateTransactionRequestInputInteractionsInner);
        }

        /// <summary>
        /// Returns true if CreateTransactionRequestInputInteractionsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTransactionRequestInputInteractionsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTransactionRequestInputInteractionsInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.FunctionName == input.FunctionName ||
                    (this.FunctionName != null &&
                    this.FunctionName.Equals(input.FunctionName))
                ) && 
                (
                    this.FunctionArgs == input.FunctionArgs ||
                    this.FunctionArgs != null &&
                    input.FunctionArgs != null &&
                    this.FunctionArgs.SequenceEqual(input.FunctionArgs)
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
                if (this.Contract != null)
                {
                    hashCode = (hashCode * 59) + this.Contract.GetHashCode();
                }
                if (this.FunctionName != null)
                {
                    hashCode = (hashCode * 59) + this.FunctionName.GetHashCode();
                }
                if (this.FunctionArgs != null)
                {
                    hashCode = (hashCode * 59) + this.FunctionArgs.GetHashCode();
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
