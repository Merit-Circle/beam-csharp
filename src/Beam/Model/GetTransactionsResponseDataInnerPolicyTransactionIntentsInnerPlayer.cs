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
    /// GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerPlayer
    /// </summary>
    [DataContract(Name = "GetTransactionsResponse_data_inner_policy_transactionIntents_inner_player")]
    public partial class GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerPlayer : IEquatable<GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerPlayer>, IValidatableObject
    {
        /// <summary>
        /// Defines VarObject
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum Player for value: player
            /// </summary>
            [EnumMember(Value = "player")]
            Player = 1
        }


        /// <summary>
        /// Gets or Sets VarObject
        /// </summary>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public ObjectEnum VarObject { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerPlayer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerPlayer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerPlayer" /> class.
        /// </summary>
        /// <param name="transactionIntents">transactionIntents.</param>
        /// <param name="accounts">accounts.</param>
        /// <param name="id">id (required).</param>
        /// <param name="varObject">varObject (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="metadata">metadata (required).</param>
        public GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerPlayer(List<Object> transactionIntents = default(List<Object>), List<GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerPlayerAccountsInner> accounts = default(List<GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerPlayerAccountsInner>), string id = default(string), ObjectEnum varObject = default(ObjectEnum), decimal createdAt = default(decimal), string name = default(string), string description = default(string), string metadata = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerPlayer and cannot be null");
            }
            this.Id = id;
            this.VarObject = varObject;
            this.CreatedAt = createdAt;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerPlayer and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerPlayer and cannot be null");
            }
            this.Description = description;
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new ArgumentNullException("metadata is a required property for GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerPlayer and cannot be null");
            }
            this.Metadata = metadata;
            this.TransactionIntents = transactionIntents;
            this.Accounts = accounts;
        }

        /// <summary>
        /// Gets or Sets TransactionIntents
        /// </summary>
        [DataMember(Name = "transactionIntents", EmitDefaultValue = false)]
        public List<Object> TransactionIntents { get; set; }

        /// <summary>
        /// Gets or Sets Accounts
        /// </summary>
        [DataMember(Name = "accounts", EmitDefaultValue = false)]
        public List<GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerPlayerAccountsInner> Accounts { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public decimal CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", IsRequired = true, EmitDefaultValue = true)]
        public string Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerPlayer {\n");
            sb.Append("  TransactionIntents: ").Append(TransactionIntents).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VarObject: ").Append(VarObject).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerPlayer);
        }

        /// <summary>
        /// Returns true if GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerPlayer instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerPlayer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTransactionsResponseDataInnerPolicyTransactionIntentsInnerPlayer input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransactionIntents == input.TransactionIntents ||
                    this.TransactionIntents != null &&
                    input.TransactionIntents != null &&
                    this.TransactionIntents.SequenceEqual(input.TransactionIntents)
                ) && 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.VarObject == input.VarObject ||
                    this.VarObject.Equals(input.VarObject)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
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
                if (this.TransactionIntents != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionIntents.GetHashCode();
                }
                if (this.Accounts != null)
                {
                    hashCode = (hashCode * 59) + this.Accounts.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VarObject.GetHashCode();
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
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
