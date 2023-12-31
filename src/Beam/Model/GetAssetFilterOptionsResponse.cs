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
    /// GetAssetFilterOptionsResponse
    /// </summary>
    [DataContract(Name = "GetAssetFilterOptionsResponse")]
    public partial class GetAssetFilterOptionsResponse : IEquatable<GetAssetFilterOptionsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetFilterOptionsResponse" /> class.
        /// </summary>
        /// <param name="attributeValues">attributeValues.</param>
        /// <param name="attributeTypes">attributeTypes.</param>
        /// <param name="rarities">rarities.</param>
        /// <param name="currencies">currencies.</param>
        /// <param name="sellTypes">sellTypes.</param>
        public GetAssetFilterOptionsResponse(GetAssetFilterOptionsResponseAttributeValues attributeValues = default(GetAssetFilterOptionsResponseAttributeValues), GetAssetFilterOptionsResponseAttributeValues attributeTypes = default(GetAssetFilterOptionsResponseAttributeValues), GetAssetFilterOptionsResponseAttributeValues rarities = default(GetAssetFilterOptionsResponseAttributeValues), GetAssetFilterOptionsResponseAttributeValues currencies = default(GetAssetFilterOptionsResponseAttributeValues), GetAssetFilterOptionsResponseAttributeValues sellTypes = default(GetAssetFilterOptionsResponseAttributeValues))
        {
            this.AttributeValues = attributeValues;
            this.AttributeTypes = attributeTypes;
            this.Rarities = rarities;
            this.Currencies = currencies;
            this.SellTypes = sellTypes;
        }

        /// <summary>
        /// Gets or Sets AttributeValues
        /// </summary>
        [DataMember(Name = "attributeValues", EmitDefaultValue = true)]
        public GetAssetFilterOptionsResponseAttributeValues AttributeValues { get; set; }

        /// <summary>
        /// Gets or Sets AttributeTypes
        /// </summary>
        [DataMember(Name = "attributeTypes", EmitDefaultValue = true)]
        public GetAssetFilterOptionsResponseAttributeValues AttributeTypes { get; set; }

        /// <summary>
        /// Gets or Sets Rarities
        /// </summary>
        [DataMember(Name = "rarities", EmitDefaultValue = true)]
        public GetAssetFilterOptionsResponseAttributeValues Rarities { get; set; }

        /// <summary>
        /// Gets or Sets Currencies
        /// </summary>
        [DataMember(Name = "currencies", EmitDefaultValue = true)]
        public GetAssetFilterOptionsResponseAttributeValues Currencies { get; set; }

        /// <summary>
        /// Gets or Sets SellTypes
        /// </summary>
        [DataMember(Name = "sellTypes", EmitDefaultValue = true)]
        public GetAssetFilterOptionsResponseAttributeValues SellTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAssetFilterOptionsResponse {\n");
            sb.Append("  AttributeValues: ").Append(AttributeValues).Append("\n");
            sb.Append("  AttributeTypes: ").Append(AttributeTypes).Append("\n");
            sb.Append("  Rarities: ").Append(Rarities).Append("\n");
            sb.Append("  Currencies: ").Append(Currencies).Append("\n");
            sb.Append("  SellTypes: ").Append(SellTypes).Append("\n");
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
            return this.Equals(input as GetAssetFilterOptionsResponse);
        }

        /// <summary>
        /// Returns true if GetAssetFilterOptionsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAssetFilterOptionsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAssetFilterOptionsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AttributeValues == input.AttributeValues ||
                    (this.AttributeValues != null &&
                    this.AttributeValues.Equals(input.AttributeValues))
                ) && 
                (
                    this.AttributeTypes == input.AttributeTypes ||
                    (this.AttributeTypes != null &&
                    this.AttributeTypes.Equals(input.AttributeTypes))
                ) && 
                (
                    this.Rarities == input.Rarities ||
                    (this.Rarities != null &&
                    this.Rarities.Equals(input.Rarities))
                ) && 
                (
                    this.Currencies == input.Currencies ||
                    (this.Currencies != null &&
                    this.Currencies.Equals(input.Currencies))
                ) && 
                (
                    this.SellTypes == input.SellTypes ||
                    (this.SellTypes != null &&
                    this.SellTypes.Equals(input.SellTypes))
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
                if (this.AttributeValues != null)
                {
                    hashCode = (hashCode * 59) + this.AttributeValues.GetHashCode();
                }
                if (this.AttributeTypes != null)
                {
                    hashCode = (hashCode * 59) + this.AttributeTypes.GetHashCode();
                }
                if (this.Rarities != null)
                {
                    hashCode = (hashCode * 59) + this.Rarities.GetHashCode();
                }
                if (this.Currencies != null)
                {
                    hashCode = (hashCode * 59) + this.Currencies.GetHashCode();
                }
                if (this.SellTypes != null)
                {
                    hashCode = (hashCode * 59) + this.SellTypes.GetHashCode();
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
