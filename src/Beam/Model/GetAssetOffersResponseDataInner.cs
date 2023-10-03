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
    /// GetAssetOffersResponseDataInner
    /// </summary>
    [DataContract(Name = "GetAssetOffersResponse_data_inner")]
    public partial class GetAssetOffersResponseDataInner : IEquatable<GetAssetOffersResponseDataInner>, IValidatableObject
    {
        /// <summary>
        /// Defines Kind
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum KindEnum
        {
            /// <summary>
            /// Enum SignedCollectionOrder for value: SignedCollectionOrder
            /// </summary>
            [EnumMember(Value = "SignedCollectionOrder")]
            SignedCollectionOrder = 1,

            /// <summary>
            /// Enum SignedSingleOrder for value: SignedSingleOrder
            /// </summary>
            [EnumMember(Value = "SignedSingleOrder")]
            SignedSingleOrder = 2
        }


        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        [DataMember(Name = "kind", IsRequired = true, EmitDefaultValue = true)]
        public KindEnum Kind { get; set; }
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
        /// Initializes a new instance of the <see cref="GetAssetOffersResponseDataInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAssetOffersResponseDataInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetOffersResponseDataInner" /> class.
        /// </summary>
        /// <param name="orderId">orderId (required).</param>
        /// <param name="kind">kind (required).</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="quantity">quantity (required).</param>
        /// <param name="quantityFilled">quantityFilled (required).</param>
        /// <param name="quantityAvailable">quantityAvailable (required).</param>
        /// <param name="offerer">offerer (required).</param>
        /// <param name="tokenAmount">tokenAmount (required).</param>
        /// <param name="tokenAmountNumber">tokenAmountNumber (required).</param>
        /// <param name="startTime">startTime (required).</param>
        /// <param name="endTime">endTime (required).</param>
        public GetAssetOffersResponseDataInner(string orderId = default(string), KindEnum kind = default(KindEnum), CurrencyEnum currency = default(CurrencyEnum), decimal quantity = default(decimal), decimal quantityFilled = default(decimal), decimal quantityAvailable = default(decimal), string offerer = default(string), string tokenAmount = default(string), decimal tokenAmountNumber = default(decimal), DateTime startTime = default(DateTime), DateTime endTime = default(DateTime))
        {
            // to ensure "orderId" is required (not null)
            if (orderId == null)
            {
                throw new ArgumentNullException("orderId is a required property for GetAssetOffersResponseDataInner and cannot be null");
            }
            this.OrderId = orderId;
            this.Kind = kind;
            this.Currency = currency;
            this.Quantity = quantity;
            this.QuantityFilled = quantityFilled;
            this.QuantityAvailable = quantityAvailable;
            // to ensure "offerer" is required (not null)
            if (offerer == null)
            {
                throw new ArgumentNullException("offerer is a required property for GetAssetOffersResponseDataInner and cannot be null");
            }
            this.Offerer = offerer;
            // to ensure "tokenAmount" is required (not null)
            if (tokenAmount == null)
            {
                throw new ArgumentNullException("tokenAmount is a required property for GetAssetOffersResponseDataInner and cannot be null");
            }
            this.TokenAmount = tokenAmount;
            this.TokenAmountNumber = tokenAmountNumber;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name = "orderId", IsRequired = true, EmitDefaultValue = true)]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or Sets QuantityFilled
        /// </summary>
        [DataMember(Name = "quantityFilled", IsRequired = true, EmitDefaultValue = true)]
        public decimal QuantityFilled { get; set; }

        /// <summary>
        /// Gets or Sets QuantityAvailable
        /// </summary>
        [DataMember(Name = "quantityAvailable", IsRequired = true, EmitDefaultValue = true)]
        public decimal QuantityAvailable { get; set; }

        /// <summary>
        /// Gets or Sets Offerer
        /// </summary>
        [DataMember(Name = "offerer", IsRequired = true, EmitDefaultValue = true)]
        public string Offerer { get; set; }

        /// <summary>
        /// Gets or Sets TokenAmount
        /// </summary>
        [DataMember(Name = "tokenAmount", IsRequired = true, EmitDefaultValue = true)]
        public string TokenAmount { get; set; }

        /// <summary>
        /// Gets or Sets TokenAmountNumber
        /// </summary>
        [DataMember(Name = "tokenAmountNumber", IsRequired = true, EmitDefaultValue = true)]
        public decimal TokenAmountNumber { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "startTime", IsRequired = true, EmitDefaultValue = true)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name = "endTime", IsRequired = true, EmitDefaultValue = true)]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAssetOffersResponseDataInner {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  QuantityFilled: ").Append(QuantityFilled).Append("\n");
            sb.Append("  QuantityAvailable: ").Append(QuantityAvailable).Append("\n");
            sb.Append("  Offerer: ").Append(Offerer).Append("\n");
            sb.Append("  TokenAmount: ").Append(TokenAmount).Append("\n");
            sb.Append("  TokenAmountNumber: ").Append(TokenAmountNumber).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
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
            return this.Equals(input as GetAssetOffersResponseDataInner);
        }

        /// <summary>
        /// Returns true if GetAssetOffersResponseDataInner instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAssetOffersResponseDataInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAssetOffersResponseDataInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.Kind == input.Kind ||
                    this.Kind.Equals(input.Kind)
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.QuantityFilled == input.QuantityFilled ||
                    this.QuantityFilled.Equals(input.QuantityFilled)
                ) && 
                (
                    this.QuantityAvailable == input.QuantityAvailable ||
                    this.QuantityAvailable.Equals(input.QuantityAvailable)
                ) && 
                (
                    this.Offerer == input.Offerer ||
                    (this.Offerer != null &&
                    this.Offerer.Equals(input.Offerer))
                ) && 
                (
                    this.TokenAmount == input.TokenAmount ||
                    (this.TokenAmount != null &&
                    this.TokenAmount.Equals(input.TokenAmount))
                ) && 
                (
                    this.TokenAmountNumber == input.TokenAmountNumber ||
                    this.TokenAmountNumber.Equals(input.TokenAmountNumber)
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
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
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Kind.GetHashCode();
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                hashCode = (hashCode * 59) + this.QuantityFilled.GetHashCode();
                hashCode = (hashCode * 59) + this.QuantityAvailable.GetHashCode();
                if (this.Offerer != null)
                {
                    hashCode = (hashCode * 59) + this.Offerer.GetHashCode();
                }
                if (this.TokenAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TokenAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TokenAmountNumber.GetHashCode();
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
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