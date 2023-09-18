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
    /// GetAssetResponseOwnershipByAddressesInner
    /// </summary>
    [DataContract(Name = "GetAssetResponse_ownershipByAddresses_inner")]
    public partial class GetAssetResponseOwnershipByAddressesInner : IEquatable<GetAssetResponseOwnershipByAddressesInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetResponseOwnershipByAddressesInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAssetResponseOwnershipByAddressesInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetResponseOwnershipByAddressesInner" /> class.
        /// </summary>
        /// <param name="address">address (required).</param>
        /// <param name="quantity">quantity (required).</param>
        /// <param name="user">user (required).</param>
        public GetAssetResponseOwnershipByAddressesInner(string address = default(string), decimal quantity = default(decimal), GetAssetResponseOwnershipByAddressesInnerUser user = default(GetAssetResponseOwnershipByAddressesInnerUser))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for GetAssetResponseOwnershipByAddressesInner and cannot be null");
            }
            this.Address = address;
            this.Quantity = quantity;
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new ArgumentNullException("user is a required property for GetAssetResponseOwnershipByAddressesInner and cannot be null");
            }
            this.User = user;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", IsRequired = true, EmitDefaultValue = true)]
        public GetAssetResponseOwnershipByAddressesInnerUser User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAssetResponseOwnershipByAddressesInner {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as GetAssetResponseOwnershipByAddressesInner);
        }

        /// <summary>
        /// Returns true if GetAssetResponseOwnershipByAddressesInner instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAssetResponseOwnershipByAddressesInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAssetResponseOwnershipByAddressesInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                if (this.User != null)
                {
                    hashCode = (hashCode * 59) + this.User.GetHashCode();
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