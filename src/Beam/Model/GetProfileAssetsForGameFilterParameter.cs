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
    /// GetProfileAssetsForGameFilterParameter
    /// </summary>
    [DataContract(Name = "getProfileAssetsForGame_filter_parameter")]
    public partial class GetProfileAssetsForGameFilterParameter : IEquatable<GetProfileAssetsForGameFilterParameter>, IValidatableObject
    {
        /// <summary>
        /// Defines SellTypes
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SellTypesEnum
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
        /// Defines Currencies
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CurrenciesEnum
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
        /// Defines Rarities
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RaritiesEnum
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
        /// Initializes a new instance of the <see cref="GetProfileAssetsForGameFilterParameter" /> class.
        /// </summary>
        /// <param name="attributes">attributes.</param>
        /// <param name="sellTypes">sellTypes.</param>
        /// <param name="currencies">currencies.</param>
        /// <param name="rarities">rarities.</param>
        public GetProfileAssetsForGameFilterParameter(List<GetProfileAssetsForGameFilterParameterAttributesInner> attributes = default(List<GetProfileAssetsForGameFilterParameterAttributesInner>), List<SellTypesEnum> sellTypes = default(List<SellTypesEnum>), List<CurrenciesEnum> currencies = default(List<CurrenciesEnum>), List<RaritiesEnum> rarities = default(List<RaritiesEnum>))
        {
            this.Attributes = attributes;
            this.SellTypes = sellTypes;
            this.Currencies = currencies;
            this.Rarities = rarities;
        }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", EmitDefaultValue = true)]
        public List<GetProfileAssetsForGameFilterParameterAttributesInner> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets SellTypes
        /// </summary>
        [DataMember(Name = "sellTypes", EmitDefaultValue = true)]
        public List<GetProfileAssetsForGameFilterParameter.SellTypesEnum> SellTypes { get; set; }

        /// <summary>
        /// Gets or Sets Currencies
        /// </summary>
        [DataMember(Name = "currencies", EmitDefaultValue = true)]
        public List<GetProfileAssetsForGameFilterParameter.CurrenciesEnum> Currencies { get; set; }

        /// <summary>
        /// Gets or Sets Rarities
        /// </summary>
        [DataMember(Name = "rarities", EmitDefaultValue = true)]
        public List<GetProfileAssetsForGameFilterParameter.RaritiesEnum> Rarities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetProfileAssetsForGameFilterParameter {\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  SellTypes: ").Append(SellTypes).Append("\n");
            sb.Append("  Currencies: ").Append(Currencies).Append("\n");
            sb.Append("  Rarities: ").Append(Rarities).Append("\n");
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
            return this.Equals(input as GetProfileAssetsForGameFilterParameter);
        }

        /// <summary>
        /// Returns true if GetProfileAssetsForGameFilterParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of GetProfileAssetsForGameFilterParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetProfileAssetsForGameFilterParameter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.SellTypes == input.SellTypes ||
                    this.SellTypes != null &&
                    input.SellTypes != null &&
                    this.SellTypes.SequenceEqual(input.SellTypes)
                ) && 
                (
                    this.Currencies == input.Currencies ||
                    this.Currencies != null &&
                    input.Currencies != null &&
                    this.Currencies.SequenceEqual(input.Currencies)
                ) && 
                (
                    this.Rarities == input.Rarities ||
                    this.Rarities != null &&
                    input.Rarities != null &&
                    this.Rarities.SequenceEqual(input.Rarities)
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
                if (this.Attributes != null)
                {
                    hashCode = (hashCode * 59) + this.Attributes.GetHashCode();
                }
                if (this.SellTypes != null)
                {
                    hashCode = (hashCode * 59) + this.SellTypes.GetHashCode();
                }
                if (this.Currencies != null)
                {
                    hashCode = (hashCode * 59) + this.Currencies.GetHashCode();
                }
                if (this.Rarities != null)
                {
                    hashCode = (hashCode * 59) + this.Rarities.GetHashCode();
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
