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
    /// BuyAssetResponse
    /// </summary>
    [DataContract(Name = "BuyAssetResponse")]
    public partial class BuyAssetResponse : IEquatable<BuyAssetResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuyAssetResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuyAssetResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuyAssetResponse" /> class.
        /// </summary>
        /// <param name="success">success (required).</param>
        /// <param name="transactionHash">transactionHash.</param>
        /// <param name="explorerUrl">explorerUrl.</param>
        public BuyAssetResponse(bool success = default(bool), string transactionHash = default(string), string explorerUrl = default(string))
        {
            this.Success = success;
            this.TransactionHash = transactionHash;
            this.ExplorerUrl = explorerUrl;
        }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name = "success", IsRequired = true, EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets TransactionHash
        /// </summary>
        [DataMember(Name = "transactionHash", EmitDefaultValue = false)]
        public string TransactionHash { get; set; }

        /// <summary>
        /// Gets or Sets ExplorerUrl
        /// </summary>
        [DataMember(Name = "explorerUrl", EmitDefaultValue = false)]
        public string ExplorerUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BuyAssetResponse {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  TransactionHash: ").Append(TransactionHash).Append("\n");
            sb.Append("  ExplorerUrl: ").Append(ExplorerUrl).Append("\n");
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
            return this.Equals(input as BuyAssetResponse);
        }

        /// <summary>
        /// Returns true if BuyAssetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BuyAssetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuyAssetResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Success == input.Success ||
                    this.Success.Equals(input.Success)
                ) && 
                (
                    this.TransactionHash == input.TransactionHash ||
                    (this.TransactionHash != null &&
                    this.TransactionHash.Equals(input.TransactionHash))
                ) && 
                (
                    this.ExplorerUrl == input.ExplorerUrl ||
                    (this.ExplorerUrl != null &&
                    this.ExplorerUrl.Equals(input.ExplorerUrl))
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
                hashCode = (hashCode * 59) + this.Success.GetHashCode();
                if (this.TransactionHash != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionHash.GetHashCode();
                }
                if (this.ExplorerUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ExplorerUrl.GetHashCode();
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
