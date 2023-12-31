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
    /// RegenerateGameApiKeysResponse
    /// </summary>
    [DataContract(Name = "RegenerateGameApiKeysResponse")]
    public partial class RegenerateGameApiKeysResponse : IEquatable<RegenerateGameApiKeysResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegenerateGameApiKeysResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RegenerateGameApiKeysResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegenerateGameApiKeysResponse" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="coverImageUrl">coverImageUrl (required).</param>
        /// <param name="logoImageUrl">logoImageUrl (required).</param>
        /// <param name="chainIds">chainIds (required).</param>
        /// <param name="apiKeys">apiKeys (required).</param>
        public RegenerateGameApiKeysResponse(string id = default(string), Object createdAt = default(Object), Object updatedAt = default(Object), string name = default(string), string description = default(string), string coverImageUrl = default(string), string logoImageUrl = default(string), List<int> chainIds = default(List<int>), List<RegenerateGameApiKeysResponseApiKeysInner> apiKeys = default(List<RegenerateGameApiKeysResponseApiKeysInner>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for RegenerateGameApiKeysResponse and cannot be null");
            }
            this.Id = id;
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new ArgumentNullException("createdAt is a required property for RegenerateGameApiKeysResponse and cannot be null");
            }
            this.CreatedAt = createdAt;
            // to ensure "updatedAt" is required (not null)
            if (updatedAt == null)
            {
                throw new ArgumentNullException("updatedAt is a required property for RegenerateGameApiKeysResponse and cannot be null");
            }
            this.UpdatedAt = updatedAt;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for RegenerateGameApiKeysResponse and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for RegenerateGameApiKeysResponse and cannot be null");
            }
            this.Description = description;
            // to ensure "coverImageUrl" is required (not null)
            if (coverImageUrl == null)
            {
                throw new ArgumentNullException("coverImageUrl is a required property for RegenerateGameApiKeysResponse and cannot be null");
            }
            this.CoverImageUrl = coverImageUrl;
            // to ensure "logoImageUrl" is required (not null)
            if (logoImageUrl == null)
            {
                throw new ArgumentNullException("logoImageUrl is a required property for RegenerateGameApiKeysResponse and cannot be null");
            }
            this.LogoImageUrl = logoImageUrl;
            // to ensure "chainIds" is required (not null)
            if (chainIds == null)
            {
                throw new ArgumentNullException("chainIds is a required property for RegenerateGameApiKeysResponse and cannot be null");
            }
            this.ChainIds = chainIds;
            // to ensure "apiKeys" is required (not null)
            if (apiKeys == null)
            {
                throw new ArgumentNullException("apiKeys is a required property for RegenerateGameApiKeysResponse and cannot be null");
            }
            this.ApiKeys = apiKeys;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public Object CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public Object UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets CoverImageUrl
        /// </summary>
        [DataMember(Name = "coverImageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string CoverImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets LogoImageUrl
        /// </summary>
        [DataMember(Name = "logoImageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string LogoImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets ChainIds
        /// </summary>
        [DataMember(Name = "chainIds", IsRequired = true, EmitDefaultValue = true)]
        public List<int> ChainIds { get; set; }

        /// <summary>
        /// Gets or Sets ApiKeys
        /// </summary>
        [DataMember(Name = "apiKeys", IsRequired = true, EmitDefaultValue = true)]
        public List<RegenerateGameApiKeysResponseApiKeysInner> ApiKeys { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RegenerateGameApiKeysResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CoverImageUrl: ").Append(CoverImageUrl).Append("\n");
            sb.Append("  LogoImageUrl: ").Append(LogoImageUrl).Append("\n");
            sb.Append("  ChainIds: ").Append(ChainIds).Append("\n");
            sb.Append("  ApiKeys: ").Append(ApiKeys).Append("\n");
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
            return this.Equals(input as RegenerateGameApiKeysResponse);
        }

        /// <summary>
        /// Returns true if RegenerateGameApiKeysResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RegenerateGameApiKeysResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegenerateGameApiKeysResponse input)
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
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CoverImageUrl == input.CoverImageUrl ||
                    (this.CoverImageUrl != null &&
                    this.CoverImageUrl.Equals(input.CoverImageUrl))
                ) && 
                (
                    this.LogoImageUrl == input.LogoImageUrl ||
                    (this.LogoImageUrl != null &&
                    this.LogoImageUrl.Equals(input.LogoImageUrl))
                ) && 
                (
                    this.ChainIds == input.ChainIds ||
                    this.ChainIds != null &&
                    input.ChainIds != null &&
                    this.ChainIds.SequenceEqual(input.ChainIds)
                ) && 
                (
                    this.ApiKeys == input.ApiKeys ||
                    this.ApiKeys != null &&
                    input.ApiKeys != null &&
                    this.ApiKeys.SequenceEqual(input.ApiKeys)
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
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.CoverImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CoverImageUrl.GetHashCode();
                }
                if (this.LogoImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LogoImageUrl.GetHashCode();
                }
                if (this.ChainIds != null)
                {
                    hashCode = (hashCode * 59) + this.ChainIds.GetHashCode();
                }
                if (this.ApiKeys != null)
                {
                    hashCode = (hashCode * 59) + this.ApiKeys.GetHashCode();
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
