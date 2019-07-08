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
    /// Custom Entities can link to investments and vice reversa
    /// </summary>
    [DataContract]
    public partial class CustomEntityInvestment :  IEquatable<CustomEntityInvestment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEntityInvestment" /> class.
        /// </summary>
        /// <param name="customEntityId">CustomEntityId.</param>
        /// <param name="customEntity">CustomEntity.</param>
        /// <param name="investmentID">investmentID.</param>
        /// <param name="investment">investment.</param>
        public CustomEntityInvestment(int? customEntityId = default(int?), CustomEntity customEntity = default(CustomEntity), int? investmentID = default(int?), Investment investment = default(Investment))
        {
            this.CustomEntityId = customEntityId;
            this.CustomEntity = customEntity;
            this.InvestmentID = investmentID;
            this.Investment = investment;
        }
        
        /// <summary>
        /// CustomEntityId
        /// </summary>
        /// <value>CustomEntityId</value>
        [DataMember(Name="customEntityId", EmitDefaultValue=false)]
        public int? CustomEntityId { get; set; }

        /// <summary>
        /// CustomEntity
        /// </summary>
        /// <value>CustomEntity</value>
        [DataMember(Name="customEntity", EmitDefaultValue=false)]
        public CustomEntity CustomEntity { get; set; }

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
            sb.Append("class CustomEntityInvestment {\n");
            sb.Append("  CustomEntityId: ").Append(CustomEntityId).Append("\n");
            sb.Append("  CustomEntity: ").Append(CustomEntity).Append("\n");
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
            return this.Equals(input as CustomEntityInvestment);
        }

        /// <summary>
        /// Returns true if CustomEntityInvestment instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomEntityInvestment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomEntityInvestment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomEntityId == input.CustomEntityId ||
                    (this.CustomEntityId != null &&
                    this.CustomEntityId.Equals(input.CustomEntityId))
                ) && 
                (
                    this.CustomEntity == input.CustomEntity ||
                    (this.CustomEntity != null &&
                    this.CustomEntity.Equals(input.CustomEntity))
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
                if (this.CustomEntityId != null)
                    hashCode = hashCode * 59 + this.CustomEntityId.GetHashCode();
                if (this.CustomEntity != null)
                    hashCode = hashCode * 59 + this.CustomEntity.GetHashCode();
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
