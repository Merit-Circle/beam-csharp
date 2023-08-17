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
    /// GetProfileCurrenciesResponseDataInner
    /// </summary>
    [DataContract(Name = "GetProfileCurrenciesResponse_data_inner")]
    public partial class GetProfileCurrenciesResponseDataInner : IEquatable<GetProfileCurrenciesResponseDataInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProfileCurrenciesResponseDataInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetProfileCurrenciesResponseDataInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProfileCurrenciesResponseDataInner" /> class.
        /// </summary>
        /// <param name="address">address (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="symbol">symbol (required).</param>
        /// <param name="decimals">decimals (required).</param>
        /// <param name="logoUri">logoUri.</param>
        /// <param name="chainId">chainId (required).</param>
        /// <param name="balance">balance (required).</param>
        public GetProfileCurrenciesResponseDataInner(string address = default(string), string name = default(string), string symbol = default(string), decimal decimals = default(decimal), string logoUri = default(string), string chainId = default(string), string balance = default(string))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for GetProfileCurrenciesResponseDataInner and cannot be null");
            }
            this.Address = address;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for GetProfileCurrenciesResponseDataInner and cannot be null");
            }
            this.Name = name;
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new ArgumentNullException("symbol is a required property for GetProfileCurrenciesResponseDataInner and cannot be null");
            }
            this.Symbol = symbol;
            this.Decimals = decimals;
            // to ensure "chainId" is required (not null)
            if (chainId == null)
            {
                throw new ArgumentNullException("chainId is a required property for GetProfileCurrenciesResponseDataInner and cannot be null");
            }
            this.ChainId = chainId;
            // to ensure "balance" is required (not null)
            if (balance == null)
            {
                throw new ArgumentNullException("balance is a required property for GetProfileCurrenciesResponseDataInner and cannot be null");
            }
            this.Balance = balance;
            this.LogoUri = logoUri;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = true)]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets Decimals
        /// </summary>
        [DataMember(Name = "decimals", IsRequired = true, EmitDefaultValue = true)]
        public decimal Decimals { get; set; }

        /// <summary>
        /// Gets or Sets LogoUri
        /// </summary>
        [DataMember(Name = "logoUri", EmitDefaultValue = false)]
        public string LogoUri { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [DataMember(Name = "chainId", IsRequired = true, EmitDefaultValue = true)]
        public string ChainId { get; set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name = "balance", IsRequired = true, EmitDefaultValue = true)]
        public string Balance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetProfileCurrenciesResponseDataInner {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Decimals: ").Append(Decimals).Append("\n");
            sb.Append("  LogoUri: ").Append(LogoUri).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
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
            return this.Equals(input as GetProfileCurrenciesResponseDataInner);
        }

        /// <summary>
        /// Returns true if GetProfileCurrenciesResponseDataInner instances are equal
        /// </summary>
        /// <param name="input">Instance of GetProfileCurrenciesResponseDataInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetProfileCurrenciesResponseDataInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Decimals == input.Decimals ||
                    this.Decimals.Equals(input.Decimals)
                ) && 
                (
                    this.LogoUri == input.LogoUri ||
                    (this.LogoUri != null &&
                    this.LogoUri.Equals(input.LogoUri))
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    (this.ChainId != null &&
                    this.ChainId.Equals(input.ChainId))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Decimals.GetHashCode();
                if (this.LogoUri != null)
                {
                    hashCode = (hashCode * 59) + this.LogoUri.GetHashCode();
                }
                if (this.ChainId != null)
                {
                    hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                }
                if (this.Balance != null)
                {
                    hashCode = (hashCode * 59) + this.Balance.GetHashCode();
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