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
    /// TransferAssetRequestInput
    /// </summary>
    [DataContract(Name = "TransferAssetRequestInput")]
    public partial class TransferAssetRequestInput : IEquatable<TransferAssetRequestInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferAssetRequestInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferAssetRequestInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferAssetRequestInput" /> class.
        /// </summary>
        /// <param name="receiverProfileId">receiverProfileId (required).</param>
        /// <param name="assetAddress">assetAddress (required).</param>
        /// <param name="assetId">assetId (required).</param>
        /// <param name="amountToTransfer">amountToTransfer (default to 1M).</param>
        /// <param name="optimistic">optimistic (default to false).</param>
        /// <param name="sponsor">sponsor (default to true).</param>
        /// <param name="policyId">policyId.</param>
        public TransferAssetRequestInput(string receiverProfileId = default(string), string assetAddress = default(string), decimal assetId = default(decimal), decimal amountToTransfer = 1M, bool optimistic = false, bool sponsor = true, string policyId = default(string))
        {
            // to ensure "receiverProfileId" is required (not null)
            if (receiverProfileId == null)
            {
                throw new ArgumentNullException("receiverProfileId is a required property for TransferAssetRequestInput and cannot be null");
            }
            this.ReceiverProfileId = receiverProfileId;
            // to ensure "assetAddress" is required (not null)
            if (assetAddress == null)
            {
                throw new ArgumentNullException("assetAddress is a required property for TransferAssetRequestInput and cannot be null");
            }
            this.AssetAddress = assetAddress;
            this.AssetId = assetId;
            this.AmountToTransfer = amountToTransfer;
            this.Optimistic = optimistic;
            this.Sponsor = sponsor;
            this.PolicyId = policyId;
        }

        /// <summary>
        /// Gets or Sets ReceiverProfileId
        /// </summary>
        [DataMember(Name = "receiverProfileId", IsRequired = true, EmitDefaultValue = true)]
        public string ReceiverProfileId { get; set; }

        /// <summary>
        /// Gets or Sets AssetAddress
        /// </summary>
        [DataMember(Name = "assetAddress", IsRequired = true, EmitDefaultValue = true)]
        public string AssetAddress { get; set; }

        /// <summary>
        /// Gets or Sets AssetId
        /// </summary>
        [DataMember(Name = "assetId", IsRequired = true, EmitDefaultValue = true)]
        public decimal AssetId { get; set; }

        /// <summary>
        /// Gets or Sets AmountToTransfer
        /// </summary>
        [DataMember(Name = "amountToTransfer", EmitDefaultValue = false)]
        public decimal AmountToTransfer { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferAssetRequestInput {\n");
            sb.Append("  ReceiverProfileId: ").Append(ReceiverProfileId).Append("\n");
            sb.Append("  AssetAddress: ").Append(AssetAddress).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  AmountToTransfer: ").Append(AmountToTransfer).Append("\n");
            sb.Append("  Optimistic: ").Append(Optimistic).Append("\n");
            sb.Append("  Sponsor: ").Append(Sponsor).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
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
            return this.Equals(input as TransferAssetRequestInput);
        }

        /// <summary>
        /// Returns true if TransferAssetRequestInput instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferAssetRequestInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferAssetRequestInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ReceiverProfileId == input.ReceiverProfileId ||
                    (this.ReceiverProfileId != null &&
                    this.ReceiverProfileId.Equals(input.ReceiverProfileId))
                ) && 
                (
                    this.AssetAddress == input.AssetAddress ||
                    (this.AssetAddress != null &&
                    this.AssetAddress.Equals(input.AssetAddress))
                ) && 
                (
                    this.AssetId == input.AssetId ||
                    this.AssetId.Equals(input.AssetId)
                ) && 
                (
                    this.AmountToTransfer == input.AmountToTransfer ||
                    this.AmountToTransfer.Equals(input.AmountToTransfer)
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
                if (this.ReceiverProfileId != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiverProfileId.GetHashCode();
                }
                if (this.AssetAddress != null)
                {
                    hashCode = (hashCode * 59) + this.AssetAddress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AssetId.GetHashCode();
                hashCode = (hashCode * 59) + this.AmountToTransfer.GetHashCode();
                hashCode = (hashCode * 59) + this.Optimistic.GetHashCode();
                hashCode = (hashCode * 59) + this.Sponsor.GetHashCode();
                if (this.PolicyId != null)
                {
                    hashCode = (hashCode * 59) + this.PolicyId.GetHashCode();
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
            // AmountToTransfer (decimal) minimum
            if (this.AmountToTransfer < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AmountToTransfer, must be a value greater than or equal to 0.", new [] { "AmountToTransfer" });
            }

            yield break;
        }
    }

}
