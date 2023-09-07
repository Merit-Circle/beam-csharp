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
    /// GetAssetResponseContract
    /// </summary>
    [DataContract(Name = "GetAssetResponse_contract")]
    public partial class GetAssetResponseContract : IEquatable<GetAssetResponseContract>, IValidatableObject
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
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum ERC721 for value: ERC721
            /// </summary>
            [EnumMember(Value = "ERC721")]
            ERC721 = 1,

            /// <summary>
            /// Enum ERC1155 for value: ERC1155
            /// </summary>
            [EnumMember(Value = "ERC1155")]
            ERC1155 = 2
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Defines Symbol
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SymbolEnum
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
            /// Enum Wavax for value: Wavax
            /// </summary>
            [EnumMember(Value = "Wavax")]
            Wavax = 6,

            /// <summary>
            /// Enum Weth for value: Weth
            /// </summary>
            [EnumMember(Value = "Weth")]
            Weth = 7,

            /// <summary>
            /// Enum Wmatic for value: Wmatic
            /// </summary>
            [EnumMember(Value = "Wmatic")]
            Wmatic = 8,

            /// <summary>
            /// Enum Wmc for value: Wmc
            /// </summary>
            [EnumMember(Value = "Wmc")]
            Wmc = 9
        }


        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = true)]
        public SymbolEnum Symbol { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetResponseContract" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAssetResponseContract() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetResponseContract" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="chainId">chainId (required).</param>
        /// <param name="address">address (required).</param>
        /// <param name="network">network (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="slug">slug (required).</param>
        /// <param name="description">description.</param>
        /// <param name="symbol">symbol (required).</param>
        /// <param name="royalty">royalty.</param>
        /// <param name="royaltyAddress">royaltyAddress.</param>
        /// <param name="avatar">avatar (required).</param>
        /// <param name="header">header (required).</param>
        public GetAssetResponseContract(string id = default(string), decimal chainId = default(decimal), string address = default(string), NetworkEnum network = default(NetworkEnum), TypeEnum type = default(TypeEnum), string name = default(string), string slug = default(string), string description = default(string), SymbolEnum symbol = default(SymbolEnum), decimal? royalty = default(decimal?), string royaltyAddress = default(string), GetAssetResponseContractAvatar avatar = default(GetAssetResponseContractAvatar), GetAssetResponseContractHeader header = default(GetAssetResponseContractHeader))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for GetAssetResponseContract and cannot be null");
            }
            this.Id = id;
            this.ChainId = chainId;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for GetAssetResponseContract and cannot be null");
            }
            this.Address = address;
            this.Network = network;
            this.Type = type;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for GetAssetResponseContract and cannot be null");
            }
            this.Name = name;
            // to ensure "slug" is required (not null)
            if (slug == null)
            {
                throw new ArgumentNullException("slug is a required property for GetAssetResponseContract and cannot be null");
            }
            this.Slug = slug;
            this.Symbol = symbol;
            // to ensure "avatar" is required (not null)
            if (avatar == null)
            {
                throw new ArgumentNullException("avatar is a required property for GetAssetResponseContract and cannot be null");
            }
            this.Avatar = avatar;
            // to ensure "header" is required (not null)
            if (header == null)
            {
                throw new ArgumentNullException("header is a required property for GetAssetResponseContract and cannot be null");
            }
            this.Header = header;
            this.Description = description;
            this.Royalty = royalty;
            this.RoyaltyAddress = royaltyAddress;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "_id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [DataMember(Name = "chainId", IsRequired = true, EmitDefaultValue = true)]
        public decimal ChainId { get; set; }

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
        /// Gets or Sets Slug
        /// </summary>
        [DataMember(Name = "slug", IsRequired = true, EmitDefaultValue = true)]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Royalty
        /// </summary>
        [DataMember(Name = "royalty", EmitDefaultValue = true)]
        public decimal? Royalty { get; set; }

        /// <summary>
        /// Gets or Sets RoyaltyAddress
        /// </summary>
        [DataMember(Name = "royaltyAddress", EmitDefaultValue = true)]
        public string RoyaltyAddress { get; set; }

        /// <summary>
        /// Gets or Sets Avatar
        /// </summary>
        [DataMember(Name = "avatar", IsRequired = true, EmitDefaultValue = true)]
        public GetAssetResponseContractAvatar Avatar { get; set; }

        /// <summary>
        /// Gets or Sets Header
        /// </summary>
        [DataMember(Name = "header", IsRequired = true, EmitDefaultValue = true)]
        public GetAssetResponseContractHeader Header { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAssetResponseContract {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Royalty: ").Append(Royalty).Append("\n");
            sb.Append("  RoyaltyAddress: ").Append(RoyaltyAddress).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
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
            return this.Equals(input as GetAssetResponseContract);
        }

        /// <summary>
        /// Returns true if GetAssetResponseContract instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAssetResponseContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAssetResponseContract input)
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
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Network == input.Network ||
                    this.Network.Equals(input.Network)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    this.Symbol.Equals(input.Symbol)
                ) && 
                (
                    this.Royalty == input.Royalty ||
                    (this.Royalty != null &&
                    this.Royalty.Equals(input.Royalty))
                ) && 
                (
                    this.RoyaltyAddress == input.RoyaltyAddress ||
                    (this.RoyaltyAddress != null &&
                    this.RoyaltyAddress.Equals(input.RoyaltyAddress))
                ) && 
                (
                    this.Avatar == input.Avatar ||
                    (this.Avatar != null &&
                    this.Avatar.Equals(input.Avatar))
                ) && 
                (
                    this.Header == input.Header ||
                    (this.Header != null &&
                    this.Header.Equals(input.Header))
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
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Network.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Slug != null)
                {
                    hashCode = (hashCode * 59) + this.Slug.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                if (this.Royalty != null)
                {
                    hashCode = (hashCode * 59) + this.Royalty.GetHashCode();
                }
                if (this.RoyaltyAddress != null)
                {
                    hashCode = (hashCode * 59) + this.RoyaltyAddress.GetHashCode();
                }
                if (this.Avatar != null)
                {
                    hashCode = (hashCode * 59) + this.Avatar.GetHashCode();
                }
                if (this.Header != null)
                {
                    hashCode = (hashCode * 59) + this.Header.GetHashCode();
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
