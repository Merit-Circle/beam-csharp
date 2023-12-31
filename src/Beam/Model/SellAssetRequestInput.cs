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
    /// SellAssetRequestInput
    /// </summary>
    [DataContract(Name = "SellAssetRequestInput")]
    public partial class SellAssetRequestInput : IEquatable<SellAssetRequestInput>, IValidatableObject
    {
        /// <summary>
        /// Defines SellType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SellTypeEnum
        {
            /// <summary>
            /// Enum FixedPrice for value: FixedPrice
            /// </summary>
            [EnumMember(Value = "FixedPrice")]
            FixedPrice = 1,

            /// <summary>
            /// Enum DescendingAuction for value: DescendingAuction
            /// </summary>
            [EnumMember(Value = "DescendingAuction")]
            DescendingAuction = 2,

            /// <summary>
            /// Enum AscendingAuction for value: AscendingAuction
            /// </summary>
            [EnumMember(Value = "AscendingAuction")]
            AscendingAuction = 3,

            /// <summary>
            /// Enum NotForSale for value: NotForSale
            /// </summary>
            [EnumMember(Value = "NotForSale")]
            NotForSale = 4
        }


        /// <summary>
        /// Gets or Sets SellType
        /// </summary>
        [DataMember(Name = "sellType", IsRequired = true, EmitDefaultValue = true)]
        public SellTypeEnum SellType { get; set; }
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
            /// Enum Beam for value: Beam
            /// </summary>
            [EnumMember(Value = "Beam")]
            Beam = 2,

            /// <summary>
            /// Enum Eth for value: Eth
            /// </summary>
            [EnumMember(Value = "Eth")]
            Eth = 3,

            /// <summary>
            /// Enum Matic for value: Matic
            /// </summary>
            [EnumMember(Value = "Matic")]
            Matic = 4,

            /// <summary>
            /// Enum Mc for value: Mc
            /// </summary>
            [EnumMember(Value = "Mc")]
            Mc = 5,

            /// <summary>
            /// Enum Usdc for value: Usdc
            /// </summary>
            [EnumMember(Value = "Usdc")]
            Usdc = 6,

            /// <summary>
            /// Enum Usdt for value: Usdt
            /// </summary>
            [EnumMember(Value = "Usdt")]
            Usdt = 7,

            /// <summary>
            /// Enum Wavax for value: Wavax
            /// </summary>
            [EnumMember(Value = "Wavax")]
            Wavax = 8,

            /// <summary>
            /// Enum Wbeam for value: Wbeam
            /// </summary>
            [EnumMember(Value = "Wbeam")]
            Wbeam = 9,

            /// <summary>
            /// Enum Weth for value: Weth
            /// </summary>
            [EnumMember(Value = "Weth")]
            Weth = 10,

            /// <summary>
            /// Enum Wmatic for value: Wmatic
            /// </summary>
            [EnumMember(Value = "Wmatic")]
            Wmatic = 11,

            /// <summary>
            /// Enum Wmc for value: Wmc
            /// </summary>
            [EnumMember(Value = "Wmc")]
            Wmc = 12
        }


        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public CurrencyEnum? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SellAssetRequestInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SellAssetRequestInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SellAssetRequestInput" /> class.
        /// </summary>
        /// <param name="marketplaceId">marketplaceId (required).</param>
        /// <param name="quantity">quantity (required).</param>
        /// <param name="price">price (required).</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="sellType">sellType (required).</param>
        /// <param name="currency">currency (default to CurrencyEnum.Beam).</param>
        /// <param name="sponsor">sponsor (default to true).</param>
        /// <param name="policyId">policyId.</param>
        /// <param name="chainId">chainId (default to 13337M).</param>
        public SellAssetRequestInput(string marketplaceId = default(string), decimal quantity = default(decimal), string price = default(string), string startTime = default(string), string endTime = default(string), SellTypeEnum sellType = default(SellTypeEnum), CurrencyEnum? currency = CurrencyEnum.Beam, bool sponsor = true, string policyId = default(string), decimal chainId = 13337M)
        {
            // to ensure "marketplaceId" is required (not null)
            if (marketplaceId == null)
            {
                throw new ArgumentNullException("marketplaceId is a required property for SellAssetRequestInput and cannot be null");
            }
            this.MarketplaceId = marketplaceId;
            this.Quantity = quantity;
            // to ensure "price" is required (not null)
            if (price == null)
            {
                throw new ArgumentNullException("price is a required property for SellAssetRequestInput and cannot be null");
            }
            this.Price = price;
            this.SellType = sellType;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Currency = currency;
            this.Sponsor = sponsor;
            this.PolicyId = policyId;
            this.ChainId = chainId;
        }

        /// <summary>
        /// Gets or Sets MarketplaceId
        /// </summary>
        [DataMember(Name = "marketplaceId", IsRequired = true, EmitDefaultValue = true)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", IsRequired = true, EmitDefaultValue = true)]
        public string Price { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name = "endTime", EmitDefaultValue = false)]
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or Sets Sponsor
        /// </summary>
        [DataMember(Name = "sponsor", EmitDefaultValue = true)]
        public bool Sponsor { get; set; }

        /// <summary>
        /// Gets or Sets PolicyId
        /// </summary>
        [DataMember(Name = "policyId", EmitDefaultValue = false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [DataMember(Name = "chainId", EmitDefaultValue = false)]
        public decimal ChainId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SellAssetRequestInput {\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  SellType: ").Append(SellType).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Sponsor: ").Append(Sponsor).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
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
            return this.Equals(input as SellAssetRequestInput);
        }

        /// <summary>
        /// Returns true if SellAssetRequestInput instances are equal
        /// </summary>
        /// <param name="input">Instance of SellAssetRequestInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SellAssetRequestInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MarketplaceId == input.MarketplaceId ||
                    (this.MarketplaceId != null &&
                    this.MarketplaceId.Equals(input.MarketplaceId))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
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
                ) && 
                (
                    this.SellType == input.SellType ||
                    this.SellType.Equals(input.SellType)
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.Sponsor == input.Sponsor ||
                    this.Sponsor.Equals(input.Sponsor)
                ) && 
                (
                    this.PolicyId == input.PolicyId ||
                    (this.PolicyId != null &&
                    this.PolicyId.Equals(input.PolicyId))
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
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
                if (this.MarketplaceId != null)
                {
                    hashCode = (hashCode * 59) + this.MarketplaceId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SellType.GetHashCode();
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                hashCode = (hashCode * 59) + this.Sponsor.GetHashCode();
                if (this.PolicyId != null)
                {
                    hashCode = (hashCode * 59) + this.PolicyId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
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
