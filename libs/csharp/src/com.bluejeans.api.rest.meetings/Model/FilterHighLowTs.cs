/* 
 * BlueJeans Meetings REST API
 *
 *  ## Video That Works Where You Do. <p>This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you can see and try actual API calls to manage User Accounts, Meetings, and Recordings, pull Analytical Data and Current State information.</p>    <nosdk> <hr> <div> <div class=\"key\">     <a href=\"./basics.html\" target=\"_\"><img class=\"keyimg\" src=\"./img/bjnmeeting.png\"/></a> </div> <div class=\"keybox\"> Basic instructions about What is a BlueJeans Meeting, and Getting Started Using API's, are <a href=\"./basics.html\" target=\"_blank\">available here <i class=\"glyphicon glyphicon-new-window\"></i></a>. </div> </div> <hr> <alert>2/21/2019</alert> Change response of Change layout and Endpoint API's to 204<br/> 12/03/2018 Add API for setting user profile photograph.<br/> 10/17/2018 Updated API field definitions for time variables to be 64-bit .<br/> 7/23/2018 Corrected errors in API definition file.<br/> 7/10/2018 Deprecated some Command Center API's.  Exposed API's that Summarize usage.<br/> 7/06/2018 Added API for changing ownership of recordings.<br/> 6/28/2018 Restored Create Enterprise Account, added Enterprise and User Profile Tag API's.<br/> 6/01/2018 Clarified Access Token requirements for meeting endpoint API's.<br/> 5/21/2018 Corrected return model for meeting history call.<br/> </nosdk> <hr> 
 *
 * OpenAPI spec version: 1.0.4402212019
 * Contact: glenn@bluejeans.com
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
using SwaggerDateConverter = com.bluejeans.api.rest.meetings.Client.SwaggerDateConverter;

namespace com.bluejeans.api.rest.meetings.Model
{
    /// <summary>
    /// FilterHighLowTs
    /// </summary>
    [DataContract]
    public partial class FilterHighLowTs :  IEquatable<FilterHighLowTs>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum String for value: string
            /// </summary>
            [EnumMember(Value = "string")]
            String = 1,
            
            /// <summary>
            /// Enum Boolean for value: boolean
            /// </summary>
            [EnumMember(Value = "boolean")]
            Boolean = 2,
            
            /// <summary>
            /// Enum Numeric for value: numeric
            /// </summary>
            [EnumMember(Value = "numeric")]
            Numeric = 3,
            
            /// <summary>
            /// Enum Date for value: date
            /// </summary>
            [EnumMember(Value = "date")]
            Date = 4,
            
            /// <summary>
            /// Enum List for value: list
            /// </summary>
            [EnumMember(Value = "list")]
            List = 5
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Defines Comparison
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ComparisonEnum
        {
            
            /// <summary>
            /// Enum Le for value: le
            /// </summary>
            [EnumMember(Value = "le")]
            Le = 1,
            
            /// <summary>
            /// Enum Lt for value: lt
            /// </summary>
            [EnumMember(Value = "lt")]
            Lt = 2,
            
            /// <summary>
            /// Enum Eq for value: eq
            /// </summary>
            [EnumMember(Value = "eq")]
            Eq = 3,
            
            /// <summary>
            /// Enum Ge for value: ge
            /// </summary>
            [EnumMember(Value = "ge")]
            Ge = 4,
            
            /// <summary>
            /// Enum Gt for value: gt
            /// </summary>
            [EnumMember(Value = "gt")]
            Gt = 5
        }

        /// <summary>
        /// Gets or Sets Comparison
        /// </summary>
        [DataMember(Name="comparison", EmitDefaultValue=false)]
        public ComparisonEnum? Comparison { get; set; }
        /// <summary>
        /// Defines Value
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValueEnum
        {
            
            /// <summary>
            /// Enum Lowts for value: lowts
            /// </summary>
            [EnumMember(Value = "lowts")]
            Lowts = 1,
            
            /// <summary>
            /// Enum Hights for value: hights
            /// </summary>
            [EnumMember(Value = "hights")]
            Hights = 2
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public ValueEnum? Value { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterHighLowTs" /> class.
        /// </summary>
        /// <param name="type">type (default to TypeEnum.Date).</param>
        /// <param name="comparison">comparison.</param>
        /// <param name="value">value.</param>
        public FilterHighLowTs(TypeEnum? type = TypeEnum.Date, ComparisonEnum? comparison = default(ComparisonEnum?), ValueEnum? value = default(ValueEnum?))
        {
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = TypeEnum.Date;
            }
            else
            {
                this.Type = type;
            }
            this.Comparison = comparison;
            this.Value = value;
        }
        



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilterHighLowTs {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Comparison: ").Append(Comparison).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as FilterHighLowTs);
        }

        /// <summary>
        /// Returns true if FilterHighLowTs instances are equal
        /// </summary>
        /// <param name="input">Instance of FilterHighLowTs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilterHighLowTs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Comparison == input.Comparison ||
                    (this.Comparison != null &&
                    this.Comparison.Equals(input.Comparison))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Comparison != null)
                    hashCode = hashCode * 59 + this.Comparison.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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