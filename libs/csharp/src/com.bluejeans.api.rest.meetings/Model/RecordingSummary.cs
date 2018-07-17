/* 
 * BlueJeans Meetings REST API
 *
 *  ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.    <alert>7/010/2018 </alert>Deprecated some Command Center API's.  Exposed API's that Summarize usage.<br/> 7/06/2018 Added API for changing ownership of recordings.<br/> 6/28/2018 Restored Create Enterprise Account, added Enterprise and User Profile Tag API's.<br/> 6/01/2018 Clarified Access Token requirements for meeting endpoint API's.<br/> 5/21/2018 Corrected return model for meeting history call.<br/> <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 
 *
 * OpenAPI spec version: 1.0.0.mm44 (7/06/2018)
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
    /// RecordingSummary
    /// </summary>
    [DataContract]
    public partial class RecordingSummary :  IEquatable<RecordingSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingSummary" /> class.
        /// </summary>
        /// <param name="RecordingEntityId">RecordingEntityId.</param>
        /// <param name="RecordingName">RecordingName.</param>
        /// <param name="MeetingGuid">MeetingGuid.</param>
        /// <param name="ChapterCount">ChapterCount.</param>
        /// <param name="TotalSize">TotalSize.</param>
        /// <param name="TotalDuration">TotalDuration.</param>
        /// <param name="LastRecordingDate">LastRecordingDate.</param>
        /// <param name="AggregatedStatus">AggregatedStatus.</param>
        /// <param name="RecordingThumbnail">RecordingThumbnail.</param>
        /// <param name="Created">Created.</param>
        /// <param name="IsPremiumRecording">IsPremiumRecording.</param>
        /// <param name="ShowPremiumRecordingTag">ShowPremiumRecordingTag.</param>
        public RecordingSummary(int? RecordingEntityId = default(int?), string RecordingName = default(string), string MeetingGuid = default(string), int? ChapterCount = default(int?), int? TotalSize = default(int?), int? TotalDuration = default(int?), string LastRecordingDate = default(string), string AggregatedStatus = default(string), string RecordingThumbnail = default(string), int? Created = default(int?), bool? IsPremiumRecording = default(bool?), bool? ShowPremiumRecordingTag = default(bool?))
        {
            this.RecordingEntityId = RecordingEntityId;
            this.RecordingName = RecordingName;
            this.MeetingGuid = MeetingGuid;
            this.ChapterCount = ChapterCount;
            this.TotalSize = TotalSize;
            this.TotalDuration = TotalDuration;
            this.LastRecordingDate = LastRecordingDate;
            this.AggregatedStatus = AggregatedStatus;
            this.RecordingThumbnail = RecordingThumbnail;
            this.Created = Created;
            this.IsPremiumRecording = IsPremiumRecording;
            this.ShowPremiumRecordingTag = ShowPremiumRecordingTag;
        }
        
        /// <summary>
        /// Gets or Sets RecordingEntityId
        /// </summary>
        [DataMember(Name="recordingEntityId", EmitDefaultValue=false)]
        public int? RecordingEntityId { get; set; }

        /// <summary>
        /// Gets or Sets RecordingName
        /// </summary>
        [DataMember(Name="recordingName", EmitDefaultValue=false)]
        public string RecordingName { get; set; }

        /// <summary>
        /// Gets or Sets MeetingGuid
        /// </summary>
        [DataMember(Name="meetingGuid", EmitDefaultValue=false)]
        public string MeetingGuid { get; set; }

        /// <summary>
        /// Gets or Sets ChapterCount
        /// </summary>
        [DataMember(Name="chapterCount", EmitDefaultValue=false)]
        public int? ChapterCount { get; set; }

        /// <summary>
        /// Gets or Sets TotalSize
        /// </summary>
        [DataMember(Name="totalSize", EmitDefaultValue=false)]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Gets or Sets TotalDuration
        /// </summary>
        [DataMember(Name="totalDuration", EmitDefaultValue=false)]
        public int? TotalDuration { get; set; }

        /// <summary>
        /// Gets or Sets LastRecordingDate
        /// </summary>
        [DataMember(Name="lastRecordingDate", EmitDefaultValue=false)]
        public string LastRecordingDate { get; set; }

        /// <summary>
        /// Gets or Sets AggregatedStatus
        /// </summary>
        [DataMember(Name="aggregatedStatus", EmitDefaultValue=false)]
        public string AggregatedStatus { get; set; }

        /// <summary>
        /// Gets or Sets RecordingThumbnail
        /// </summary>
        [DataMember(Name="recordingThumbnail", EmitDefaultValue=false)]
        public string RecordingThumbnail { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public int? Created { get; set; }

        /// <summary>
        /// Gets or Sets IsPremiumRecording
        /// </summary>
        [DataMember(Name="isPremiumRecording", EmitDefaultValue=false)]
        public bool? IsPremiumRecording { get; set; }

        /// <summary>
        /// Gets or Sets ShowPremiumRecordingTag
        /// </summary>
        [DataMember(Name="showPremiumRecordingTag", EmitDefaultValue=false)]
        public bool? ShowPremiumRecordingTag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordingSummary {\n");
            sb.Append("  RecordingEntityId: ").Append(RecordingEntityId).Append("\n");
            sb.Append("  RecordingName: ").Append(RecordingName).Append("\n");
            sb.Append("  MeetingGuid: ").Append(MeetingGuid).Append("\n");
            sb.Append("  ChapterCount: ").Append(ChapterCount).Append("\n");
            sb.Append("  TotalSize: ").Append(TotalSize).Append("\n");
            sb.Append("  TotalDuration: ").Append(TotalDuration).Append("\n");
            sb.Append("  LastRecordingDate: ").Append(LastRecordingDate).Append("\n");
            sb.Append("  AggregatedStatus: ").Append(AggregatedStatus).Append("\n");
            sb.Append("  RecordingThumbnail: ").Append(RecordingThumbnail).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  IsPremiumRecording: ").Append(IsPremiumRecording).Append("\n");
            sb.Append("  ShowPremiumRecordingTag: ").Append(ShowPremiumRecordingTag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as RecordingSummary);
        }

        /// <summary>
        /// Returns true if RecordingSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of RecordingSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordingSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RecordingEntityId == other.RecordingEntityId ||
                    this.RecordingEntityId != null &&
                    this.RecordingEntityId.Equals(other.RecordingEntityId)
                ) && 
                (
                    this.RecordingName == other.RecordingName ||
                    this.RecordingName != null &&
                    this.RecordingName.Equals(other.RecordingName)
                ) && 
                (
                    this.MeetingGuid == other.MeetingGuid ||
                    this.MeetingGuid != null &&
                    this.MeetingGuid.Equals(other.MeetingGuid)
                ) && 
                (
                    this.ChapterCount == other.ChapterCount ||
                    this.ChapterCount != null &&
                    this.ChapterCount.Equals(other.ChapterCount)
                ) && 
                (
                    this.TotalSize == other.TotalSize ||
                    this.TotalSize != null &&
                    this.TotalSize.Equals(other.TotalSize)
                ) && 
                (
                    this.TotalDuration == other.TotalDuration ||
                    this.TotalDuration != null &&
                    this.TotalDuration.Equals(other.TotalDuration)
                ) && 
                (
                    this.LastRecordingDate == other.LastRecordingDate ||
                    this.LastRecordingDate != null &&
                    this.LastRecordingDate.Equals(other.LastRecordingDate)
                ) && 
                (
                    this.AggregatedStatus == other.AggregatedStatus ||
                    this.AggregatedStatus != null &&
                    this.AggregatedStatus.Equals(other.AggregatedStatus)
                ) && 
                (
                    this.RecordingThumbnail == other.RecordingThumbnail ||
                    this.RecordingThumbnail != null &&
                    this.RecordingThumbnail.Equals(other.RecordingThumbnail)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.IsPremiumRecording == other.IsPremiumRecording ||
                    this.IsPremiumRecording != null &&
                    this.IsPremiumRecording.Equals(other.IsPremiumRecording)
                ) && 
                (
                    this.ShowPremiumRecordingTag == other.ShowPremiumRecordingTag ||
                    this.ShowPremiumRecordingTag != null &&
                    this.ShowPremiumRecordingTag.Equals(other.ShowPremiumRecordingTag)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.RecordingEntityId != null)
                    hash = hash * 59 + this.RecordingEntityId.GetHashCode();
                if (this.RecordingName != null)
                    hash = hash * 59 + this.RecordingName.GetHashCode();
                if (this.MeetingGuid != null)
                    hash = hash * 59 + this.MeetingGuid.GetHashCode();
                if (this.ChapterCount != null)
                    hash = hash * 59 + this.ChapterCount.GetHashCode();
                if (this.TotalSize != null)
                    hash = hash * 59 + this.TotalSize.GetHashCode();
                if (this.TotalDuration != null)
                    hash = hash * 59 + this.TotalDuration.GetHashCode();
                if (this.LastRecordingDate != null)
                    hash = hash * 59 + this.LastRecordingDate.GetHashCode();
                if (this.AggregatedStatus != null)
                    hash = hash * 59 + this.AggregatedStatus.GetHashCode();
                if (this.RecordingThumbnail != null)
                    hash = hash * 59 + this.RecordingThumbnail.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.IsPremiumRecording != null)
                    hash = hash * 59 + this.IsPremiumRecording.GetHashCode();
                if (this.ShowPremiumRecordingTag != null)
                    hash = hash * 59 + this.ShowPremiumRecordingTag.GetHashCode();
                return hash;
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
