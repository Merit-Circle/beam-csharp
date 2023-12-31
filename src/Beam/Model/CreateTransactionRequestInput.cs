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
    /// CreateTransactionRequestInput
    /// </summary>
    [DataContract(Name = "CreateTransactionRequestInput")]
    public partial class CreateTransactionRequestInput : IEquatable<CreateTransactionRequestInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransactionRequestInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTransactionRequestInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransactionRequestInput" /> class.
        /// </summary>
        /// <param name="interactions">interactions (required).</param>
        /// <param name="optimistic">optimistic (default to false).</param>
        /// <param name="sponsor">sponsor (default to true).</param>
        /// <param name="policyId">policyId.</param>
        /// <param name="chainId">chainId (default to 13337M).</param>
        public CreateTransactionRequestInput(List<CreateTransactionRequestInputInteractionsInner> interactions = default(List<CreateTransactionRequestInputInteractionsInner>), bool optimistic = false, bool sponsor = true, string policyId = default(string), decimal chainId = 13337M)
        {
            // to ensure "interactions" is required (not null)
            if (interactions == null)
            {
                throw new ArgumentNullException("interactions is a required property for CreateTransactionRequestInput and cannot be null");
            }
            this.Interactions = interactions;
            this.Optimistic = optimistic;
            this.Sponsor = sponsor;
            this.PolicyId = policyId;
            this.ChainId = chainId;
        }

        /// <summary>
        /// Gets or Sets Interactions
        /// </summary>
        [DataMember(Name = "interactions", IsRequired = true, EmitDefaultValue = true)]
        public List<CreateTransactionRequestInputInteractionsInner> Interactions { get; set; }

        /// <summary>
        /// Gets or Sets Optimistic
        /// </summary>
        [DataMember(Name = "optimistic", EmitDefaultValue = true)]
        public bool Optimistic { get; set; }

        /// <summary>
        /// Gets or Sets Sponsor
        /// </summary>
        [DataMember(Name = "sponsor", EmitDefaultValue = true)]
        public bool Sponsor { get; set; }

        /// <summary>
        /// Gets or Sets PolicyId
        /// </summary>
        [DataMember(Name = "policyId", EmitDefaultValue = false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [DataMember(Name = "chainId", EmitDefaultValue = false)]
        public decimal ChainId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateTransactionRequestInput {\n");
            sb.Append("  Interactions: ").Append(Interactions).Append("\n");
            sb.Append("  Optimistic: ").Append(Optimistic).Append("\n");
            sb.Append("  Sponsor: ").Append(Sponsor).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
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
            return this.Equals(input as CreateTransactionRequestInput);
        }

        /// <summary>
        /// Returns true if CreateTransactionRequestInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTransactionRequestInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTransactionRequestInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Interactions == input.Interactions ||
                    this.Interactions != null &&
                    input.Interactions != null &&
                    this.Interactions.SequenceEqual(input.Interactions)
                ) && 
                (
                    this.Optimistic == input.Optimistic ||
                    this.Optimistic.Equals(input.Optimistic)
                ) && 
                (
                    this.Sponsor == input.Sponsor ||
                    this.Sponsor.Equals(input.Sponsor)
                ) && 
                (
                    this.PolicyId == input.PolicyId ||
                    (this.PolicyId != null &&
                    this.PolicyId.Equals(input.PolicyId))
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
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
                if (this.Interactions != null)
                {
                    hashCode = (hashCode * 59) + this.Interactions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Optimistic.GetHashCode();
                hashCode = (hashCode * 59) + this.Sponsor.GetHashCode();
                if (this.PolicyId != null)
                {
                    hashCode = (hashCode * 59) + this.PolicyId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
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
