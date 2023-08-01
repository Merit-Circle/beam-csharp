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
    /// CreateTransactionResponsePolicyTransactionIntentsInner
    /// </summary>
    [DataContract(Name = "CreateTransactionResponse_policy_transactionIntents_inner")]
    public partial class CreateTransactionResponsePolicyTransactionIntentsInner : IEquatable<CreateTransactionResponsePolicyTransactionIntentsInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransactionResponsePolicyTransactionIntentsInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTransactionResponsePolicyTransactionIntentsInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransactionResponsePolicyTransactionIntentsInner" /> class.
        /// </summary>
        /// <param name="nextAction">nextAction.</param>
        /// <param name="policy">policy.</param>
        /// <param name="player">player.</param>
        /// <param name="account">account.</param>
        /// <param name="id">id (required).</param>
        /// <param name="varObject">varObject (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="chainId">chainId (required).</param>
        /// <param name="userOperationHash">userOperationHash.</param>
        /// <param name="userOperation">userOperation.</param>
        /// <param name="response">response.</param>
        /// <param name="interactions">interactions.</param>
        public CreateTransactionResponsePolicyTransactionIntentsInner(CreateTransactionResponseNextAction nextAction = default(CreateTransactionResponseNextAction), Object policy = default(Object), CreateTransactionResponsePolicyTransactionIntentsInnerPlayer player = default(CreateTransactionResponsePolicyTransactionIntentsInnerPlayer), Object account = default(Object), string id = default(string), string varObject = default(string), decimal createdAt = default(decimal), decimal updatedAt = default(decimal), decimal chainId = default(decimal), string userOperationHash = default(string), Object userOperation = default(Object), CreateTransactionResponsePolicyTransactionIntentsInnerResponse response = default(CreateTransactionResponsePolicyTransactionIntentsInnerResponse), List<CreateTransactionResponsePolicyTransactionIntentsInnerInteractionsInner> interactions = default(List<CreateTransactionResponsePolicyTransactionIntentsInnerInteractionsInner>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for CreateTransactionResponsePolicyTransactionIntentsInner and cannot be null");
            }
            this.Id = id;
            // to ensure "varObject" is required (not null)
            if (varObject == null)
            {
                throw new ArgumentNullException("varObject is a required property for CreateTransactionResponsePolicyTransactionIntentsInner and cannot be null");
            }
            this.VarObject = varObject;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ChainId = chainId;
            this.NextAction = nextAction;
            this.Policy = policy;
            this.Player = player;
            this.Account = account;
            this.UserOperationHash = userOperationHash;
            this.UserOperation = userOperation;
            this.Response = response;
            this.Interactions = interactions;
        }

        /// <summary>
        /// Gets or Sets NextAction
        /// </summary>
        [DataMember(Name = "nextAction", EmitDefaultValue = false)]
        public CreateTransactionResponseNextAction NextAction { get; set; }

        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [DataMember(Name = "policy", EmitDefaultValue = true)]
        public Object Policy { get; set; }

        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name = "player", EmitDefaultValue = false)]
        public CreateTransactionResponsePolicyTransactionIntentsInnerPlayer Player { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", EmitDefaultValue = true)]
        public Object Account { get; set; }

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
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public decimal UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [DataMember(Name = "chainId", IsRequired = true, EmitDefaultValue = true)]
        public decimal ChainId { get; set; }

        /// <summary>
        /// Gets or Sets UserOperationHash
        /// </summary>
        [DataMember(Name = "userOperationHash", EmitDefaultValue = false)]
        public string UserOperationHash { get; set; }

        /// <summary>
        /// Gets or Sets UserOperation
        /// </summary>
        [DataMember(Name = "userOperation", EmitDefaultValue = true)]
        public Object UserOperation { get; set; }

        /// <summary>
        /// Gets or Sets Response
        /// </summary>
        [DataMember(Name = "response", EmitDefaultValue = false)]
        public CreateTransactionResponsePolicyTransactionIntentsInnerResponse Response { get; set; }

        /// <summary>
        /// Gets or Sets Interactions
        /// </summary>
        [DataMember(Name = "interactions", EmitDefaultValue = false)]
        public List<CreateTransactionResponsePolicyTransactionIntentsInnerInteractionsInner> Interactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateTransactionResponsePolicyTransactionIntentsInner {\n");
            sb.Append("  NextAction: ").Append(NextAction).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VarObject: ").Append(VarObject).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  UserOperationHash: ").Append(UserOperationHash).Append("\n");
            sb.Append("  UserOperation: ").Append(UserOperation).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  Interactions: ").Append(Interactions).Append("\n");
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
            return this.Equals(input as CreateTransactionResponsePolicyTransactionIntentsInner);
        }

        /// <summary>
        /// Returns true if CreateTransactionResponsePolicyTransactionIntentsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTransactionResponsePolicyTransactionIntentsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTransactionResponsePolicyTransactionIntentsInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NextAction == input.NextAction ||
                    (this.NextAction != null &&
                    this.NextAction.Equals(input.NextAction))
                ) && 
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
                ) && 
                (
                    this.Player == input.Player ||
                    (this.Player != null &&
                    this.Player.Equals(input.Player))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
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
                    this.UpdatedAt == input.UpdatedAt ||
                    this.UpdatedAt.Equals(input.UpdatedAt)
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
                ) && 
                (
                    this.UserOperationHash == input.UserOperationHash ||
                    (this.UserOperationHash != null &&
                    this.UserOperationHash.Equals(input.UserOperationHash))
                ) && 
                (
                    this.UserOperation == input.UserOperation ||
                    (this.UserOperation != null &&
                    this.UserOperation.Equals(input.UserOperation))
                ) && 
                (
                    this.Response == input.Response ||
                    (this.Response != null &&
                    this.Response.Equals(input.Response))
                ) && 
                (
                    this.Interactions == input.Interactions ||
                    this.Interactions != null &&
                    input.Interactions != null &&
                    this.Interactions.SequenceEqual(input.Interactions)
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
                if (this.NextAction != null)
                {
                    hashCode = (hashCode * 59) + this.NextAction.GetHashCode();
                }
                if (this.Policy != null)
                {
                    hashCode = (hashCode * 59) + this.Policy.GetHashCode();
                }
                if (this.Player != null)
                {
                    hashCode = (hashCode * 59) + this.Player.GetHashCode();
                }
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.VarObject != null)
                {
                    hashCode = (hashCode * 59) + this.VarObject.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                if (this.UserOperationHash != null)
                {
                    hashCode = (hashCode * 59) + this.UserOperationHash.GetHashCode();
                }
                if (this.UserOperation != null)
                {
                    hashCode = (hashCode * 59) + this.UserOperation.GetHashCode();
                }
                if (this.Response != null)
                {
                    hashCode = (hashCode * 59) + this.Response.GetHashCode();
                }
                if (this.Interactions != null)
                {
                    hashCode = (hashCode * 59) + this.Interactions.GetHashCode();
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
