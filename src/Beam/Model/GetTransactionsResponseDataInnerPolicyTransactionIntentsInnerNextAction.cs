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
    /// GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerNextAction
    /// </summary>
    [DataContract(Name = "GetTransactionsResponse_data_inner_policy_transactionIntents_inner_nextAction")]
    public partial class GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerNextAction : IEquatable<GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerNextAction>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum SignWithWallet for value: sign_with_wallet
            /// </summary>
            [EnumMember(Value = "sign_with_wallet")]
            SignWithWallet = 1
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerNextAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerNextAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerNextAction" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="payload">payload (required).</param>
        public GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerNextAction(TypeEnum type = default(TypeEnum), GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerNextActionPayload payload = default(GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerNextActionPayload))
        {
            this.Type = type;
            // to ensure "payload" is required (not null)
            if (payload == null)
            {
                throw new ArgumentNullException("payload is a required property for GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerNextAction and cannot be null");
            }
            this.Payload = payload;
        }

        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name = "payload", IsRequired = true, EmitDefaultValue = true)]
        public GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerNextActionPayload Payload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerNextAction {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
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
            return this.Equals(input as GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerNextAction);
        }

        /// <summary>
        /// Returns true if GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerNextAction instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerNextAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerNextAction input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Payload != null)
                {
                    hashCode = (hashCode * 59) + this.Payload.GetHashCode();
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