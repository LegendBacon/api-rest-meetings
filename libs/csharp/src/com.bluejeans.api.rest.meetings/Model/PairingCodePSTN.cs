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
    /// PairingCodePSTN
    /// </summary>
    [DataContract]
    public partial class PairingCodePSTN :  IEquatable<PairingCodePSTN>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PairingCodePSTN" /> class.
        /// </summary>
        /// <param name="pairingCode">Unique number associated with this endpoint in this meeting.</param>
        /// <param name="connectionGuid">Globally unique identifier associated with this endpoint in this meeting. (Typically a string starting with \&quot;connguid:\&quot;).</param>
        /// <param name="seamEndpointGuid">Globally unique identifier associated with the media component of this endpoint for this meeting.  (Typically a string starting with \&quot;seamguid:\&quot;).</param>
        /// <param name="endpointName">String name assigned to this endpoint.</param>
        public PairingCodePSTN(string pairingCode = default(string), string connectionGuid = default(string), string seamEndpointGuid = default(string), string endpointName = default(string))
        {
            this.PairingCode = pairingCode;
            this.ConnectionGuid = connectionGuid;
            this.SeamEndpointGuid = seamEndpointGuid;
            this.EndpointName = endpointName;
        }
        
        /// <summary>
        /// Unique number associated with this endpoint in this meeting
        /// </summary>
        /// <value>Unique number associated with this endpoint in this meeting</value>
        [DataMember(Name="pairingCode", EmitDefaultValue=false)]
        public string PairingCode { get; set; }

        /// <summary>
        /// Globally unique identifier associated with this endpoint in this meeting. (Typically a string starting with \&quot;connguid:\&quot;)
        /// </summary>
        /// <value>Globally unique identifier associated with this endpoint in this meeting. (Typically a string starting with \&quot;connguid:\&quot;)</value>
        [DataMember(Name="connectionGuid", EmitDefaultValue=false)]
        public string ConnectionGuid { get; set; }

        /// <summary>
        /// Globally unique identifier associated with the media component of this endpoint for this meeting.  (Typically a string starting with \&quot;seamguid:\&quot;)
        /// </summary>
        /// <value>Globally unique identifier associated with the media component of this endpoint for this meeting.  (Typically a string starting with \&quot;seamguid:\&quot;)</value>
        [DataMember(Name="seamEndpointGuid", EmitDefaultValue=false)]
        public string SeamEndpointGuid { get; set; }

        /// <summary>
        /// String name assigned to this endpoint
        /// </summary>
        /// <value>String name assigned to this endpoint</value>
        [DataMember(Name="endpointName", EmitDefaultValue=false)]
        public string EndpointName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PairingCodePSTN {\n");
            sb.Append("  PairingCode: ").Append(PairingCode).Append("\n");
            sb.Append("  ConnectionGuid: ").Append(ConnectionGuid).Append("\n");
            sb.Append("  SeamEndpointGuid: ").Append(SeamEndpointGuid).Append("\n");
            sb.Append("  EndpointName: ").Append(EndpointName).Append("\n");
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
            return this.Equals(input as PairingCodePSTN);
        }

        /// <summary>
        /// Returns true if PairingCodePSTN instances are equal
        /// </summary>
        /// <param name="input">Instance of PairingCodePSTN to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PairingCodePSTN input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PairingCode == input.PairingCode ||
                    (this.PairingCode != null &&
                    this.PairingCode.Equals(input.PairingCode))
                ) && 
                (
                    this.ConnectionGuid == input.ConnectionGuid ||
                    (this.ConnectionGuid != null &&
                    this.ConnectionGuid.Equals(input.ConnectionGuid))
                ) && 
                (
                    this.SeamEndpointGuid == input.SeamEndpointGuid ||
                    (this.SeamEndpointGuid != null &&
                    this.SeamEndpointGuid.Equals(input.SeamEndpointGuid))
                ) && 
                (
                    this.EndpointName == input.EndpointName ||
                    (this.EndpointName != null &&
                    this.EndpointName.Equals(input.EndpointName))
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
                if (this.PairingCode != null)
                    hashCode = hashCode * 59 + this.PairingCode.GetHashCode();
                if (this.ConnectionGuid != null)
                    hashCode = hashCode * 59 + this.ConnectionGuid.GetHashCode();
                if (this.SeamEndpointGuid != null)
                    hashCode = hashCode * 59 + this.SeamEndpointGuid.GetHashCode();
                if (this.EndpointName != null)
                    hashCode = hashCode * 59 + this.EndpointName.GetHashCode();
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