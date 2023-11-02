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
    /// AddPolicyRequestInput
    /// </summary>
    [DataContract(Name = "AddPolicyRequestInput")]
    public partial class AddPolicyRequestInput : IEquatable<AddPolicyRequestInput>, IValidatableObject
    {
        /// <summary>
        /// Defines RateType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RateTypeEnum
        {
            /// <summary>
            /// Enum Fixed for value: Fixed
            /// </summary>
            [EnumMember(Value = "Fixed")]
            Fixed = 1,

            /// <summary>
            /// Enum Dynamic for value: Dynamic
            /// </summary>
            [EnumMember(Value = "Dynamic")]
            Dynamic = 2
        }


        /// <summary>
        /// Gets or Sets RateType
        /// </summary>
        [DataMember(Name = "rateType", IsRequired = true, EmitDefaultValue = true)]
        public RateTypeEnum RateType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddPolicyRequestInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddPolicyRequestInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddPolicyRequestInput" /> class.
        /// </summary>
        /// <param name="tokenAddress">tokenAddress (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="rateType">rateType (required).</param>
        /// <param name="chainId">chainId (default to 13337M).</param>
        public AddPolicyRequestInput(string tokenAddress = default(string), decimal amount = default(decimal), RateTypeEnum rateType = default(RateTypeEnum), decimal chainId = 13337M)
        {
            // to ensure "tokenAddress" is required (not null)
            if (tokenAddress == null)
            {
                throw new ArgumentNullException("tokenAddress is a required property for AddPolicyRequestInput and cannot be null");
            }
            this.TokenAddress = tokenAddress;
            this.Amount = amount;
            this.RateType = rateType;
            this.ChainId = chainId;
        }

        /// <summary>
        /// Gets or Sets TokenAddress
        /// </summary>
        [DataMember(Name = "tokenAddress", IsRequired = true, EmitDefaultValue = true)]
        public string TokenAddress { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [DataMember(Name = "chainId", EmitDefaultValue = false)]
        public decimal ChainId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddPolicyRequestInput {\n");
            sb.Append("  TokenAddress: ").Append(TokenAddress).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  RateType: ").Append(RateType).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
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
            return this.Equals(input as AddPolicyRequestInput);
        }

        /// <summary>
        /// Returns true if AddPolicyRequestInput instances are equal
        /// </summary>
        /// <param name="input">Instance of AddPolicyRequestInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddPolicyRequestInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TokenAddress == input.TokenAddress ||
                    (this.TokenAddress != null &&
                    this.TokenAddress.Equals(input.TokenAddress))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.RateType == input.RateType ||
                    this.RateType.Equals(input.RateType)
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
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
                if (this.TokenAddress != null)
                {
                    hashCode = (hashCode * 59) + this.TokenAddress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                hashCode = (hashCode * 59) + this.RateType.GetHashCode();
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
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
            // Amount (decimal) minimum
            if (this.Amount < (decimal)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must be a value greater than or equal to 1.", new [] { "Amount" });
            }

            yield break;
        }
    }

}