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
    /// GetGameResponsePoliciesInner
    /// </summary>
    [DataContract(Name = "GetGameResponse_policies_inner")]
    public partial class GetGameResponsePoliciesInner : IEquatable<GetGameResponsePoliciesInner>, IValidatableObject
    {
        /// <summary>
        /// Defines Model
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModelEnum
        {
            /// <summary>
            /// Enum ContractFunctions for value: ContractFunctions
            /// </summary>
            [EnumMember(Value = "ContractFunctions")]
            ContractFunctions = 1,

            /// <summary>
            /// Enum AccountFunctions for value: AccountFunctions
            /// </summary>
            [EnumMember(Value = "AccountFunctions")]
            AccountFunctions = 2
        }


        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name = "model", IsRequired = true, EmitDefaultValue = true)]
        public ModelEnum Model { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum PayForUser for value: PayForUser
            /// </summary>
            [EnumMember(Value = "PayForUser")]
            PayForUser = 1,

            /// <summary>
            /// Enum ChargeCustomToken for value: ChargeCustomToken
            /// </summary>
            [EnumMember(Value = "ChargeCustomToken")]
            ChargeCustomToken = 2
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetGameResponsePoliciesInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetGameResponsePoliciesInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetGameResponsePoliciesInner" /> class.
        /// </summary>
        /// <param name="model">model (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="chainId">chainId (required).</param>
        /// <param name="gameId">gameId (required).</param>
        /// <param name="token">token (required).</param>
        /// <param name="exchangeRate">exchangeRate (required).</param>
        public GetGameResponsePoliciesInner(ModelEnum model = default(ModelEnum), TypeEnum type = default(TypeEnum), string id = default(string), string name = default(string), int chainId = default(int), int gameId = default(int), string token = default(string), string exchangeRate = default(string))
        {
            this.Model = model;
            this.Type = type;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for GetGameResponsePoliciesInner and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for GetGameResponsePoliciesInner and cannot be null");
            }
            this.Name = name;
            this.ChainId = chainId;
            this.GameId = gameId;
            // to ensure "token" is required (not null)
            if (token == null)
            {
                throw new ArgumentNullException("token is a required property for GetGameResponsePoliciesInner and cannot be null");
            }
            this.Token = token;
            // to ensure "exchangeRate" is required (not null)
            if (exchangeRate == null)
            {
                throw new ArgumentNullException("exchangeRate is a required property for GetGameResponsePoliciesInner and cannot be null");
            }
            this.ExchangeRate = exchangeRate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [DataMember(Name = "chainId", IsRequired = true, EmitDefaultValue = true)]
        public int ChainId { get; set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name = "gameId", IsRequired = true, EmitDefaultValue = true)]
        public int GameId { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", IsRequired = true, EmitDefaultValue = true)]
        public string Token { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeRate
        /// </summary>
        [DataMember(Name = "exchangeRate", IsRequired = true, EmitDefaultValue = true)]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetGameResponsePoliciesInner {\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
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
            return this.Equals(input as GetGameResponsePoliciesInner);
        }

        /// <summary>
        /// Returns true if GetGameResponsePoliciesInner instances are equal
        /// </summary>
        /// <param name="input">Instance of GetGameResponsePoliciesInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetGameResponsePoliciesInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Model == input.Model ||
                    this.Model.Equals(input.Model)
                ) && 
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
                ) && 
                (
                    this.GameId == input.GameId ||
                    this.GameId.Equals(input.GameId)
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.ExchangeRate == input.ExchangeRate ||
                    (this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(input.ExchangeRate))
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
                hashCode = (hashCode * 59) + this.Model.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                hashCode = (hashCode * 59) + this.GameId.GetHashCode();
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
                }
                if (this.ExchangeRate != null)
                {
                    hashCode = (hashCode * 59) + this.ExchangeRate.GetHashCode();
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
