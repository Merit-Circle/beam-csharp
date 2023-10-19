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
    /// GetAssetResponse
    /// </summary>
    [DataContract(Name = "GetAssetResponse")]
    public partial class GetAssetResponse : IEquatable<GetAssetResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines Network
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NetworkEnum
        {
            /// <summary>
            /// Enum Avalanche for value: Avalanche
            /// </summary>
            [EnumMember(Value = "Avalanche")]
            Avalanche = 1,

            /// <summary>
            /// Enum Beam for value: Beam
            /// </summary>
            [EnumMember(Value = "Beam")]
            Beam = 2,

            /// <summary>
            /// Enum Ethereum for value: Ethereum
            /// </summary>
            [EnumMember(Value = "Ethereum")]
            Ethereum = 3,

            /// <summary>
            /// Enum Polygon for value: Polygon
            /// </summary>
            [EnumMember(Value = "Polygon")]
            Polygon = 4
        }


        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name = "network", IsRequired = true, EmitDefaultValue = true)]
        public NetworkEnum Network { get; set; }
        /// <summary>
        /// Defines Rarity
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RarityEnum
        {
            /// <summary>
            /// Enum Common for value: Common
            /// </summary>
            [EnumMember(Value = "Common")]
            Common = 1,

            /// <summary>
            /// Enum ExtremelyRare for value: ExtremelyRare
            /// </summary>
            [EnumMember(Value = "ExtremelyRare")]
            ExtremelyRare = 2,

            /// <summary>
            /// Enum Rare for value: Rare
            /// </summary>
            [EnumMember(Value = "Rare")]
            Rare = 3,

            /// <summary>
            /// Enum Uncommon for value: Uncommon
            /// </summary>
            [EnumMember(Value = "Uncommon")]
            Uncommon = 4,

            /// <summary>
            /// Enum VeryRare for value: VeryRare
            /// </summary>
            [EnumMember(Value = "VeryRare")]
            VeryRare = 5
        }


        /// <summary>
        /// Gets or Sets Rarity
        /// </summary>
        [DataMember(Name = "rarity", EmitDefaultValue = true)]
        public RarityEnum? Rarity { get; set; }
        /// <summary>
        /// Defines LastSoldTokenCurrency
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LastSoldTokenCurrencyEnum
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
        /// Gets or Sets LastSoldTokenCurrency
        /// </summary>
        [DataMember(Name = "lastSoldTokenCurrency", EmitDefaultValue = true)]
        public LastSoldTokenCurrencyEnum? LastSoldTokenCurrency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAssetResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetResponse" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="network">network (required).</param>
        /// <param name="chainId">chainId (required).</param>
        /// <param name="contractAddress">contractAddress (required).</param>
        /// <param name="tokenId">tokenId (required).</param>
        /// <param name="description">description.</param>
        /// <param name="mintedAt">mintedAt.</param>
        /// <param name="standardImageUrl">standardImageUrl.</param>
        /// <param name="thumbnailImageUrl">thumbnailImageUrl.</param>
        /// <param name="youtubeUrl">youtubeUrl.</param>
        /// <param name="backgroundColor">backgroundColor.</param>
        /// <param name="externalUrl">externalUrl.</param>
        /// <param name="tokenUri">tokenUri (required).</param>
        /// <param name="rarity">rarity.</param>
        /// <param name="rarityScore">rarityScore.</param>
        /// <param name="normalizedRarityScore">normalizedRarityScore.</param>
        /// <param name="lastSoldTokenAmount">lastSoldTokenAmount.</param>
        /// <param name="lastSoldTokenCurrency">lastSoldTokenCurrency.</param>
        /// <param name="indexerDataSyncedAt">indexerDataSyncedAt.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="contract">contract (required).</param>
        /// <param name="listing">listing.</param>
        /// <param name="ownershipByAddresses">ownershipByAddresses.</param>
        public GetAssetResponse(string id = default(string), string name = default(string), NetworkEnum network = default(NetworkEnum), decimal chainId = default(decimal), string contractAddress = default(string), string tokenId = default(string), string description = default(string), string mintedAt = default(string), string standardImageUrl = default(string), string thumbnailImageUrl = default(string), string youtubeUrl = default(string), string backgroundColor = default(string), string externalUrl = default(string), string tokenUri = default(string), RarityEnum? rarity = default(RarityEnum?), decimal? rarityScore = default(decimal?), decimal? normalizedRarityScore = default(decimal?), string lastSoldTokenAmount = default(string), LastSoldTokenCurrencyEnum? lastSoldTokenCurrency = default(LastSoldTokenCurrencyEnum?), string indexerDataSyncedAt = default(string), List<GetAssetsResponseDataInnerAttributesInner> attributes = default(List<GetAssetsResponseDataInnerAttributesInner>), GetAssetResponseContract contract = default(GetAssetResponseContract), GetAssetResponseListing listing = default(GetAssetResponseListing), List<GetAssetResponseOwnershipByAddressesInner> ownershipByAddresses = default(List<GetAssetResponseOwnershipByAddressesInner>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for GetAssetResponse and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for GetAssetResponse and cannot be null");
            }
            this.Name = name;
            this.Network = network;
            this.ChainId = chainId;
            // to ensure "contractAddress" is required (not null)
            if (contractAddress == null)
            {
                throw new ArgumentNullException("contractAddress is a required property for GetAssetResponse and cannot be null");
            }
            this.ContractAddress = contractAddress;
            // to ensure "tokenId" is required (not null)
            if (tokenId == null)
            {
                throw new ArgumentNullException("tokenId is a required property for GetAssetResponse and cannot be null");
            }
            this.TokenId = tokenId;
            // to ensure "tokenUri" is required (not null)
            if (tokenUri == null)
            {
                throw new ArgumentNullException("tokenUri is a required property for GetAssetResponse and cannot be null");
            }
            this.TokenUri = tokenUri;
            // to ensure "contract" is required (not null)
            if (contract == null)
            {
                throw new ArgumentNullException("contract is a required property for GetAssetResponse and cannot be null");
            }
            this.Contract = contract;
            this.Description = description;
            this.MintedAt = mintedAt;
            this.StandardImageUrl = standardImageUrl;
            this.ThumbnailImageUrl = thumbnailImageUrl;
            this.YoutubeUrl = youtubeUrl;
            this.BackgroundColor = backgroundColor;
            this.ExternalUrl = externalUrl;
            this.Rarity = rarity;
            this.RarityScore = rarityScore;
            this.NormalizedRarityScore = normalizedRarityScore;
            this.LastSoldTokenAmount = lastSoldTokenAmount;
            this.LastSoldTokenCurrency = lastSoldTokenCurrency;
            this.IndexerDataSyncedAt = indexerDataSyncedAt;
            this.Attributes = attributes;
            this.Listing = listing;
            this.OwnershipByAddresses = ownershipByAddresses;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "_id", IsRequired = true, EmitDefaultValue = true)]
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
        public decimal ChainId { get; set; }

        /// <summary>
        /// Gets or Sets ContractAddress
        /// </summary>
        [DataMember(Name = "contractAddress", IsRequired = true, EmitDefaultValue = true)]
        public string ContractAddress { get; set; }

        /// <summary>
        /// Gets or Sets TokenId
        /// </summary>
        [DataMember(Name = "tokenId", IsRequired = true, EmitDefaultValue = true)]
        public string TokenId { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets MintedAt
        /// </summary>
        [DataMember(Name = "mintedAt", EmitDefaultValue = true)]
        public string MintedAt { get; set; }

        /// <summary>
        /// Gets or Sets StandardImageUrl
        /// </summary>
        [DataMember(Name = "standardImageUrl", EmitDefaultValue = true)]
        public string StandardImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets ThumbnailImageUrl
        /// </summary>
        [DataMember(Name = "thumbnailImageUrl", EmitDefaultValue = true)]
        public string ThumbnailImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets YoutubeUrl
        /// </summary>
        [DataMember(Name = "youtubeUrl", EmitDefaultValue = true)]
        public string YoutubeUrl { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundColor
        /// </summary>
        [DataMember(Name = "backgroundColor", EmitDefaultValue = true)]
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Gets or Sets ExternalUrl
        /// </summary>
        [DataMember(Name = "externalUrl", EmitDefaultValue = true)]
        public string ExternalUrl { get; set; }

        /// <summary>
        /// Gets or Sets TokenUri
        /// </summary>
        [DataMember(Name = "tokenUri", IsRequired = true, EmitDefaultValue = true)]
        public string TokenUri { get; set; }

        /// <summary>
        /// Gets or Sets RarityScore
        /// </summary>
        [DataMember(Name = "rarityScore", EmitDefaultValue = true)]
        public decimal? RarityScore { get; set; }

        /// <summary>
        /// Gets or Sets NormalizedRarityScore
        /// </summary>
        [DataMember(Name = "normalizedRarityScore", EmitDefaultValue = true)]
        public decimal? NormalizedRarityScore { get; set; }

        /// <summary>
        /// Gets or Sets LastSoldTokenAmount
        /// </summary>
        [DataMember(Name = "lastSoldTokenAmount", EmitDefaultValue = true)]
        public string LastSoldTokenAmount { get; set; }

        /// <summary>
        /// Gets or Sets IndexerDataSyncedAt
        /// </summary>
        [DataMember(Name = "indexerDataSyncedAt", EmitDefaultValue = true)]
        public string IndexerDataSyncedAt { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", EmitDefaultValue = true)]
        public List<GetAssetsResponseDataInnerAttributesInner> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets Contract
        /// </summary>
        [DataMember(Name = "contract", IsRequired = true, EmitDefaultValue = true)]
        public GetAssetResponseContract Contract { get; set; }

        /// <summary>
        /// Gets or Sets Listing
        /// </summary>
        [DataMember(Name = "listing", EmitDefaultValue = true)]
        public GetAssetResponseListing Listing { get; set; }

        /// <summary>
        /// Gets or Sets OwnershipByAddresses
        /// </summary>
        [DataMember(Name = "ownershipByAddresses", EmitDefaultValue = true)]
        public List<GetAssetResponseOwnershipByAddressesInner> OwnershipByAddresses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAssetResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  ContractAddress: ").Append(ContractAddress).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MintedAt: ").Append(MintedAt).Append("\n");
            sb.Append("  StandardImageUrl: ").Append(StandardImageUrl).Append("\n");
            sb.Append("  ThumbnailImageUrl: ").Append(ThumbnailImageUrl).Append("\n");
            sb.Append("  YoutubeUrl: ").Append(YoutubeUrl).Append("\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  ExternalUrl: ").Append(ExternalUrl).Append("\n");
            sb.Append("  TokenUri: ").Append(TokenUri).Append("\n");
            sb.Append("  Rarity: ").Append(Rarity).Append("\n");
            sb.Append("  RarityScore: ").Append(RarityScore).Append("\n");
            sb.Append("  NormalizedRarityScore: ").Append(NormalizedRarityScore).Append("\n");
            sb.Append("  LastSoldTokenAmount: ").Append(LastSoldTokenAmount).Append("\n");
            sb.Append("  LastSoldTokenCurrency: ").Append(LastSoldTokenCurrency).Append("\n");
            sb.Append("  IndexerDataSyncedAt: ").Append(IndexerDataSyncedAt).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  Listing: ").Append(Listing).Append("\n");
            sb.Append("  OwnershipByAddresses: ").Append(OwnershipByAddresses).Append("\n");
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
            return this.Equals(input as GetAssetResponse);
        }

        /// <summary>
        /// Returns true if GetAssetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAssetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAssetResponse input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Network == input.Network ||
                    this.Network.Equals(input.Network)
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
                ) && 
                (
                    this.ContractAddress == input.ContractAddress ||
                    (this.ContractAddress != null &&
                    this.ContractAddress.Equals(input.ContractAddress))
                ) && 
                (
                    this.TokenId == input.TokenId ||
                    (this.TokenId != null &&
                    this.TokenId.Equals(input.TokenId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.MintedAt == input.MintedAt ||
                    (this.MintedAt != null &&
                    this.MintedAt.Equals(input.MintedAt))
                ) && 
                (
                    this.StandardImageUrl == input.StandardImageUrl ||
                    (this.StandardImageUrl != null &&
                    this.StandardImageUrl.Equals(input.StandardImageUrl))
                ) && 
                (
                    this.ThumbnailImageUrl == input.ThumbnailImageUrl ||
                    (this.ThumbnailImageUrl != null &&
                    this.ThumbnailImageUrl.Equals(input.ThumbnailImageUrl))
                ) && 
                (
                    this.YoutubeUrl == input.YoutubeUrl ||
                    (this.YoutubeUrl != null &&
                    this.YoutubeUrl.Equals(input.YoutubeUrl))
                ) && 
                (
                    this.BackgroundColor == input.BackgroundColor ||
                    (this.BackgroundColor != null &&
                    this.BackgroundColor.Equals(input.BackgroundColor))
                ) && 
                (
                    this.ExternalUrl == input.ExternalUrl ||
                    (this.ExternalUrl != null &&
                    this.ExternalUrl.Equals(input.ExternalUrl))
                ) && 
                (
                    this.TokenUri == input.TokenUri ||
                    (this.TokenUri != null &&
                    this.TokenUri.Equals(input.TokenUri))
                ) && 
                (
                    this.Rarity == input.Rarity ||
                    this.Rarity.Equals(input.Rarity)
                ) && 
                (
                    this.RarityScore == input.RarityScore ||
                    (this.RarityScore != null &&
                    this.RarityScore.Equals(input.RarityScore))
                ) && 
                (
                    this.NormalizedRarityScore == input.NormalizedRarityScore ||
                    (this.NormalizedRarityScore != null &&
                    this.NormalizedRarityScore.Equals(input.NormalizedRarityScore))
                ) && 
                (
                    this.LastSoldTokenAmount == input.LastSoldTokenAmount ||
                    (this.LastSoldTokenAmount != null &&
                    this.LastSoldTokenAmount.Equals(input.LastSoldTokenAmount))
                ) && 
                (
                    this.LastSoldTokenCurrency == input.LastSoldTokenCurrency ||
                    this.LastSoldTokenCurrency.Equals(input.LastSoldTokenCurrency)
                ) && 
                (
                    this.IndexerDataSyncedAt == input.IndexerDataSyncedAt ||
                    (this.IndexerDataSyncedAt != null &&
                    this.IndexerDataSyncedAt.Equals(input.IndexerDataSyncedAt))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.Listing == input.Listing ||
                    (this.Listing != null &&
                    this.Listing.Equals(input.Listing))
                ) && 
                (
                    this.OwnershipByAddresses == input.OwnershipByAddresses ||
                    this.OwnershipByAddresses != null &&
                    input.OwnershipByAddresses != null &&
                    this.OwnershipByAddresses.SequenceEqual(input.OwnershipByAddresses)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Network.GetHashCode();
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                if (this.ContractAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ContractAddress.GetHashCode();
                }
                if (this.TokenId != null)
                {
                    hashCode = (hashCode * 59) + this.TokenId.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.MintedAt != null)
                {
                    hashCode = (hashCode * 59) + this.MintedAt.GetHashCode();
                }
                if (this.StandardImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.StandardImageUrl.GetHashCode();
                }
                if (this.ThumbnailImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ThumbnailImageUrl.GetHashCode();
                }
                if (this.YoutubeUrl != null)
                {
                    hashCode = (hashCode * 59) + this.YoutubeUrl.GetHashCode();
                }
                if (this.BackgroundColor != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundColor.GetHashCode();
                }
                if (this.ExternalUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalUrl.GetHashCode();
                }
                if (this.TokenUri != null)
                {
                    hashCode = (hashCode * 59) + this.TokenUri.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Rarity.GetHashCode();
                if (this.RarityScore != null)
                {
                    hashCode = (hashCode * 59) + this.RarityScore.GetHashCode();
                }
                if (this.NormalizedRarityScore != null)
                {
                    hashCode = (hashCode * 59) + this.NormalizedRarityScore.GetHashCode();
                }
                if (this.LastSoldTokenAmount != null)
                {
                    hashCode = (hashCode * 59) + this.LastSoldTokenAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LastSoldTokenCurrency.GetHashCode();
                if (this.IndexerDataSyncedAt != null)
                {
                    hashCode = (hashCode * 59) + this.IndexerDataSyncedAt.GetHashCode();
                }
                if (this.Attributes != null)
                {
                    hashCode = (hashCode * 59) + this.Attributes.GetHashCode();
                }
                if (this.Contract != null)
                {
                    hashCode = (hashCode * 59) + this.Contract.GetHashCode();
                }
                if (this.Listing != null)
                {
                    hashCode = (hashCode * 59) + this.Listing.GetHashCode();
                }
                if (this.OwnershipByAddresses != null)
                {
                    hashCode = (hashCode * 59) + this.OwnershipByAddresses.GetHashCode();
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
