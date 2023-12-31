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
    /// GetAssetResponseOwnershipByAddressesInnerUser
    /// </summary>
    [DataContract(Name = "GetAssetResponse_ownershipByAddresses_inner_user")]
    public partial class GetAssetResponseOwnershipByAddressesInnerUser : IEquatable<GetAssetResponseOwnershipByAddressesInnerUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetResponseOwnershipByAddressesInnerUser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAssetResponseOwnershipByAddressesInnerUser() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetResponseOwnershipByAddressesInnerUser" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="isCreator">isCreator (required).</param>
        /// <param name="isRoyaltyOwner">isRoyaltyOwner.</param>
        /// <param name="username">username.</param>
        /// <param name="profile">profile.</param>
        public GetAssetResponseOwnershipByAddressesInnerUser(string id = default(string), bool isCreator = default(bool), bool? isRoyaltyOwner = default(bool?), string username = default(string), GetAssetResponseOwnershipByAddressesInnerUserProfile profile = default(GetAssetResponseOwnershipByAddressesInnerUserProfile))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for GetAssetResponseOwnershipByAddressesInnerUser and cannot be null");
            }
            this.Id = id;
            this.IsCreator = isCreator;
            this.IsRoyaltyOwner = isRoyaltyOwner;
            this.Username = username;
            this.Profile = profile;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "_id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IsCreator
        /// </summary>
        [DataMember(Name = "isCreator", IsRequired = true, EmitDefaultValue = true)]
        public bool IsCreator { get; set; }

        /// <summary>
        /// Gets or Sets IsRoyaltyOwner
        /// </summary>
        [DataMember(Name = "isRoyaltyOwner", EmitDefaultValue = true)]
        public bool? IsRoyaltyOwner { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", EmitDefaultValue = true)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name = "profile", EmitDefaultValue = true)]
        public GetAssetResponseOwnershipByAddressesInnerUserProfile Profile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAssetResponseOwnershipByAddressesInnerUser {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsCreator: ").Append(IsCreator).Append("\n");
            sb.Append("  IsRoyaltyOwner: ").Append(IsRoyaltyOwner).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
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
            return this.Equals(input as GetAssetResponseOwnershipByAddressesInnerUser);
        }

        /// <summary>
        /// Returns true if GetAssetResponseOwnershipByAddressesInnerUser instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAssetResponseOwnershipByAddressesInnerUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAssetResponseOwnershipByAddressesInnerUser input)
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
                    this.IsCreator == input.IsCreator ||
                    this.IsCreator.Equals(input.IsCreator)
                ) && 
                (
                    this.IsRoyaltyOwner == input.IsRoyaltyOwner ||
                    (this.IsRoyaltyOwner != null &&
                    this.IsRoyaltyOwner.Equals(input.IsRoyaltyOwner))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
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
                hashCode = (hashCode * 59) + this.IsCreator.GetHashCode();
                if (this.IsRoyaltyOwner != null)
                {
                    hashCode = (hashCode * 59) + this.IsRoyaltyOwner.GetHashCode();
                }
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
                }
                if (this.Profile != null)
                {
                    hashCode = (hashCode * 59) + this.Profile.GetHashCode();
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
