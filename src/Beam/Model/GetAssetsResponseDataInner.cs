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
    /// GetAssetsResponseDataInner
    /// </summary>
    [DataContract(Name = "GetAssetsResponse_data_inner")]
    public partial class GetAssetsResponseDataInner : IEquatable<GetAssetsResponseDataInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetsResponseDataInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAssetsResponseDataInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetsResponseDataInner" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="imageUrl">imageUrl (required).</param>
        /// <param name="assetType">assetType (required).</param>
        /// <param name="assetAddress">assetAddress (required).</param>
        /// <param name="assetId">assetId (required).</param>
        /// <param name="quantity">quantity (required).</param>
        public GetAssetsResponseDataInner(string id = default(string), string name = default(string), string imageUrl = default(string), string assetType = default(string), string assetAddress = default(string), string assetId = default(string), decimal quantity = default(decimal))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for GetAssetsResponseDataInner and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for GetAssetsResponseDataInner and cannot be null");
            }
            this.Name = name;
            // to ensure "imageUrl" is required (not null)
            if (imageUrl == null)
            {
                throw new ArgumentNullException("imageUrl is a required property for GetAssetsResponseDataInner and cannot be null");
            }
            this.ImageUrl = imageUrl;
            // to ensure "assetType" is required (not null)
            if (assetType == null)
            {
                throw new ArgumentNullException("assetType is a required property for GetAssetsResponseDataInner and cannot be null");
            }
            this.AssetType = assetType;
            // to ensure "assetAddress" is required (not null)
            if (assetAddress == null)
            {
                throw new ArgumentNullException("assetAddress is a required property for GetAssetsResponseDataInner and cannot be null");
            }
            this.AssetAddress = assetAddress;
            // to ensure "assetId" is required (not null)
            if (assetId == null)
            {
                throw new ArgumentNullException("assetId is a required property for GetAssetsResponseDataInner and cannot be null");
            }
            this.AssetId = assetId;
            this.Quantity = quantity;
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
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "imageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets AssetType
        /// </summary>
        [DataMember(Name = "assetType", IsRequired = true, EmitDefaultValue = true)]
        public string AssetType { get; set; }

        /// <summary>
        /// Gets or Sets AssetAddress
        /// </summary>
        [DataMember(Name = "assetAddress", IsRequired = true, EmitDefaultValue = true)]
        public string AssetAddress { get; set; }

        /// <summary>
        /// Gets or Sets AssetId
        /// </summary>
        [DataMember(Name = "assetId", IsRequired = true, EmitDefaultValue = true)]
        public string AssetId { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAssetsResponseDataInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  AssetType: ").Append(AssetType).Append("\n");
            sb.Append("  AssetAddress: ").Append(AssetAddress).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(input as GetAssetsResponseDataInner);
        }

        /// <summary>
        /// Returns true if GetAssetsResponseDataInner instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAssetsResponseDataInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAssetsResponseDataInner input)
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
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.AssetType == input.AssetType ||
                    (this.AssetType != null &&
                    this.AssetType.Equals(input.AssetType))
                ) && 
                (
                    this.AssetAddress == input.AssetAddress ||
                    (this.AssetAddress != null &&
                    this.AssetAddress.Equals(input.AssetAddress))
                ) && 
                (
                    this.AssetId == input.AssetId ||
                    (this.AssetId != null &&
                    this.AssetId.Equals(input.AssetId))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
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
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
                }
                if (this.AssetType != null)
                {
                    hashCode = (hashCode * 59) + this.AssetType.GetHashCode();
                }
                if (this.AssetAddress != null)
                {
                    hashCode = (hashCode * 59) + this.AssetAddress.GetHashCode();
                }
                if (this.AssetId != null)
                {
                    hashCode = (hashCode * 59) + this.AssetId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
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
