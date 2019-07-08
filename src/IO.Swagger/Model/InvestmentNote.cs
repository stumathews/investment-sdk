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
    /// Simple text note for an entity
    /// </summary>
    [DataContract]
    public partial class InvestmentNote :  IEquatable<InvestmentNote>, IValidatableObject
    {
        /// <summary>
        /// Type of owning It
        /// </summary>
        /// <value>Type of owning It</value>
        public enum OwningEntityTypeEnum
        {
            
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            
            NUMBER_0 = 0,
            
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            
            NUMBER_1 = 1,
            
            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            
            NUMBER_2 = 2,
            
            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            
            NUMBER_3 = 3,
            
            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            
            NUMBER_4 = 4,
            
            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            
            NUMBER_5 = 5,
            
            /// <summary>
            /// Enum NUMBER_6 for value: 6
            /// </summary>
            
            NUMBER_6 = 6,
            
            /// <summary>
            /// Enum NUMBER_7 for value: 7
            /// </summary>
            
            NUMBER_7 = 7,
            
            /// <summary>
            /// Enum NUMBER_8 for value: 8
            /// </summary>
            
            NUMBER_8 = 8,
            
            /// <summary>
            /// Enum NUMBER_9 for value: 9
            /// </summary>
            
            NUMBER_9 = 9,
            
            /// <summary>
            /// Enum NUMBER_10 for value: 10
            /// </summary>
            
            NUMBER_10 = 10,
            
            /// <summary>
            /// Enum NUMBER_11 for value: 11
            /// </summary>
            
            NUMBER_11 = 11,
            
            /// <summary>
            /// Enum NUMBER_12 for value: 12
            /// </summary>
            
            NUMBER_12 = 12,
            
            /// <summary>
            /// Enum NUMBER_13 for value: 13
            /// </summary>
            
            NUMBER_13 = 13,
            
            /// <summary>
            /// Enum NUMBER_14 for value: 14
            /// </summary>
            
            NUMBER_14 = 14,
            
            /// <summary>
            /// Enum NUMBER_15 for value: 15
            /// </summary>
            
            NUMBER_15 = 15
        }

        /// <summary>
        /// Type of owning It
        /// </summary>
        /// <value>Type of owning It</value>
        [DataMember(Name="owningEntityType", EmitDefaultValue=false)]
        public OwningEntityTypeEnum? OwningEntityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvestmentNote" /> class.
        /// </summary>
        /// <param name="owningEntityId">Owning id.</param>
        /// <param name="owningEntityType">Type of owning It.</param>
        /// <param name="id">The identifier of the entity.</param>
        /// <param name="name">The name of the entity.</param>
        /// <param name="description">The description of the entity.</param>
        /// <param name="createdTime">When the entity was created.</param>
        /// <param name="lastModifiedTime">When the entity was last modified.</param>
        /// <param name="points">Generic points for this entity.</param>
        /// <param name="isFlagged">Generic true/false marker for entity.</param>
        public InvestmentNote(int? owningEntityId = default(int?), OwningEntityTypeEnum? owningEntityType = default(OwningEntityTypeEnum?), int? id = default(int?), string name = default(string), string description = default(string), DateTime? createdTime = default(DateTime?), DateTime? lastModifiedTime = default(DateTime?), long? points = default(long?), bool? isFlagged = default(bool?))
        {
            this.OwningEntityId = owningEntityId;
            this.OwningEntityType = owningEntityType;
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.CreatedTime = createdTime;
            this.LastModifiedTime = lastModifiedTime;
            this.Points = points;
            this.IsFlagged = isFlagged;
        }
        
        /// <summary>
        /// Gets or Sets InvestmentIds
        /// </summary>
        [DataMember(Name="investmentIds", EmitDefaultValue=false)]
        public List<int?> InvestmentIds { get; private set; }

        /// <summary>
        /// Owning id
        /// </summary>
        /// <value>Owning id</value>
        [DataMember(Name="owningEntityId", EmitDefaultValue=false)]
        public int? OwningEntityId { get; set; }


        /// <summary>
        /// The identifier of the entity
        /// </summary>
        /// <value>The identifier of the entity</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The name of the entity
        /// </summary>
        /// <value>The name of the entity</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the entity
        /// </summary>
        /// <value>The description of the entity</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// When the entity was created
        /// </summary>
        /// <value>When the entity was created</value>
        [DataMember(Name="createdTime", EmitDefaultValue=false)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// When the entity was last modified
        /// </summary>
        /// <value>When the entity was last modified</value>
        [DataMember(Name="lastModifiedTime", EmitDefaultValue=false)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Generic points for this entity
        /// </summary>
        /// <value>Generic points for this entity</value>
        [DataMember(Name="points", EmitDefaultValue=false)]
        public long? Points { get; set; }

        /// <summary>
        /// Generic true/false marker for entity
        /// </summary>
        /// <value>Generic true/false marker for entity</value>
        [DataMember(Name="isFlagged", EmitDefaultValue=false)]
        public bool? IsFlagged { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvestmentNote {\n");
            sb.Append("  InvestmentIds: ").Append(InvestmentIds).Append("\n");
            sb.Append("  OwningEntityId: ").Append(OwningEntityId).Append("\n");
            sb.Append("  OwningEntityType: ").Append(OwningEntityType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  LastModifiedTime: ").Append(LastModifiedTime).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  IsFlagged: ").Append(IsFlagged).Append("\n");
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
            return this.Equals(input as InvestmentNote);
        }

        /// <summary>
        /// Returns true if InvestmentNote instances are equal
        /// </summary>
        /// <param name="input">Instance of InvestmentNote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvestmentNote input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InvestmentIds == input.InvestmentIds ||
                    this.InvestmentIds != null &&
                    this.InvestmentIds.SequenceEqual(input.InvestmentIds)
                ) && 
                (
                    this.OwningEntityId == input.OwningEntityId ||
                    (this.OwningEntityId != null &&
                    this.OwningEntityId.Equals(input.OwningEntityId))
                ) && 
                (
                    this.OwningEntityType == input.OwningEntityType ||
                    (this.OwningEntityType != null &&
                    this.OwningEntityType.Equals(input.OwningEntityType))
                ) && 
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
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) && 
                (
                    this.LastModifiedTime == input.LastModifiedTime ||
                    (this.LastModifiedTime != null &&
                    this.LastModifiedTime.Equals(input.LastModifiedTime))
                ) && 
                (
                    this.Points == input.Points ||
                    (this.Points != null &&
                    this.Points.Equals(input.Points))
                ) && 
                (
                    this.IsFlagged == input.IsFlagged ||
                    (this.IsFlagged != null &&
                    this.IsFlagged.Equals(input.IsFlagged))
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
                if (this.InvestmentIds != null)
                    hashCode = hashCode * 59 + this.InvestmentIds.GetHashCode();
                if (this.OwningEntityId != null)
                    hashCode = hashCode * 59 + this.OwningEntityId.GetHashCode();
                if (this.OwningEntityType != null)
                    hashCode = hashCode * 59 + this.OwningEntityType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.LastModifiedTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedTime.GetHashCode();
                if (this.Points != null)
                    hashCode = hashCode * 59 + this.Points.GetHashCode();
                if (this.IsFlagged != null)
                    hashCode = hashCode * 59 + this.IsFlagged.GetHashCode();
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