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
    /// GetGameResponse
    /// </summary>
    [DataContract(Name = "GetGameResponse")]
    public partial class GetGameResponse : IEquatable<GetGameResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetGameResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetGameResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetGameResponse" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="coverImageUrl">coverImageUrl (required).</param>
        /// <param name="contracts">contracts (required).</param>
        /// <param name="policies">policies (required).</param>
        public GetGameResponse(string id = default(string), string name = default(string), string description = default(string), string coverImageUrl = default(string), List<GetGameResponseContractsInner> contracts = default(List<GetGameResponseContractsInner>), List<GetGameResponsePoliciesInner> policies = default(List<GetGameResponsePoliciesInner>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for GetGameResponse and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for GetGameResponse and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for GetGameResponse and cannot be null");
            }
            this.Description = description;
            // to ensure "coverImageUrl" is required (not null)
            if (coverImageUrl == null)
            {
                throw new ArgumentNullException("coverImageUrl is a required property for GetGameResponse and cannot be null");
            }
            this.CoverImageUrl = coverImageUrl;
            // to ensure "contracts" is required (not null)
            if (contracts == null)
            {
                throw new ArgumentNullException("contracts is a required property for GetGameResponse and cannot be null");
            }
            this.Contracts = contracts;
            // to ensure "policies" is required (not null)
            if (policies == null)
            {
                throw new ArgumentNullException("policies is a required property for GetGameResponse and cannot be null");
            }
            this.Policies = policies;
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
        /// Gets or Sets Contracts
        /// </summary>
        [DataMember(Name = "contracts", IsRequired = true, EmitDefaultValue = true)]
        public List<GetGameResponseContractsInner> Contracts { get; set; }

        /// <summary>
        /// Gets or Sets Policies
        /// </summary>
        [DataMember(Name = "policies", IsRequired = true, EmitDefaultValue = true)]
        public List<GetGameResponsePoliciesInner> Policies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetGameResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CoverImageUrl: ").Append(CoverImageUrl).Append("\n");
            sb.Append("  Contracts: ").Append(Contracts).Append("\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
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
            return this.Equals(input as GetGameResponse);
        }

        /// <summary>
        /// Returns true if GetGameResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetGameResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetGameResponse input)
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
                    this.Contracts == input.Contracts ||
                    this.Contracts != null &&
                    input.Contracts != null &&
                    this.Contracts.SequenceEqual(input.Contracts)
                ) && 
                (
                    this.Policies == input.Policies ||
                    this.Policies != null &&
                    input.Policies != null &&
                    this.Policies.SequenceEqual(input.Policies)
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.CoverImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CoverImageUrl.GetHashCode();
                }
                if (this.Contracts != null)
                {
                    hashCode = (hashCode * 59) + this.Contracts.GetHashCode();
                }
                if (this.Policies != null)
                {
                    hashCode = (hashCode * 59) + this.Policies.GetHashCode();
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
