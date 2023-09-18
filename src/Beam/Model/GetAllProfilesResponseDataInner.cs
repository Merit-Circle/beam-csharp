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
    /// GetAllProfilesResponseDataInner
    /// </summary>
    [DataContract(Name = "GetAllProfilesResponse_data_inner")]
    public partial class GetAllProfilesResponseDataInner : IEquatable<GetAllProfilesResponseDataInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllProfilesResponseDataInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAllProfilesResponseDataInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllProfilesResponseDataInner" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="gameId">gameId (required).</param>
        /// <param name="externalId">externalId (required).</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="userConnectionCreatedAt">userConnectionCreatedAt (required).</param>
        /// <param name="wallets">wallets (required).</param>
        public GetAllProfilesResponseDataInner(string id = default(string), string gameId = default(string), string externalId = default(string), string userId = default(string), Object userConnectionCreatedAt = default(Object), List<CreateProfileResponseWalletsInner> wallets = default(List<CreateProfileResponseWalletsInner>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for GetAllProfilesResponseDataInner and cannot be null");
            }
            this.Id = id;
            // to ensure "gameId" is required (not null)
            if (gameId == null)
            {
                throw new ArgumentNullException("gameId is a required property for GetAllProfilesResponseDataInner and cannot be null");
            }
            this.GameId = gameId;
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new ArgumentNullException("externalId is a required property for GetAllProfilesResponseDataInner and cannot be null");
            }
            this.ExternalId = externalId;
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new ArgumentNullException("userId is a required property for GetAllProfilesResponseDataInner and cannot be null");
            }
            this.UserId = userId;
            // to ensure "userConnectionCreatedAt" is required (not null)
            if (userConnectionCreatedAt == null)
            {
                throw new ArgumentNullException("userConnectionCreatedAt is a required property for GetAllProfilesResponseDataInner and cannot be null");
            }
            this.UserConnectionCreatedAt = userConnectionCreatedAt;
            // to ensure "wallets" is required (not null)
            if (wallets == null)
            {
                throw new ArgumentNullException("wallets is a required property for GetAllProfilesResponseDataInner and cannot be null");
            }
            this.Wallets = wallets;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name = "gameId", IsRequired = true, EmitDefaultValue = true)]
        public string GameId { get; set; }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name = "externalId", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets UserConnectionCreatedAt
        /// </summary>
        [DataMember(Name = "userConnectionCreatedAt", IsRequired = true, EmitDefaultValue = true)]
        public Object UserConnectionCreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Wallets
        /// </summary>
        [DataMember(Name = "wallets", IsRequired = true, EmitDefaultValue = true)]
        public List<CreateProfileResponseWalletsInner> Wallets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAllProfilesResponseDataInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserConnectionCreatedAt: ").Append(UserConnectionCreatedAt).Append("\n");
            sb.Append("  Wallets: ").Append(Wallets).Append("\n");
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
            return this.Equals(input as GetAllProfilesResponseDataInner);
        }

        /// <summary>
        /// Returns true if GetAllProfilesResponseDataInner instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAllProfilesResponseDataInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAllProfilesResponseDataInner input)
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
                    this.GameId == input.GameId ||
                    (this.GameId != null &&
                    this.GameId.Equals(input.GameId))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserConnectionCreatedAt == input.UserConnectionCreatedAt ||
                    (this.UserConnectionCreatedAt != null &&
                    this.UserConnectionCreatedAt.Equals(input.UserConnectionCreatedAt))
                ) && 
                (
                    this.Wallets == input.Wallets ||
                    this.Wallets != null &&
                    input.Wallets != null &&
                    this.Wallets.SequenceEqual(input.Wallets)
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
                if (this.GameId != null)
                {
                    hashCode = (hashCode * 59) + this.GameId.GetHashCode();
                }
                if (this.ExternalId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalId.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.UserConnectionCreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UserConnectionCreatedAt.GetHashCode();
                }
                if (this.Wallets != null)
                {
                    hashCode = (hashCode * 59) + this.Wallets.GetHashCode();
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
