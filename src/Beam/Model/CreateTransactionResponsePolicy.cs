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
    /// CreateTransactionResponsePolicy
    /// </summary>
    [DataContract(Name = "CreateTransactionResponse_policy")]
    public partial class CreateTransactionResponsePolicy : IEquatable<CreateTransactionResponsePolicy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransactionResponsePolicy" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTransactionResponsePolicy() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransactionResponsePolicy" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="varObject">varObject (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="deleted">deleted (required).</param>
        /// <param name="chainId">chainId (required).</param>
        /// <param name="strategy">strategy (required).</param>
        /// <param name="transactionIntents">transactionIntents.</param>
        /// <param name="policyRules">policyRules.</param>
        public CreateTransactionResponsePolicy(string id = default(string), string varObject = default(string), decimal createdAt = default(decimal), string name = default(string), bool deleted = default(bool), decimal chainId = default(decimal), CreateTransactionResponsePolicyStrategy strategy = default(CreateTransactionResponsePolicyStrategy), List<CreateTransactionResponsePolicyTransactionIntentsInner> transactionIntents = default(List<CreateTransactionResponsePolicyTransactionIntentsInner>), List<CreateTransactionResponsePolicyPolicyRulesInner> policyRules = default(List<CreateTransactionResponsePolicyPolicyRulesInner>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for CreateTransactionResponsePolicy and cannot be null");
            }
            this.Id = id;
            // to ensure "varObject" is required (not null)
            if (varObject == null)
            {
                throw new ArgumentNullException("varObject is a required property for CreateTransactionResponsePolicy and cannot be null");
            }
            this.VarObject = varObject;
            this.CreatedAt = createdAt;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateTransactionResponsePolicy and cannot be null");
            }
            this.Name = name;
            this.Deleted = deleted;
            this.ChainId = chainId;
            // to ensure "strategy" is required (not null)
            if (strategy == null)
            {
                throw new ArgumentNullException("strategy is a required property for CreateTransactionResponsePolicy and cannot be null");
            }
            this.Strategy = strategy;
            this.TransactionIntents = transactionIntents;
            this.PolicyRules = policyRules;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets VarObject
        /// </summary>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string VarObject { get; set; }

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
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name = "deleted", IsRequired = true, EmitDefaultValue = true)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [DataMember(Name = "chainId", IsRequired = true, EmitDefaultValue = true)]
        public decimal ChainId { get; set; }

        /// <summary>
        /// Gets or Sets Strategy
        /// </summary>
        [DataMember(Name = "strategy", IsRequired = true, EmitDefaultValue = true)]
        public CreateTransactionResponsePolicyStrategy Strategy { get; set; }

        /// <summary>
        /// Gets or Sets TransactionIntents
        /// </summary>
        [DataMember(Name = "transactionIntents", EmitDefaultValue = false)]
        public List<CreateTransactionResponsePolicyTransactionIntentsInner> TransactionIntents { get; set; }

        /// <summary>
        /// Gets or Sets PolicyRules
        /// </summary>
        [DataMember(Name = "policyRules", EmitDefaultValue = false)]
        public List<CreateTransactionResponsePolicyPolicyRulesInner> PolicyRules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateTransactionResponsePolicy {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VarObject: ").Append(VarObject).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Strategy: ").Append(Strategy).Append("\n");
            sb.Append("  TransactionIntents: ").Append(TransactionIntents).Append("\n");
            sb.Append("  PolicyRules: ").Append(PolicyRules).Append("\n");
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
            return this.Equals(input as CreateTransactionResponsePolicy);
        }

        /// <summary>
        /// Returns true if CreateTransactionResponsePolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTransactionResponsePolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTransactionResponsePolicy input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.VarObject == input.VarObject ||
                    (this.VarObject != null &&
                    this.VarObject.Equals(input.VarObject))
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
                    this.Deleted == input.Deleted ||
                    this.Deleted.Equals(input.Deleted)
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
                ) && 
                (
                    this.Strategy == input.Strategy ||
                    (this.Strategy != null &&
                    this.Strategy.Equals(input.Strategy))
                ) && 
                (
                    this.TransactionIntents == input.TransactionIntents ||
                    this.TransactionIntents != null &&
                    input.TransactionIntents != null &&
                    this.TransactionIntents.SequenceEqual(input.TransactionIntents)
                ) && 
                (
                    this.PolicyRules == input.PolicyRules ||
                    this.PolicyRules != null &&
                    input.PolicyRules != null &&
                    this.PolicyRules.SequenceEqual(input.PolicyRules)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.VarObject != null)
                {
                    hashCode = (hashCode * 59) + this.VarObject.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Deleted.GetHashCode();
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                if (this.Strategy != null)
                {
                    hashCode = (hashCode * 59) + this.Strategy.GetHashCode();
                }
                if (this.TransactionIntents != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionIntents.GetHashCode();
                }
                if (this.PolicyRules != null)
                {
                    hashCode = (hashCode * 59) + this.PolicyRules.GetHashCode();
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
