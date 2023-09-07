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
    /// TransferTokenResponse
    /// </summary>
    [DataContract(Name = "TransferTokenResponse")]
    public partial class TransferTokenResponse : IEquatable<TransferTokenResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 1,

            /// <summary>
            /// Enum Success for value: success
            /// </summary>
            [EnumMember(Value = "success")]
            Success = 2
        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Custodial for value: custodial
            /// </summary>
            [EnumMember(Value = "custodial")]
            Custodial = 1,

            /// <summary>
            /// Enum SelfCustodial for value: self-custodial
            /// </summary>
            [EnumMember(Value = "self-custodial")]
            SelfCustodial = 2
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferTokenResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferTokenResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferTokenResponse" /> class.
        /// </summary>
        /// <param name="status">status (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="payloadToSign">payloadToSign.</param>
        /// <param name="transactionHash">transactionHash.</param>
        /// <param name="explorerUrl">explorerUrl.</param>
        public TransferTokenResponse(StatusEnum status = default(StatusEnum), TypeEnum type = default(TypeEnum), string payloadToSign = default(string), string transactionHash = default(string), string explorerUrl = default(string))
        {
            this.Status = status;
            this.Type = type;
            this.PayloadToSign = payloadToSign;
            this.TransactionHash = transactionHash;
            this.ExplorerUrl = explorerUrl;
        }

        /// <summary>
        /// Gets or Sets PayloadToSign
        /// </summary>
        [DataMember(Name = "payloadToSign", EmitDefaultValue = false)]
        public string PayloadToSign { get; set; }

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
            sb.Append("class TransferTokenResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  PayloadToSign: ").Append(PayloadToSign).Append("\n");
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
            return this.Equals(input as TransferTokenResponse);
        }

        /// <summary>
        /// Returns true if TransferTokenResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferTokenResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferTokenResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.PayloadToSign == input.PayloadToSign ||
                    (this.PayloadToSign != null &&
                    this.PayloadToSign.Equals(input.PayloadToSign))
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
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.PayloadToSign != null)
                {
                    hashCode = (hashCode * 59) + this.PayloadToSign.GetHashCode();
                }
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
