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
    /// GetAssetResponseOwnershipByAddressesInnerUserProfile
    /// </summary>
    [DataContract(Name = "GetAssetResponse_ownershipByAddresses_inner_user_profile")]
    public partial class GetAssetResponseOwnershipByAddressesInnerUserProfile : IEquatable<GetAssetResponseOwnershipByAddressesInnerUserProfile>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetResponseOwnershipByAddressesInnerUserProfile" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAssetResponseOwnershipByAddressesInnerUserProfile() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetResponseOwnershipByAddressesInnerUserProfile" /> class.
        /// </summary>
        /// <param name="bio">bio.</param>
        /// <param name="isVerified">isVerified (required).</param>
        /// <param name="profilePicture">profilePicture.</param>
        /// <param name="profilePictureUrl">profilePictureUrl.</param>
        /// <param name="telegram">telegram.</param>
        /// <param name="twitter">twitter.</param>
        /// <param name="website">website.</param>
        public GetAssetResponseOwnershipByAddressesInnerUserProfile(string bio = default(string), bool isVerified = default(bool), string profilePicture = default(string), string profilePictureUrl = default(string), string telegram = default(string), string twitter = default(string), string website = default(string))
        {
            this.IsVerified = isVerified;
            this.Bio = bio;
            this.ProfilePicture = profilePicture;
            this.ProfilePictureUrl = profilePictureUrl;
            this.Telegram = telegram;
            this.Twitter = twitter;
            this.Website = website;
        }

        /// <summary>
        /// Gets or Sets Bio
        /// </summary>
        [DataMember(Name = "bio", EmitDefaultValue = true)]
        public string Bio { get; set; }

        /// <summary>
        /// Gets or Sets IsVerified
        /// </summary>
        [DataMember(Name = "isVerified", IsRequired = true, EmitDefaultValue = true)]
        public bool IsVerified { get; set; }

        /// <summary>
        /// Gets or Sets ProfilePicture
        /// </summary>
        [DataMember(Name = "profilePicture", EmitDefaultValue = true)]
        public string ProfilePicture { get; set; }

        /// <summary>
        /// Gets or Sets ProfilePictureUrl
        /// </summary>
        [DataMember(Name = "profilePictureUrl", EmitDefaultValue = true)]
        public string ProfilePictureUrl { get; set; }

        /// <summary>
        /// Gets or Sets Telegram
        /// </summary>
        [DataMember(Name = "telegram", EmitDefaultValue = true)]
        public string Telegram { get; set; }

        /// <summary>
        /// Gets or Sets Twitter
        /// </summary>
        [DataMember(Name = "twitter", EmitDefaultValue = true)]
        public string Twitter { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name = "website", EmitDefaultValue = true)]
        public string Website { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAssetResponseOwnershipByAddressesInnerUserProfile {\n");
            sb.Append("  Bio: ").Append(Bio).Append("\n");
            sb.Append("  IsVerified: ").Append(IsVerified).Append("\n");
            sb.Append("  ProfilePicture: ").Append(ProfilePicture).Append("\n");
            sb.Append("  ProfilePictureUrl: ").Append(ProfilePictureUrl).Append("\n");
            sb.Append("  Telegram: ").Append(Telegram).Append("\n");
            sb.Append("  Twitter: ").Append(Twitter).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
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
            return this.Equals(input as GetAssetResponseOwnershipByAddressesInnerUserProfile);
        }

        /// <summary>
        /// Returns true if GetAssetResponseOwnershipByAddressesInnerUserProfile instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAssetResponseOwnershipByAddressesInnerUserProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAssetResponseOwnershipByAddressesInnerUserProfile input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Bio == input.Bio ||
                    (this.Bio != null &&
                    this.Bio.Equals(input.Bio))
                ) && 
                (
                    this.IsVerified == input.IsVerified ||
                    this.IsVerified.Equals(input.IsVerified)
                ) && 
                (
                    this.ProfilePicture == input.ProfilePicture ||
                    (this.ProfilePicture != null &&
                    this.ProfilePicture.Equals(input.ProfilePicture))
                ) && 
                (
                    this.ProfilePictureUrl == input.ProfilePictureUrl ||
                    (this.ProfilePictureUrl != null &&
                    this.ProfilePictureUrl.Equals(input.ProfilePictureUrl))
                ) && 
                (
                    this.Telegram == input.Telegram ||
                    (this.Telegram != null &&
                    this.Telegram.Equals(input.Telegram))
                ) && 
                (
                    this.Twitter == input.Twitter ||
                    (this.Twitter != null &&
                    this.Twitter.Equals(input.Twitter))
                ) && 
                (
                    this.Website == input.Website ||
                    (this.Website != null &&
                    this.Website.Equals(input.Website))
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
                if (this.Bio != null)
                {
                    hashCode = (hashCode * 59) + this.Bio.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsVerified.GetHashCode();
                if (this.ProfilePicture != null)
                {
                    hashCode = (hashCode * 59) + this.ProfilePicture.GetHashCode();
                }
                if (this.ProfilePictureUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ProfilePictureUrl.GetHashCode();
                }
                if (this.Telegram != null)
                {
                    hashCode = (hashCode * 59) + this.Telegram.GetHashCode();
                }
                if (this.Twitter != null)
                {
                    hashCode = (hashCode * 59) + this.Twitter.GetHashCode();
                }
                if (this.Website != null)
                {
                    hashCode = (hashCode * 59) + this.Website.GetHashCode();
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
