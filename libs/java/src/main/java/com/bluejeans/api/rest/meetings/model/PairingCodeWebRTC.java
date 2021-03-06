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
import com.bluejeans.api.rest.meetings.model.PairingCodeSIPTurnservers;
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
 * PairingCodeWebRTC
 */

public class PairingCodeWebRTC {
  @SerializedName("callguid")
  private String callguid = null;

  @SerializedName("endpointGuid")
  private String endpointGuid = null;

  @SerializedName("forceTURN")
  private Boolean forceTURN = null;

  @SerializedName("pairingCode")
  private String pairingCode = null;

  @SerializedName("status")
  private Integer status = null;

  /**
   * Gets or Sets statusText
   */
  @JsonAdapter(StatusTextEnum.Adapter.class)
  public enum StatusTextEnum {
    OK("OK");

    private String value;

    StatusTextEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static StatusTextEnum fromValue(String text) {
      for (StatusTextEnum b : StatusTextEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<StatusTextEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final StatusTextEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public StatusTextEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return StatusTextEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("statusText")
  private StatusTextEnum statusText = null;

  @SerializedName("turnservers")
  private List<PairingCodeSIPTurnservers> turnservers = null;

  @SerializedName("uri")
  private String uri = null;

  @SerializedName("seamEndpointGuid")
  private String seamEndpointGuid = null;

  @SerializedName("connectionGuid")
  private String connectionGuid = null;

  @SerializedName("endpointName")
  private String endpointName = null;

  public PairingCodeWebRTC callguid(String callguid) {
    this.callguid = callguid;
    return this;
  }

   /**
   * Get callguid
   * @return callguid
  **/
  @ApiModelProperty(value = "")
  public String getCallguid() {
    return callguid;
  }

  public void setCallguid(String callguid) {
    this.callguid = callguid;
  }

  public PairingCodeWebRTC endpointGuid(String endpointGuid) {
    this.endpointGuid = endpointGuid;
    return this;
  }

   /**
   * Get endpointGuid
   * @return endpointGuid
  **/
  @ApiModelProperty(value = "")
  public String getEndpointGuid() {
    return endpointGuid;
  }

  public void setEndpointGuid(String endpointGuid) {
    this.endpointGuid = endpointGuid;
  }

  public PairingCodeWebRTC forceTURN(Boolean forceTURN) {
    this.forceTURN = forceTURN;
    return this;
  }

   /**
   * Get forceTURN
   * @return forceTURN
  **/
  @ApiModelProperty(value = "")
  public Boolean isForceTURN() {
    return forceTURN;
  }

  public void setForceTURN(Boolean forceTURN) {
    this.forceTURN = forceTURN;
  }

  public PairingCodeWebRTC pairingCode(String pairingCode) {
    this.pairingCode = pairingCode;
    return this;
  }

   /**
   * Get pairingCode
   * @return pairingCode
  **/
  @ApiModelProperty(value = "")
  public String getPairingCode() {
    return pairingCode;
  }

  public void setPairingCode(String pairingCode) {
    this.pairingCode = pairingCode;
  }

  public PairingCodeWebRTC status(Integer status) {
    this.status = status;
    return this;
  }

   /**
   * Get status
   * @return status
  **/
  @ApiModelProperty(value = "")
  public Integer getStatus() {
    return status;
  }

  public void setStatus(Integer status) {
    this.status = status;
  }

  public PairingCodeWebRTC statusText(StatusTextEnum statusText) {
    this.statusText = statusText;
    return this;
  }

   /**
   * Get statusText
   * @return statusText
  **/
  @ApiModelProperty(value = "")
  public StatusTextEnum getStatusText() {
    return statusText;
  }

  public void setStatusText(StatusTextEnum statusText) {
    this.statusText = statusText;
  }

  public PairingCodeWebRTC turnservers(List<PairingCodeSIPTurnservers> turnservers) {
    this.turnservers = turnservers;
    return this;
  }

  public PairingCodeWebRTC addTurnserversItem(PairingCodeSIPTurnservers turnserversItem) {
    if (this.turnservers == null) {
      this.turnservers = new ArrayList<PairingCodeSIPTurnservers>();
    }
    this.turnservers.add(turnserversItem);
    return this;
  }

   /**
   * Get turnservers
   * @return turnservers
  **/
  @ApiModelProperty(value = "")
  public List<PairingCodeSIPTurnservers> getTurnservers() {
    return turnservers;
  }

  public void setTurnservers(List<PairingCodeSIPTurnservers> turnservers) {
    this.turnservers = turnservers;
  }

  public PairingCodeWebRTC uri(String uri) {
    this.uri = uri;
    return this;
  }

   /**
   * Get uri
   * @return uri
  **/
  @ApiModelProperty(value = "")
  public String getUri() {
    return uri;
  }

  public void setUri(String uri) {
    this.uri = uri;
  }

  public PairingCodeWebRTC seamEndpointGuid(String seamEndpointGuid) {
    this.seamEndpointGuid = seamEndpointGuid;
    return this;
  }

   /**
   * Globally unique identifier associated with the media component of this endpoint for this meeting.  (Typically a string starting with \&quot;seamguid:\&quot;)
   * @return seamEndpointGuid
  **/
  @ApiModelProperty(value = "Globally unique identifier associated with the media component of this endpoint for this meeting.  (Typically a string starting with \"seamguid:\")")
  public String getSeamEndpointGuid() {
    return seamEndpointGuid;
  }

  public void setSeamEndpointGuid(String seamEndpointGuid) {
    this.seamEndpointGuid = seamEndpointGuid;
  }

  public PairingCodeWebRTC connectionGuid(String connectionGuid) {
    this.connectionGuid = connectionGuid;
    return this;
  }

   /**
   * Globally unique identifier associated with this endpoint in this meeting. (Typically a string starting with \&quot;connguid:\&quot;)
   * @return connectionGuid
  **/
  @ApiModelProperty(value = "Globally unique identifier associated with this endpoint in this meeting. (Typically a string starting with \"connguid:\")")
  public String getConnectionGuid() {
    return connectionGuid;
  }

  public void setConnectionGuid(String connectionGuid) {
    this.connectionGuid = connectionGuid;
  }

  public PairingCodeWebRTC endpointName(String endpointName) {
    this.endpointName = endpointName;
    return this;
  }

   /**
   * Get endpointName
   * @return endpointName
  **/
  @ApiModelProperty(value = "")
  public String getEndpointName() {
    return endpointName;
  }

  public void setEndpointName(String endpointName) {
    this.endpointName = endpointName;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PairingCodeWebRTC pairingCodeWebRTC = (PairingCodeWebRTC) o;
    return Objects.equals(this.callguid, pairingCodeWebRTC.callguid) &&
        Objects.equals(this.endpointGuid, pairingCodeWebRTC.endpointGuid) &&
        Objects.equals(this.forceTURN, pairingCodeWebRTC.forceTURN) &&
        Objects.equals(this.pairingCode, pairingCodeWebRTC.pairingCode) &&
        Objects.equals(this.status, pairingCodeWebRTC.status) &&
        Objects.equals(this.statusText, pairingCodeWebRTC.statusText) &&
        Objects.equals(this.turnservers, pairingCodeWebRTC.turnservers) &&
        Objects.equals(this.uri, pairingCodeWebRTC.uri) &&
        Objects.equals(this.seamEndpointGuid, pairingCodeWebRTC.seamEndpointGuid) &&
        Objects.equals(this.connectionGuid, pairingCodeWebRTC.connectionGuid) &&
        Objects.equals(this.endpointName, pairingCodeWebRTC.endpointName);
  }

  @Override
  public int hashCode() {
    return Objects.hash(callguid, endpointGuid, forceTURN, pairingCode, status, statusText, turnservers, uri, seamEndpointGuid, connectionGuid, endpointName);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PairingCodeWebRTC {\n");
    
    sb.append("    callguid: ").append(toIndentedString(callguid)).append("\n");
    sb.append("    endpointGuid: ").append(toIndentedString(endpointGuid)).append("\n");
    sb.append("    forceTURN: ").append(toIndentedString(forceTURN)).append("\n");
    sb.append("    pairingCode: ").append(toIndentedString(pairingCode)).append("\n");
    sb.append("    status: ").append(toIndentedString(status)).append("\n");
    sb.append("    statusText: ").append(toIndentedString(statusText)).append("\n");
    sb.append("    turnservers: ").append(toIndentedString(turnservers)).append("\n");
    sb.append("    uri: ").append(toIndentedString(uri)).append("\n");
    sb.append("    seamEndpointGuid: ").append(toIndentedString(seamEndpointGuid)).append("\n");
    sb.append("    connectionGuid: ").append(toIndentedString(connectionGuid)).append("\n");
    sb.append("    endpointName: ").append(toIndentedString(endpointName)).append("\n");
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

