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
    /// GrantRequestMeeting
    /// </summary>
    [DataContract]
    public partial class GrantRequestMeeting :  IEquatable<GrantRequestMeeting>, IValidatableObject
    {
        /// <summary>
        /// The type of access token you are requesting.
        /// </summary>
        /// <value>The type of access token you are requesting.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GrantTypeEnum
        {
            
            /// <summary>
            /// Enum Meetingpasscode for value: meeting_passcode
            /// </summary>
            [EnumMember(Value = "meeting_passcode")]
            Meetingpasscode = 1
        }

        /// <summary>
        /// The type of access token you are requesting.
        /// </summary>
        /// <value>The type of access token you are requesting.</value>
        [DataMember(Name="grant_type", EmitDefaultValue=false)]
        public GrantTypeEnum GrantType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GrantRequestMeeting" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GrantRequestMeeting() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GrantRequestMeeting" /> class.
        /// </summary>
        /// <param name="grantType">The type of access token you are requesting. (required) (default to GrantTypeEnum.Meetingpasscode).</param>
        /// <param name="meetingNumericId">Meeting ID (required).</param>
        /// <param name="meetingPasscode">Pin (required).</param>
        public GrantRequestMeeting(GrantTypeEnum grantType = GrantTypeEnum.Meetingpasscode, string meetingNumericId = default(string), string meetingPasscode = default(string))
        {
            // to ensure "grantType" is required (not null)
            if (grantType == null)
            {
                throw new InvalidDataException("grantType is a required property for GrantRequestMeeting and cannot be null");
            }
            else
            {
                this.GrantType = grantType;
            }
            // to ensure "meetingNumericId" is required (not null)
            if (meetingNumericId == null)
            {
                throw new InvalidDataException("meetingNumericId is a required property for GrantRequestMeeting and cannot be null");
            }
            else
            {
                this.MeetingNumericId = meetingNumericId;
            }
            // to ensure "meetingPasscode" is required (not null)
            if (meetingPasscode == null)
            {
                throw new InvalidDataException("meetingPasscode is a required property for GrantRequestMeeting and cannot be null");
            }
            else
            {
                this.MeetingPasscode = meetingPasscode;
            }
        }
        

        /// <summary>
        /// Meeting ID
        /// </summary>
        /// <value>Meeting ID</value>
        [DataMember(Name="meetingNumericId", EmitDefaultValue=false)]
        public string MeetingNumericId { get; set; }

        /// <summary>
        /// Pin
        /// </summary>
        /// <value>Pin</value>
        [DataMember(Name="meetingPasscode", EmitDefaultValue=false)]
        public string MeetingPasscode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GrantRequestMeeting {\n");
            sb.Append("  GrantType: ").Append(GrantType).Append("\n");
            sb.Append("  MeetingNumericId: ").Append(MeetingNumericId).Append("\n");
            sb.Append("  MeetingPasscode: ").Append(MeetingPasscode).Append("\n");
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
            return this.Equals(input as GrantRequestMeeting);
        }

        /// <summary>
        /// Returns true if GrantRequestMeeting instances are equal
        /// </summary>
        /// <param name="input">Instance of GrantRequestMeeting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GrantRequestMeeting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GrantType == input.GrantType ||
                    (this.GrantType != null &&
                    this.GrantType.Equals(input.GrantType))
                ) && 
                (
                    this.MeetingNumericId == input.MeetingNumericId ||
                    (this.MeetingNumericId != null &&
                    this.MeetingNumericId.Equals(input.MeetingNumericId))
                ) && 
                (
                    this.MeetingPasscode == input.MeetingPasscode ||
                    (this.MeetingPasscode != null &&
                    this.MeetingPasscode.Equals(input.MeetingPasscode))
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
                if (this.GrantType != null)
                    hashCode = hashCode * 59 + this.GrantType.GetHashCode();
                if (this.MeetingNumericId != null)
                    hashCode = hashCode * 59 + this.MeetingNumericId.GetHashCode();
                if (this.MeetingPasscode != null)
                    hashCode = hashCode * 59 + this.MeetingPasscode.GetHashCode();
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
