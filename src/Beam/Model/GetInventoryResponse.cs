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
    /// GetInventoryResponse
    /// </summary>
    [DataContract(Name = "GetInventoryResponse")]
    public partial class GetInventoryResponse : IEquatable<GetInventoryResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetInventoryResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetInventoryResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetInventoryResponse" /> class.
        /// </summary>
        /// <param name="varObject">varObject (required).</param>
        /// <param name="nftAssets">nftAssets.</param>
        /// <param name="nativeAsset">nativeAsset.</param>
        /// <param name="tokenAssets">tokenAssets.</param>
        public GetInventoryResponse(string varObject = default(string), List<GetInventoryResponseNftAssetsInner> nftAssets = default(List<GetInventoryResponseNftAssetsInner>), GetInventoryResponseNftAssetsInner nativeAsset = default(GetInventoryResponseNftAssetsInner), List<GetInventoryResponseNftAssetsInner> tokenAssets = default(List<GetInventoryResponseNftAssetsInner>))
        {
            // to ensure "varObject" is required (not null)
            if (varObject == null)
            {
                throw new ArgumentNullException("varObject is a required property for GetInventoryResponse and cannot be null");
            }
            this.VarObject = varObject;
            this.NftAssets = nftAssets;
            this.NativeAsset = nativeAsset;
            this.TokenAssets = tokenAssets;
        }

        /// <summary>
        /// Gets or Sets VarObject
        /// </summary>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string VarObject { get; set; }

        /// <summary>
        /// Gets or Sets NftAssets
        /// </summary>
        [DataMember(Name = "nftAssets", EmitDefaultValue = false)]
        public List<GetInventoryResponseNftAssetsInner> NftAssets { get; set; }

        /// <summary>
        /// Gets or Sets NativeAsset
        /// </summary>
        [DataMember(Name = "nativeAsset", EmitDefaultValue = false)]
        public GetInventoryResponseNftAssetsInner NativeAsset { get; set; }

        /// <summary>
        /// Gets or Sets TokenAssets
        /// </summary>
        [DataMember(Name = "tokenAssets", EmitDefaultValue = false)]
        public List<GetInventoryResponseNftAssetsInner> TokenAssets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetInventoryResponse {\n");
            sb.Append("  VarObject: ").Append(VarObject).Append("\n");
            sb.Append("  NftAssets: ").Append(NftAssets).Append("\n");
            sb.Append("  NativeAsset: ").Append(NativeAsset).Append("\n");
            sb.Append("  TokenAssets: ").Append(TokenAssets).Append("\n");
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
            return this.Equals(input as GetInventoryResponse);
        }

        /// <summary>
        /// Returns true if GetInventoryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetInventoryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetInventoryResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VarObject == input.VarObject ||
                    (this.VarObject != null &&
                    this.VarObject.Equals(input.VarObject))
                ) && 
                (
                    this.NftAssets == input.NftAssets ||
                    this.NftAssets != null &&
                    input.NftAssets != null &&
                    this.NftAssets.SequenceEqual(input.NftAssets)
                ) && 
                (
                    this.NativeAsset == input.NativeAsset ||
                    (this.NativeAsset != null &&
                    this.NativeAsset.Equals(input.NativeAsset))
                ) && 
                (
                    this.TokenAssets == input.TokenAssets ||
                    this.TokenAssets != null &&
                    input.TokenAssets != null &&
                    this.TokenAssets.SequenceEqual(input.TokenAssets)
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
                if (this.VarObject != null)
                {
                    hashCode = (hashCode * 59) + this.VarObject.GetHashCode();
                }
                if (this.NftAssets != null)
                {
                    hashCode = (hashCode * 59) + this.NftAssets.GetHashCode();
                }
                if (this.NativeAsset != null)
                {
                    hashCode = (hashCode * 59) + this.NativeAsset.GetHashCode();
                }
                if (this.TokenAssets != null)
                {
                    hashCode = (hashCode * 59) + this.TokenAssets.GetHashCode();
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
