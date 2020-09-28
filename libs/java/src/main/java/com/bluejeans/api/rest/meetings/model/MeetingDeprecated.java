/*
 * BlueJeans Meetings REST API
 *  ## Video That Works Where You Do. <p>This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you can see and try actual API calls to manage User Accounts, Meetings, and Recordings, pull Analytical Data and Current State information.</p>    <nosdk> <hr> <div> <div class=\"key\">     <a href=\"./basics.html\" target=\"_\"><img class=\"keyimg\" src=\"./img/bjnmeeting.png\"/></a> </div> <div class=\"keybox\"> Basic instructions about What is a BlueJeans Meeting, and Getting Started Using API's, are <a href=\"./basics.html\" target=\"_blank\">available here <i class=\"glyphicon glyphicon-new-window\"></i></a>. </div> </div> <hr> <alert>2/21/2019</alert> Change response of Change layout and Endpoint API's to 204<br/> 12/03/2018 Add API for setting user profile photograph.<br/> 10/17/2018 Updated API field definitions for time variables to be 64-bit .<br/> 7/23/2018 Corrected errors in API definition file.<br/> 7/10/2018 Deprecated some Command Center API's.  Exposed API's that Summarize usage.<br/> 7/06/2018 Added API for changing ownership of recordings.<br/> 6/28/2018 Restored Create Enterprise Account, added Enterprise and User Profile Tag API's.<br/> 6/01/2018 Clarified Access Token requirements for meeting endpoint API's.<br/> 5/21/2018 Corrected return model for meeting history call.<br/> </nosdk> <hr> 
 *
 * OpenAPI spec version: 1.0.4402212019
 * Contact: glenn@bluejeans.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package com.bluejeans.api.rest.meetings.model;

import java.util.Objects;
import java.util.Arrays;
import com.bluejeans.api.rest.meetings.model.Attendee;
import com.bluejeans.api.rest.meetings.model.MeetingDeprecatedAdvancedMeetingOptions;
import com.bluejeans.api.rest.meetings.model.MeetingRecurrencePattern;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

/**
 * DEPRECATED (2/5/2018) -- This JSON object contains the fields associated with a BlueJeans&#39;meeting.
 */
@ApiModel(description = "DEPRECATED (2/5/2018) -- This JSON object contains the fields associated with a BlueJeans'meeting.")

public class MeetingDeprecated {
  @SerializedName("id")
  private Integer id = null;

  @SerializedName("title")
  private String title = "My Test Meeting";

  @SerializedName("description")
  private String description = null;

  @SerializedName("start")
  private Long start = null;

  @SerializedName("end")
  private Long end = null;

  @SerializedName("timezone")
  private String timezone = "America/New_York";

  @SerializedName("numericMeetingId")
  private String numericMeetingId = null;

  @SerializedName("attendeePasscode")
  private String attendeePasscode = null;

  @SerializedName("isPersonalMeeting")
  private Boolean isPersonalMeeting = false;

  @SerializedName("isLargeMeeting")
  private Boolean isLargeMeeting = null;

  @SerializedName("addAttendeePasscode")
  private Boolean addAttendeePasscode = null;

  @SerializedName("endPointVersion")
  private String endPointVersion = "2.10";

  @SerializedName("endPointType")
  private String endPointType = "WEB_APP";

  @SerializedName("attendees")
  private List<Attendee> attendees = null;

  @SerializedName("advancedMeetingOptions")
  private MeetingDeprecatedAdvancedMeetingOptions advancedMeetingOptions = null;

  @SerializedName("recurrencePattern")
  private MeetingRecurrencePattern recurrencePattern = null;

   /**
   * Unique identifier for meeting.
   * @return id
  **/
  @ApiModelProperty(value = "Unique identifier for meeting.")
  public Integer getId() {
    return id;
  }

  public MeetingDeprecated title(String title) {
    this.title = title;
    return this;
  }

   /**
   * Get title
   * @return title
  **/
  @ApiModelProperty(required = true, value = "")
  public String getTitle() {
    return title;
  }

  public void setTitle(String title) {
    this.title = title;
  }

  public MeetingDeprecated description(String description) {
    this.description = description;
    return this;
  }

   /**
   * Get description
   * @return description
  **/
  @ApiModelProperty(value = "")
  public String getDescription() {
    return description;
  }

  public void setDescription(String description) {
    this.description = description;
  }

  public MeetingDeprecated start(Long start) {
    this.start = start;
    return this;
  }

   /**
   * A [UNIX Timestamp](https://currentmillis.com/) in milliseconds
   * @return start
  **/
  @ApiModelProperty(required = true, value = "A [UNIX Timestamp](https://currentmillis.com/) in milliseconds")
  public Long getStart() {
    return start;
  }

  public void setStart(Long start) {
    this.start = start;
  }

  public MeetingDeprecated end(Long end) {
    this.end = end;
    return this;
  }

   /**
   * A [UNIX Timestamp](https://currentmillis.com/) in milliseconds
   * @return end
  **/
  @ApiModelProperty(required = true, value = "A [UNIX Timestamp](https://currentmillis.com/) in milliseconds")
  public Long getEnd() {
    return end;
  }

  public void setEnd(Long end) {
    this.end = end;
  }

  public MeetingDeprecated timezone(String timezone) {
    this.timezone = timezone;
    return this;
  }

   /**
   * Get timezone
   * @return timezone
  **/
  @ApiModelProperty(value = "")
  public String getTimezone() {
    return timezone;
  }

  public void setTimezone(String timezone) {
    this.timezone = timezone;
  }

   /**
   * The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.
   * @return numericMeetingId
  **/
  @ApiModelProperty(value = "The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.")
  public String getNumericMeetingId() {
    return numericMeetingId;
  }

   /**
   * Get attendeePasscode
   * @return attendeePasscode
  **/
  @ApiModelProperty(value = "")
  public String getAttendeePasscode() {
    return attendeePasscode;
  }

  public MeetingDeprecated isPersonalMeeting(Boolean isPersonalMeeting) {
    this.isPersonalMeeting = isPersonalMeeting;
    return this;
  }

   /**
   * Use the scheduler&#39;s personal meeting room and Id for this meeting.
   * @return isPersonalMeeting
  **/
  @ApiModelProperty(value = "Use the scheduler's personal meeting room and Id for this meeting.")
  public Boolean isIsPersonalMeeting() {
    return isPersonalMeeting;
  }

  public void setIsPersonalMeeting(Boolean isPersonalMeeting) {
    this.isPersonalMeeting = isPersonalMeeting;
  }

  public MeetingDeprecated isLargeMeeting(Boolean isLargeMeeting) {
    this.isLargeMeeting = isLargeMeeting;
    return this;
  }

   /**
   * If true, the meeting is assumed to be large and thus no announcement will be made when a participant joins.
   * @return isLargeMeeting
  **/
  @ApiModelProperty(value = "If true, the meeting is assumed to be large and thus no announcement will be made when a participant joins.")
  public Boolean isIsLargeMeeting() {
    return isLargeMeeting;
  }

  public void setIsLargeMeeting(Boolean isLargeMeeting) {
    this.isLargeMeeting = isLargeMeeting;
  }

  public MeetingDeprecated addAttendeePasscode(Boolean addAttendeePasscode) {
    this.addAttendeePasscode = addAttendeePasscode;
    return this;
  }

   /**
   * Indicate if you want the attendees to be forced to enter a passcode on entry for extra security. The passcode will be randomly generated at schedule and will be returned in attendeePasscode property of the meeting.
   * @return addAttendeePasscode
  **/
  @ApiModelProperty(value = "Indicate if you want the attendees to be forced to enter a passcode on entry for extra security. The passcode will be randomly generated at schedule and will be returned in attendeePasscode property of the meeting.")
  public Boolean isAddAttendeePasscode() {
    return addAttendeePasscode;
  }

  public void setAddAttendeePasscode(Boolean addAttendeePasscode) {
    this.addAttendeePasscode = addAttendeePasscode;
  }

  public MeetingDeprecated endPointVersion(String endPointVersion) {
    this.endPointVersion = endPointVersion;
    return this;
  }

   /**
   * Get endPointVersion
   * @return endPointVersion
  **/
  @ApiModelProperty(required = true, value = "")
  public String getEndPointVersion() {
    return endPointVersion;
  }

  public void setEndPointVersion(String endPointVersion) {
    this.endPointVersion = endPointVersion;
  }

  public MeetingDeprecated endPointType(String endPointType) {
    this.endPointType = endPointType;
    return this;
  }

   /**
   * Get endPointType
   * @return endPointType
  **/
  @ApiModelProperty(required = true, value = "")
  public String getEndPointType() {
    return endPointType;
  }

  public void setEndPointType(String endPointType) {
    this.endPointType = endPointType;
  }

  public MeetingDeprecated attendees(List<Attendee> attendees) {
    this.attendees = attendees;
    return this;
  }

  public MeetingDeprecated addAttendeesItem(Attendee attendeesItem) {
    if (this.attendees == null) {
      this.attendees = new ArrayList<Attendee>();
    }
    this.attendees.add(attendeesItem);
    return this;
  }

   /**
   * Get attendees
   * @return attendees
  **/
  @ApiModelProperty(value = "")
  public List<Attendee> getAttendees() {
    return attendees;
  }

  public void setAttendees(List<Attendee> attendees) {
    this.attendees = attendees;
  }

  public MeetingDeprecated advancedMeetingOptions(MeetingDeprecatedAdvancedMeetingOptions advancedMeetingOptions) {
    this.advancedMeetingOptions = advancedMeetingOptions;
    return this;
  }

   /**
   * Get advancedMeetingOptions
   * @return advancedMeetingOptions
  **/
  @ApiModelProperty(value = "")
  public MeetingDeprecatedAdvancedMeetingOptions getAdvancedMeetingOptions() {
    return advancedMeetingOptions;
  }

  public void setAdvancedMeetingOptions(MeetingDeprecatedAdvancedMeetingOptions advancedMeetingOptions) {
    this.advancedMeetingOptions = advancedMeetingOptions;
  }

  public MeetingDeprecated recurrencePattern(MeetingRecurrencePattern recurrencePattern) {
    this.recurrencePattern = recurrencePattern;
    return this;
  }

   /**
   * Get recurrencePattern
   * @return recurrencePattern
  **/
  @ApiModelProperty(value = "")
  public MeetingRecurrencePattern getRecurrencePattern() {
    return recurrencePattern;
  }

  public void setRecurrencePattern(MeetingRecurrencePattern recurrencePattern) {
    this.recurrencePattern = recurrencePattern;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    MeetingDeprecated meetingDeprecated = (MeetingDeprecated) o;
    return Objects.equals(this.id, meetingDeprecated.id) &&
        Objects.equals(this.title, meetingDeprecated.title) &&
        Objects.equals(this.description, meetingDeprecated.description) &&
        Objects.equals(this.start, meetingDeprecated.start) &&
        Objects.equals(this.end, meetingDeprecated.end) &&
        Objects.equals(this.timezone, meetingDeprecated.timezone) &&
        Objects.equals(this.numericMeetingId, meetingDeprecated.numericMeetingId) &&
        Objects.equals(this.attendeePasscode, meetingDeprecated.attendeePasscode) &&
        Objects.equals(this.isPersonalMeeting, meetingDeprecated.isPersonalMeeting) &&
        Objects.equals(this.isLargeMeeting, meetingDeprecated.isLargeMeeting) &&
        Objects.equals(this.addAttendeePasscode, meetingDeprecated.addAttendeePasscode) &&
        Objects.equals(this.endPointVersion, meetingDeprecated.endPointVersion) &&
        Objects.equals(this.endPointType, meetingDeprecated.endPointType) &&
        Objects.equals(this.attendees, meetingDeprecated.attendees) &&
        Objects.equals(this.advancedMeetingOptions, meetingDeprecated.advancedMeetingOptions) &&
        Objects.equals(this.recurrencePattern, meetingDeprecated.recurrencePattern);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, title, description, start, end, timezone, numericMeetingId, attendeePasscode, isPersonalMeeting, isLargeMeeting, addAttendeePasscode, endPointVersion, endPointType, attendees, advancedMeetingOptions, recurrencePattern);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class MeetingDeprecated {\n");
    
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    title: ").append(toIndentedString(title)).append("\n");
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
    sb.append("    start: ").append(toIndentedString(start)).append("\n");
    sb.append("    end: ").append(toIndentedString(end)).append("\n");
    sb.append("    timezone: ").append(toIndentedString(timezone)).append("\n");
    sb.append("    numericMeetingId: ").append(toIndentedString(numericMeetingId)).append("\n");
    sb.append("    attendeePasscode: ").append(toIndentedString(attendeePasscode)).append("\n");
    sb.append("    isPersonalMeeting: ").append(toIndentedString(isPersonalMeeting)).append("\n");
    sb.append("    isLargeMeeting: ").append(toIndentedString(isLargeMeeting)).append("\n");
    sb.append("    addAttendeePasscode: ").append(toIndentedString(addAttendeePasscode)).append("\n");
    sb.append("    endPointVersion: ").append(toIndentedString(endPointVersion)).append("\n");
    sb.append("    endPointType: ").append(toIndentedString(endPointType)).append("\n");
    sb.append("    attendees: ").append(toIndentedString(attendees)).append("\n");
    sb.append("    advancedMeetingOptions: ").append(toIndentedString(advancedMeetingOptions)).append("\n");
    sb.append("    recurrencePattern: ").append(toIndentedString(recurrencePattern)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
