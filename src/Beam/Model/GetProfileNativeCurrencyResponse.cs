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
    /// GetProfileNativeCurrencyResponse
    /// </summary>
    [DataContract(Name = "GetProfileNativeCurrencyResponse")]
    public partial class GetProfileNativeCurrencyResponse : IEquatable<GetProfileNativeCurrencyResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProfileNativeCurrencyResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetProfileNativeCurrencyResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProfileNativeCurrencyResponse" /> class.
        /// </summary>
        /// <param name="nativeTokenBalance">nativeTokenBalance (required).</param>
        public GetProfileNativeCurrencyResponse(GetProfileNativeCurrencyResponseNativeTokenBalance nativeTokenBalance = default(GetProfileNativeCurrencyResponseNativeTokenBalance))
        {
            // to ensure "nativeTokenBalance" is required (not null)
            if (nativeTokenBalance == null)
            {
                throw new ArgumentNullException("nativeTokenBalance is a required property for GetProfileNativeCurrencyResponse and cannot be null");
            }
            this.NativeTokenBalance = nativeTokenBalance;
        }

        /// <summary>
        /// Gets or Sets NativeTokenBalance
        /// </summary>
        [DataMember(Name = "nativeTokenBalance", IsRequired = true, EmitDefaultValue = true)]
        public GetProfileNativeCurrencyResponseNativeTokenBalance NativeTokenBalance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetProfileNativeCurrencyResponse {\n");
            sb.Append("  NativeTokenBalance: ").Append(NativeTokenBalance).Append("\n");
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
            return this.Equals(input as GetProfileNativeCurrencyResponse);
        }

        /// <summary>
        /// Returns true if GetProfileNativeCurrencyResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetProfileNativeCurrencyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetProfileNativeCurrencyResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NativeTokenBalance == input.NativeTokenBalance ||
                    (this.NativeTokenBalance != null &&
                    this.NativeTokenBalance.Equals(input.NativeTokenBalance))
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
                if (this.NativeTokenBalance != null)
                {
                    hashCode = (hashCode * 59) + this.NativeTokenBalance.GetHashCode();
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