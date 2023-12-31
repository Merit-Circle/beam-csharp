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
    /// GetChainResponse
    /// </summary>
    [DataContract(Name = "GetChainResponse")]
    public partial class GetChainResponse : IEquatable<GetChainResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetChainResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetChainResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetChainResponse" /> class.
        /// </summary>
        /// <param name="chainId">chainId (required).</param>
        /// <param name="blockNumber">blockNumber (required).</param>
        /// <param name="nativeCurrency">nativeCurrency (required).</param>
        public GetChainResponse(decimal chainId = default(decimal), decimal blockNumber = default(decimal), GetChainResponseNativeCurrency nativeCurrency = default(GetChainResponseNativeCurrency))
        {
            this.ChainId = chainId;
            this.BlockNumber = blockNumber;
            // to ensure "nativeCurrency" is required (not null)
            if (nativeCurrency == null)
            {
                throw new ArgumentNullException("nativeCurrency is a required property for GetChainResponse and cannot be null");
            }
            this.NativeCurrency = nativeCurrency;
        }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [DataMember(Name = "chainId", IsRequired = true, EmitDefaultValue = true)]
        public decimal ChainId { get; set; }

        /// <summary>
        /// Gets or Sets BlockNumber
        /// </summary>
        [DataMember(Name = "blockNumber", IsRequired = true, EmitDefaultValue = true)]
        public decimal BlockNumber { get; set; }

        /// <summary>
        /// Gets or Sets NativeCurrency
        /// </summary>
        [DataMember(Name = "nativeCurrency", IsRequired = true, EmitDefaultValue = true)]
        public GetChainResponseNativeCurrency NativeCurrency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetChainResponse {\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  BlockNumber: ").Append(BlockNumber).Append("\n");
            sb.Append("  NativeCurrency: ").Append(NativeCurrency).Append("\n");
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
            return this.Equals(input as GetChainResponse);
        }

        /// <summary>
        /// Returns true if GetChainResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetChainResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetChainResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
                ) && 
                (
                    this.BlockNumber == input.BlockNumber ||
                    this.BlockNumber.Equals(input.BlockNumber)
                ) && 
                (
                    this.NativeCurrency == input.NativeCurrency ||
                    (this.NativeCurrency != null &&
                    this.NativeCurrency.Equals(input.NativeCurrency))
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
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                hashCode = (hashCode * 59) + this.BlockNumber.GetHashCode();
                if (this.NativeCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.NativeCurrency.GetHashCode();
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
