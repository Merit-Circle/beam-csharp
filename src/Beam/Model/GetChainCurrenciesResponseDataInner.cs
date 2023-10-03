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
    /// GetChainCurrenciesResponseDataInner
    /// </summary>
    [DataContract(Name = "GetChainCurrenciesResponse_data_inner")]
    public partial class GetChainCurrenciesResponseDataInner : IEquatable<GetChainCurrenciesResponseDataInner>, IValidatableObject
    {
        /// <summary>
        /// Defines Currency
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CurrencyEnum
        {
            /// <summary>
            /// Enum Avax for value: Avax
            /// </summary>
            [EnumMember(Value = "Avax")]
            Avax = 1,

            /// <summary>
            /// Enum Eth for value: Eth
            /// </summary>
            [EnumMember(Value = "Eth")]
            Eth = 2,

            /// <summary>
            /// Enum Matic for value: Matic
            /// </summary>
            [EnumMember(Value = "Matic")]
            Matic = 3,

            /// <summary>
            /// Enum Mc for value: Mc
            /// </summary>
            [EnumMember(Value = "Mc")]
            Mc = 4,

            /// <summary>
            /// Enum Usdc for value: Usdc
            /// </summary>
            [EnumMember(Value = "Usdc")]
            Usdc = 5,

            /// <summary>
            /// Enum Usdt for value: Usdt
            /// </summary>
            [EnumMember(Value = "Usdt")]
            Usdt = 6,

            /// <summary>
            /// Enum Wavax for value: Wavax
            /// </summary>
            [EnumMember(Value = "Wavax")]
            Wavax = 7,

            /// <summary>
            /// Enum Weth for value: Weth
            /// </summary>
            [EnumMember(Value = "Weth")]
            Weth = 8,

            /// <summary>
            /// Enum Wmatic for value: Wmatic
            /// </summary>
            [EnumMember(Value = "Wmatic")]
            Wmatic = 9,

            /// <summary>
            /// Enum Wmc for value: Wmc
            /// </summary>
            [EnumMember(Value = "Wmc")]
            Wmc = 10
        }


        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public CurrencyEnum Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetChainCurrenciesResponseDataInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetChainCurrenciesResponseDataInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetChainCurrenciesResponseDataInner" /> class.
        /// </summary>
        /// <param name="decimals">decimals (required).</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="tokenAddress">tokenAddress (required).</param>
        public GetChainCurrenciesResponseDataInner(decimal decimals = default(decimal), CurrencyEnum currency = default(CurrencyEnum), string tokenAddress = default(string))
        {
            this.Decimals = decimals;
            this.Currency = currency;
            // to ensure "tokenAddress" is required (not null)
            if (tokenAddress == null)
            {
                throw new ArgumentNullException("tokenAddress is a required property for GetChainCurrenciesResponseDataInner and cannot be null");
            }
            this.TokenAddress = tokenAddress;
        }

        /// <summary>
        /// Gets or Sets Decimals
        /// </summary>
        [DataMember(Name = "decimals", IsRequired = true, EmitDefaultValue = true)]
        public decimal Decimals { get; set; }

        /// <summary>
        /// Gets or Sets TokenAddress
        /// </summary>
        [DataMember(Name = "tokenAddress", IsRequired = true, EmitDefaultValue = true)]
        public string TokenAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetChainCurrenciesResponseDataInner {\n");
            sb.Append("  Decimals: ").Append(Decimals).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  TokenAddress: ").Append(TokenAddress).Append("\n");
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
            return this.Equals(input as GetChainCurrenciesResponseDataInner);
        }

        /// <summary>
        /// Returns true if GetChainCurrenciesResponseDataInner instances are equal
        /// </summary>
        /// <param name="input">Instance of GetChainCurrenciesResponseDataInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetChainCurrenciesResponseDataInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Decimals == input.Decimals ||
                    this.Decimals.Equals(input.Decimals)
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.TokenAddress == input.TokenAddress ||
                    (this.TokenAddress != null &&
                    this.TokenAddress.Equals(input.TokenAddress))
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
                hashCode = (hashCode * 59) + this.Decimals.GetHashCode();
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                if (this.TokenAddress != null)
                {
                    hashCode = (hashCode * 59) + this.TokenAddress.GetHashCode();
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