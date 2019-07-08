/* 
 * Core Investment Tracker API
 *
 * Investment tracker is a platform that allows you to track aspects that affect your investments
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// InvestmentInfluenceFactorInvestment
    /// </summary>
    [DataContract]
    public partial class InvestmentInfluenceFactorInvestment :  IEquatable<InvestmentInfluenceFactorInvestment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvestmentInfluenceFactorInvestment" /> class.
        /// </summary>
        /// <param name="investmentInfluenceFactorID">InvestmentInfluenceFactorID.</param>
        /// <param name="investmentInfluenceFactor">InvestmentInfluenceFactor.</param>
        /// <param name="investmentID">investmentID.</param>
        /// <param name="investment">investment.</param>
        public InvestmentInfluenceFactorInvestment(int? investmentInfluenceFactorID = default(int?), InvestmentInfluenceFactor investmentInfluenceFactor = default(InvestmentInfluenceFactor), int? investmentID = default(int?), Investment investment = default(Investment))
        {
            this.InvestmentInfluenceFactorID = investmentInfluenceFactorID;
            this.InvestmentInfluenceFactor = investmentInfluenceFactor;
            this.InvestmentID = investmentID;
            this.Investment = investment;
        }
        
        /// <summary>
        /// InvestmentInfluenceFactorID
        /// </summary>
        /// <value>InvestmentInfluenceFactorID</value>
        [DataMember(Name="investmentInfluenceFactorID", EmitDefaultValue=false)]
        public int? InvestmentInfluenceFactorID { get; set; }

        /// <summary>
        /// InvestmentInfluenceFactor
        /// </summary>
        /// <value>InvestmentInfluenceFactor</value>
        [DataMember(Name="investmentInfluenceFactor", EmitDefaultValue=false)]
        public InvestmentInfluenceFactor InvestmentInfluenceFactor { get; set; }

        /// <summary>
        /// Gets or Sets InvestmentID
        /// </summary>
        [DataMember(Name="investmentID", EmitDefaultValue=false)]
        public int? InvestmentID { get; set; }

        /// <summary>
        /// Gets or Sets Investment
        /// </summary>
        [DataMember(Name="investment", EmitDefaultValue=false)]
        public Investment Investment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvestmentInfluenceFactorInvestment {\n");
            sb.Append("  InvestmentInfluenceFactorID: ").Append(InvestmentInfluenceFactorID).Append("\n");
            sb.Append("  InvestmentInfluenceFactor: ").Append(InvestmentInfluenceFactor).Append("\n");
            sb.Append("  InvestmentID: ").Append(InvestmentID).Append("\n");
            sb.Append("  Investment: ").Append(Investment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InvestmentInfluenceFactorInvestment);
        }

        /// <summary>
        /// Returns true if InvestmentInfluenceFactorInvestment instances are equal
        /// </summary>
        /// <param name="input">Instance of InvestmentInfluenceFactorInvestment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvestmentInfluenceFactorInvestment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InvestmentInfluenceFactorID == input.InvestmentInfluenceFactorID ||
                    (this.InvestmentInfluenceFactorID != null &&
                    this.InvestmentInfluenceFactorID.Equals(input.InvestmentInfluenceFactorID))
                ) && 
                (
                    this.InvestmentInfluenceFactor == input.InvestmentInfluenceFactor ||
                    (this.InvestmentInfluenceFactor != null &&
                    this.InvestmentInfluenceFactor.Equals(input.InvestmentInfluenceFactor))
                ) && 
                (
                    this.InvestmentID == input.InvestmentID ||
                    (this.InvestmentID != null &&
                    this.InvestmentID.Equals(input.InvestmentID))
                ) && 
                (
                    this.Investment == input.Investment ||
                    (this.Investment != null &&
                    this.Investment.Equals(input.Investment))
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
                if (this.InvestmentInfluenceFactorID != null)
                    hashCode = hashCode * 59 + this.InvestmentInfluenceFactorID.GetHashCode();
                if (this.InvestmentInfluenceFactor != null)
                    hashCode = hashCode * 59 + this.InvestmentInfluenceFactor.GetHashCode();
                if (this.InvestmentID != null)
                    hashCode = hashCode * 59 + this.InvestmentID.GetHashCode();
                if (this.Investment != null)
                    hashCode = hashCode * 59 + this.Investment.GetHashCode();
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