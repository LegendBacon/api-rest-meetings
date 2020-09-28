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
import com.bluejeans.api.rest.meetings.model.RecordingSession;
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
 * RecordingHistory
 */

public class RecordingHistory {
  @SerializedName("chapterId")
  private String chapterId = null;

  @SerializedName("id")
  private Integer id = null;

  @SerializedName("startTimeOffset")
  private Integer startTimeOffset = null;

  @SerializedName("endTimeOffset")
  private Integer endTimeOffset = null;

  @SerializedName("chapterName")
  private String chapterName = null;

  @SerializedName("totalSize")
  private Integer totalSize = null;

  @SerializedName("compositeContentId")
  private Integer compositeContentId = null;

  /**
   * Gets or Sets compositeContentStatus
   */
  @JsonAdapter(CompositeContentStatusEnum.Adapter.class)
  public enum CompositeContentStatusEnum {
    PROCESSED("PROCESSED");

    private String value;

    CompositeContentStatusEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static CompositeContentStatusEnum fromValue(String text) {
      for (CompositeContentStatusEnum b : CompositeContentStatusEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<CompositeContentStatusEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final CompositeContentStatusEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public CompositeContentStatusEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return CompositeContentStatusEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("compositeContentStatus")
  private CompositeContentStatusEnum compositeContentStatus = null;

  @SerializedName("parentRecordingId")
  private Integer parentRecordingId = null;

  @SerializedName("viewCount")
  private Integer viewCount = null;

  @SerializedName("recordingSessions")
  private List<RecordingSession> recordingSessions = null;

  public RecordingHistory chapterId(String chapterId) {
    this.chapterId = chapterId;
    return this;
  }

   /**
   * Get chapterId
   * @return chapterId
  **/
  @ApiModelProperty(value = "")
  public String getChapterId() {
    return chapterId;
  }

  public void setChapterId(String chapterId) {
    this.chapterId = chapterId;
  }

  public RecordingHistory id(Integer id) {
    this.id = id;
    return this;
  }

   /**
   * Get id
   * @return id
  **/
  @ApiModelProperty(value = "")
  public Integer getId() {
    return id;
  }

  public void setId(Integer id) {
    this.id = id;
  }

  public RecordingHistory startTimeOffset(Integer startTimeOffset) {
    this.startTimeOffset = startTimeOffset;
    return this;
  }

   /**
   * Get startTimeOffset
   * @return startTimeOffset
  **/
  @ApiModelProperty(value = "")
  public Integer getStartTimeOffset() {
    return startTimeOffset;
  }

  public void setStartTimeOffset(Integer startTimeOffset) {
    this.startTimeOffset = startTimeOffset;
  }

  public RecordingHistory endTimeOffset(Integer endTimeOffset) {
    this.endTimeOffset = endTimeOffset;
    return this;
  }

   /**
   * Get endTimeOffset
   * @return endTimeOffset
  **/
  @ApiModelProperty(value = "")
  public Integer getEndTimeOffset() {
    return endTimeOffset;
  }

  public void setEndTimeOffset(Integer endTimeOffset) {
    this.endTimeOffset = endTimeOffset;
  }

  public RecordingHistory chapterName(String chapterName) {
    this.chapterName = chapterName;
    return this;
  }

   /**
   * Get chapterName
   * @return chapterName
  **/
  @ApiModelProperty(value = "")
  public String getChapterName() {
    return chapterName;
  }

  public void setChapterName(String chapterName) {
    this.chapterName = chapterName;
  }

  public RecordingHistory totalSize(Integer totalSize) {
    this.totalSize = totalSize;
    return this;
  }

   /**
   * Get totalSize
   * @return totalSize
  **/
  @ApiModelProperty(value = "")
  public Integer getTotalSize() {
    return totalSize;
  }

  public void setTotalSize(Integer totalSize) {
    this.totalSize = totalSize;
  }

  public RecordingHistory compositeContentId(Integer compositeContentId) {
    this.compositeContentId = compositeContentId;
    return this;
  }

   /**
   * Get compositeContentId
   * @return compositeContentId
  **/
  @ApiModelProperty(value = "")
  public Integer getCompositeContentId() {
    return compositeContentId;
  }

  public void setCompositeContentId(Integer compositeContentId) {
    this.compositeContentId = compositeContentId;
  }

  public RecordingHistory compositeContentStatus(CompositeContentStatusEnum compositeContentStatus) {
    this.compositeContentStatus = compositeContentStatus;
    return this;
  }

   /**
   * Get compositeContentStatus
   * @return compositeContentStatus
  **/
  @ApiModelProperty(value = "")
  public CompositeContentStatusEnum getCompositeContentStatus() {
    return compositeContentStatus;
  }

  public void setCompositeContentStatus(CompositeContentStatusEnum compositeContentStatus) {
    this.compositeContentStatus = compositeContentStatus;
  }

  public RecordingHistory parentRecordingId(Integer parentRecordingId) {
    this.parentRecordingId = parentRecordingId;
    return this;
  }

   /**
   * Get parentRecordingId
   * @return parentRecordingId
  **/
  @ApiModelProperty(value = "")
  public Integer getParentRecordingId() {
    return parentRecordingId;
  }

  public void setParentRecordingId(Integer parentRecordingId) {
    this.parentRecordingId = parentRecordingId;
  }

  public RecordingHistory viewCount(Integer viewCount) {
    this.viewCount = viewCount;
    return this;
  }

   /**
   * Get viewCount
   * @return viewCount
  **/
  @ApiModelProperty(value = "")
  public Integer getViewCount() {
    return viewCount;
  }

  public void setViewCount(Integer viewCount) {
    this.viewCount = viewCount;
  }

  public RecordingHistory recordingSessions(List<RecordingSession> recordingSessions) {
    this.recordingSessions = recordingSessions;
    return this;
  }

  public RecordingHistory addRecordingSessionsItem(RecordingSession recordingSessionsItem) {
    if (this.recordingSessions == null) {
      this.recordingSessions = new ArrayList<RecordingSession>();
    }
    this.recordingSessions.add(recordingSessionsItem);
    return this;
  }

   /**
   * Get recordingSessions
   * @return recordingSessions
  **/
  @ApiModelProperty(value = "")
  public List<RecordingSession> getRecordingSessions() {
    return recordingSessions;
  }

  public void setRecordingSessions(List<RecordingSession> recordingSessions) {
    this.recordingSessions = recordingSessions;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RecordingHistory recordingHistory = (RecordingHistory) o;
    return Objects.equals(this.chapterId, recordingHistory.chapterId) &&
        Objects.equals(this.id, recordingHistory.id) &&
        Objects.equals(this.startTimeOffset, recordingHistory.startTimeOffset) &&
        Objects.equals(this.endTimeOffset, recordingHistory.endTimeOffset) &&
        Objects.equals(this.chapterName, recordingHistory.chapterName) &&
        Objects.equals(this.totalSize, recordingHistory.totalSize) &&
        Objects.equals(this.compositeContentId, recordingHistory.compositeContentId) &&
        Objects.equals(this.compositeContentStatus, recordingHistory.compositeContentStatus) &&
        Objects.equals(this.parentRecordingId, recordingHistory.parentRecordingId) &&
        Objects.equals(this.viewCount, recordingHistory.viewCount) &&
        Objects.equals(this.recordingSessions, recordingHistory.recordingSessions);
  }

  @Override
  public int hashCode() {
    return Objects.hash(chapterId, id, startTimeOffset, endTimeOffset, chapterName, totalSize, compositeContentId, compositeContentStatus, parentRecordingId, viewCount, recordingSessions);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RecordingHistory {\n");
    
    sb.append("    chapterId: ").append(toIndentedString(chapterId)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    startTimeOffset: ").append(toIndentedString(startTimeOffset)).append("\n");
    sb.append("    endTimeOffset: ").append(toIndentedString(endTimeOffset)).append("\n");
    sb.append("    chapterName: ").append(toIndentedString(chapterName)).append("\n");
    sb.append("    totalSize: ").append(toIndentedString(totalSize)).append("\n");
    sb.append("    compositeContentId: ").append(toIndentedString(compositeContentId)).append("\n");
    sb.append("    compositeContentStatus: ").append(toIndentedString(compositeContentStatus)).append("\n");
    sb.append("    parentRecordingId: ").append(toIndentedString(parentRecordingId)).append("\n");
    sb.append("    viewCount: ").append(toIndentedString(viewCount)).append("\n");
    sb.append("    recordingSessions: ").append(toIndentedString(recordingSessions)).append("\n");
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
