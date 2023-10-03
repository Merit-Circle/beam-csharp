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
    /// GetAssetResponseListing
    /// </summary>
    [DataContract(Name = "GetAssetResponse_listing")]
    public partial class GetAssetResponseListing : IEquatable<GetAssetResponseListing>, IValidatableObject
    {
        /// <summary>
        /// Defines SellType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SellTypeEnum
        {
            /// <summary>
            /// Enum AscendingAuction for value: AscendingAuction
            /// </summary>
            [EnumMember(Value = "AscendingAuction")]
            AscendingAuction = 1,

            /// <summary>
            /// Enum DescendingAuction for value: DescendingAuction
            /// </summary>
            [EnumMember(Value = "DescendingAuction")]
            DescendingAuction = 2,

            /// <summary>
            /// Enum FixedPrice for value: FixedPrice
            /// </summary>
            [EnumMember(Value = "FixedPrice")]
            FixedPrice = 3,

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
        /// Initializes a new instance of the <see cref="GetAssetResponseListing" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAssetResponseListing() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetResponseListing" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="nftId">nftId (required).</param>
        /// <param name="contractId">contractId (required).</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="sellType">sellType (required).</param>
        /// <param name="quantity">quantity (required).</param>
        /// <param name="tokenAddress">tokenAddress (required).</param>
        /// <param name="price">price.</param>
        /// <param name="startPrice">startPrice.</param>
        /// <param name="endPrice">endPrice.</param>
        /// <param name="startTime">startTime (required).</param>
        /// <param name="endTime">endTime (required).</param>
        /// <param name="expiresAt">expiresAt (required).</param>
        /// <param name="platformFee">platformFee (required).</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="orderId">orderId.</param>
        public GetAssetResponseListing(string id = default(string), string nftId = default(string), string contractId = default(string), string userId = default(string), SellTypeEnum sellType = default(SellTypeEnum), decimal quantity = default(decimal), string tokenAddress = default(string), string price = default(string), string startPrice = default(string), string endPrice = default(string), string startTime = default(string), string endTime = default(string), string expiresAt = default(string), decimal platformFee = default(decimal), string createdAt = default(string), string updatedAt = default(string), CurrencyEnum currency = default(CurrencyEnum), string orderId = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for GetAssetResponseListing and cannot be null");
            }
            this.Id = id;
            // to ensure "nftId" is required (not null)
            if (nftId == null)
            {
                throw new ArgumentNullException("nftId is a required property for GetAssetResponseListing and cannot be null");
            }
            this.NftId = nftId;
            // to ensure "contractId" is required (not null)
            if (contractId == null)
            {
                throw new ArgumentNullException("contractId is a required property for GetAssetResponseListing and cannot be null");
            }
            this.ContractId = contractId;
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new ArgumentNullException("userId is a required property for GetAssetResponseListing and cannot be null");
            }
            this.UserId = userId;
            this.SellType = sellType;
            this.Quantity = quantity;
            // to ensure "tokenAddress" is required (not null)
            if (tokenAddress == null)
            {
                throw new ArgumentNullException("tokenAddress is a required property for GetAssetResponseListing and cannot be null");
            }
            this.TokenAddress = tokenAddress;
            // to ensure "startTime" is required (not null)
            if (startTime == null)
            {
                throw new ArgumentNullException("startTime is a required property for GetAssetResponseListing and cannot be null");
            }
            this.StartTime = startTime;
            // to ensure "endTime" is required (not null)
            if (endTime == null)
            {
                throw new ArgumentNullException("endTime is a required property for GetAssetResponseListing and cannot be null");
            }
            this.EndTime = endTime;
            // to ensure "expiresAt" is required (not null)
            if (expiresAt == null)
            {
                throw new ArgumentNullException("expiresAt is a required property for GetAssetResponseListing and cannot be null");
            }
            this.ExpiresAt = expiresAt;
            this.PlatformFee = platformFee;
            this.Currency = currency;
            this.Price = price;
            this.StartPrice = startPrice;
            this.EndPrice = endPrice;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.OrderId = orderId;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "_id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets NftId
        /// </summary>
        [DataMember(Name = "nftId", IsRequired = true, EmitDefaultValue = true)]
        public string NftId { get; set; }

        /// <summary>
        /// Gets or Sets ContractId
        /// </summary>
        [DataMember(Name = "contractId", IsRequired = true, EmitDefaultValue = true)]
        public string ContractId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or Sets TokenAddress
        /// </summary>
        [DataMember(Name = "tokenAddress", IsRequired = true, EmitDefaultValue = true)]
        public string TokenAddress { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = true)]
        public string Price { get; set; }

        /// <summary>
        /// Gets or Sets StartPrice
        /// </summary>
        [DataMember(Name = "startPrice", EmitDefaultValue = true)]
        public string StartPrice { get; set; }

        /// <summary>
        /// Gets or Sets EndPrice
        /// </summary>
        [DataMember(Name = "endPrice", EmitDefaultValue = true)]
        public string EndPrice { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "startTime", IsRequired = true, EmitDefaultValue = true)]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name = "endTime", IsRequired = true, EmitDefaultValue = true)]
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresAt
        /// </summary>
        [DataMember(Name = "expiresAt", IsRequired = true, EmitDefaultValue = true)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// Gets or Sets PlatformFee
        /// </summary>
        [DataMember(Name = "platformFee", IsRequired = true, EmitDefaultValue = true)]
        public decimal PlatformFee { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = true)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name = "orderId", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAssetResponseListing {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NftId: ").Append(NftId).Append("\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  SellType: ").Append(SellType).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  TokenAddress: ").Append(TokenAddress).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  StartPrice: ").Append(StartPrice).Append("\n");
            sb.Append("  EndPrice: ").Append(EndPrice).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  PlatformFee: ").Append(PlatformFee).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
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
            return this.Equals(input as GetAssetResponseListing);
        }

        /// <summary>
        /// Returns true if GetAssetResponseListing instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAssetResponseListing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAssetResponseListing input)
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
                    this.NftId == input.NftId ||
                    (this.NftId != null &&
                    this.NftId.Equals(input.NftId))
                ) && 
                (
                    this.ContractId == input.ContractId ||
                    (this.ContractId != null &&
                    this.ContractId.Equals(input.ContractId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.SellType == input.SellType ||
                    this.SellType.Equals(input.SellType)
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.TokenAddress == input.TokenAddress ||
                    (this.TokenAddress != null &&
                    this.TokenAddress.Equals(input.TokenAddress))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.StartPrice == input.StartPrice ||
                    (this.StartPrice != null &&
                    this.StartPrice.Equals(input.StartPrice))
                ) && 
                (
                    this.EndPrice == input.EndPrice ||
                    (this.EndPrice != null &&
                    this.EndPrice.Equals(input.EndPrice))
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
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
                ) && 
                (
                    this.PlatformFee == input.PlatformFee ||
                    this.PlatformFee.Equals(input.PlatformFee)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
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
                if (this.NftId != null)
                {
                    hashCode = (hashCode * 59) + this.NftId.GetHashCode();
                }
                if (this.ContractId != null)
                {
                    hashCode = (hashCode * 59) + this.ContractId.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SellType.GetHashCode();
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                if (this.TokenAddress != null)
                {
                    hashCode = (hashCode * 59) + this.TokenAddress.GetHashCode();
                }
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
                }
                if (this.StartPrice != null)
                {
                    hashCode = (hashCode * 59) + this.StartPrice.GetHashCode();
                }
                if (this.EndPrice != null)
                {
                    hashCode = (hashCode * 59) + this.EndPrice.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                if (this.ExpiresAt != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiresAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PlatformFee.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
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
