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
    /// CreateTransferOwnershipRequestResponse
    /// </summary>
    [DataContract(Name = "CreateTransferOwnershipRequestResponse")]
    public partial class CreateTransferOwnershipRequestResponse : IEquatable<CreateTransferOwnershipRequestResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum TransferOwnership for value: TransferOwnership
            /// </summary>
            [EnumMember(Value = "TransferOwnership")]
            TransferOwnership = 1,

            /// <summary>
            /// Enum BuyOrder for value: BuyOrder
            /// </summary>
            [EnumMember(Value = "BuyOrder")]
            BuyOrder = 2,

            /// <summary>
            /// Enum SellOrder for value: SellOrder
            /// </summary>
            [EnumMember(Value = "SellOrder")]
            SellOrder = 3,

            /// <summary>
            /// Enum CancelOrder for value: CancelOrder
            /// </summary>
            [EnumMember(Value = "CancelOrder")]
            CancelOrder = 4,

            /// <summary>
            /// Enum CreateSession for value: CreateSession
            /// </summary>
            [EnumMember(Value = "CreateSession")]
            CreateSession = 5,

            /// <summary>
            /// Enum RevokeSession for value: RevokeSession
            /// </summary>
            [EnumMember(Value = "RevokeSession")]
            RevokeSession = 6
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransferOwnershipRequestResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTransferOwnershipRequestResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransferOwnershipRequestResponse" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="message">message (required).</param>
        /// <param name="chainId">chainId (required).</param>
        /// <param name="accountAddress">accountAddress (required).</param>
        /// <param name="signerAddress">signerAddress (required).</param>
        /// <param name="url">url (required).</param>
        public CreateTransferOwnershipRequestResponse(TypeEnum type = default(TypeEnum), string id = default(string), Object createdAt = default(Object), string message = default(string), int chainId = default(int), string accountAddress = default(string), string signerAddress = default(string), string url = default(string))
        {
            this.Type = type;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for CreateTransferOwnershipRequestResponse and cannot be null");
            }
            this.Id = id;
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new ArgumentNullException("createdAt is a required property for CreateTransferOwnershipRequestResponse and cannot be null");
            }
            this.CreatedAt = createdAt;
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for CreateTransferOwnershipRequestResponse and cannot be null");
            }
            this.Message = message;
            this.ChainId = chainId;
            // to ensure "accountAddress" is required (not null)
            if (accountAddress == null)
            {
                throw new ArgumentNullException("accountAddress is a required property for CreateTransferOwnershipRequestResponse and cannot be null");
            }
            this.AccountAddress = accountAddress;
            // to ensure "signerAddress" is required (not null)
            if (signerAddress == null)
            {
                throw new ArgumentNullException("signerAddress is a required property for CreateTransferOwnershipRequestResponse and cannot be null");
            }
            this.SignerAddress = signerAddress;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for CreateTransferOwnershipRequestResponse and cannot be null");
            }
            this.Url = url;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public Object CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [DataMember(Name = "chainId", IsRequired = true, EmitDefaultValue = true)]
        public int ChainId { get; set; }

        /// <summary>
        /// Gets or Sets AccountAddress
        /// </summary>
        [DataMember(Name = "accountAddress", IsRequired = true, EmitDefaultValue = true)]
        public string AccountAddress { get; set; }

        /// <summary>
        /// Gets or Sets SignerAddress
        /// </summary>
        [DataMember(Name = "signerAddress", IsRequired = true, EmitDefaultValue = true)]
        public string SignerAddress { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateTransferOwnershipRequestResponse {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  AccountAddress: ").Append(AccountAddress).Append("\n");
            sb.Append("  SignerAddress: ").Append(SignerAddress).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as CreateTransferOwnershipRequestResponse);
        }

        /// <summary>
        /// Returns true if CreateTransferOwnershipRequestResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTransferOwnershipRequestResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTransferOwnershipRequestResponse input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
                ) && 
                (
                    this.AccountAddress == input.AccountAddress ||
                    (this.AccountAddress != null &&
                    this.AccountAddress.Equals(input.AccountAddress))
                ) && 
                (
                    this.SignerAddress == input.SignerAddress ||
                    (this.SignerAddress != null &&
                    this.SignerAddress.Equals(input.SignerAddress))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                if (this.AccountAddress != null)
                {
                    hashCode = (hashCode * 59) + this.AccountAddress.GetHashCode();
                }
                if (this.SignerAddress != null)
                {
                    hashCode = (hashCode * 59) + this.SignerAddress.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
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
