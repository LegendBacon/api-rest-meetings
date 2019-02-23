# BlueJeansMeetingsRestApi.MeetingApi

All URIs are relative to *https://api.bluejeans.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**cancelMeeting**](MeetingApi.md#cancelMeeting) | **DELETE** /v1/user/{user_id}/scheduled_meeting/{meeting_id} | Cancel Meeting
[**createMeeting**](MeetingApi.md#createMeeting) | **POST** /v1/user/{user_id}/scheduled_meeting | Create Meeting
[**dialoutPstn**](MeetingApi.md#dialoutPstn) | **POST** /v1/user/{user_id}/live_meetings/{numeric_meeting_id}/dialout/pstn | Dialout via PSTN
[**generatePairingCodePstn**](MeetingApi.md#generatePairingCodePstn) | **POST** /v1/user/{user_id}/live_meetings/{numeric_meeting_id}/pairing_code/PSTN | Generate Pairing Code (PSTN)
[**generatePairingCodeSip**](MeetingApi.md#generatePairingCodeSip) | **POST** /v1/user/{user_id}/live_meetings/{numeric_meeting_id}/pairing_code/SIP | Generate Pairing Code (SIP)
[**generatePairingCodeWebRtc**](MeetingApi.md#generatePairingCodeWebRtc) | **POST** /v1/user/{user_id}/live_meetings/{numeric_meeting_id}/pairing_code/webrtc | Generate Pairing Code (WebRTC)
[**getEndpointLayout**](MeetingApi.md#getEndpointLayout) | **GET** /v1/user/{user_id}/live_meetings/{numeric_meeting_id}/endpoints/{endpoint_guid}/layout | Get Endpoint Layout
[**getMeeting**](MeetingApi.md#getMeeting) | **GET** /v1/user/{user_id}/scheduled_meeting/{meeting_id} | Get Meeting
[**getMeetingEmails**](MeetingApi.md#getMeetingEmails) | **GET** /v1/user/{user_id}/scheduled_meeting/{meeting_id}/emails | Get Meeting Email
[**getMeetingEndpoint**](MeetingApi.md#getMeetingEndpoint) | **GET** /v1/user/{user_id}/live_meetings/{numeric_meeting_id}/endpoints/{endpoint_guid} | Get Endpoint Information
[**getMeetingEndpoints**](MeetingApi.md#getMeetingEndpoints) | **GET** /v1/user/{user_id}/live_meetings/{numeric_meeting_id}/endpoints | List Meeting Endpoints
[**getMeetingNumbers**](MeetingApi.md#getMeetingNumbers) | **GET** /v1/user/{user_id}/meetings/{meeting_id}/numbers | Get Meeting Join Info
[**getMeetingState**](MeetingApi.md#getMeetingState) | **GET** /v1/user/{user_id}/live_meetings/{numeric_meeting_id} | Get Meeting State
[**listMeetings**](MeetingApi.md#listMeetings) | **GET** /v1/user/{user_id}/scheduled_meeting | List Meetings
[**sendMeetingInvite**](MeetingApi.md#sendMeetingInvite) | **POST** /v1/user/{user_id}/live_meetings/{numeric_meeting_id}/invite | Send Email Invite
[**updateEndpointLayout**](MeetingApi.md#updateEndpointLayout) | **PUT** /v1/user/{user_id}/live_meetings/{numeric_meeting_id}/endpoints/{endpoint_guid}/layout | Update Endpoint Layout
[**updateMeeting**](MeetingApi.md#updateMeeting) | **PUT** /v1/user/{user_id}/scheduled_meeting/{meeting_id} | Update Meeting
[**updateMeetingEndpoint**](MeetingApi.md#updateMeetingEndpoint) | **PUT** /v1/user/{user_id}/live_meetings/{numeric_meeting_id}/endpoints/{endpoint_guid} | Update Endpoint Video/Audio State
[**updateMeetingEndpoints**](MeetingApi.md#updateMeetingEndpoints) | **PUT** /v1/user/{user_id}/live_meetings/{numeric_meeting_id}/endpoints | Update Meeting Endpoints State
[**updateMeetingState**](MeetingApi.md#updateMeetingState) | **PUT** /v1/user/{user_id}/live_meetings/{numeric_meeting_id} | Update Meeting State


<a name="cancelMeeting"></a>
# **cancelMeeting**
> cancelMeeting(userId, meetingId, opts)

Cancel Meeting

This endpoint deletes a scheuled meeting.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR ACCESS TOKEN';
access_token.name   = "access_token";
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.MeetingApi();

var userId = 56; // Number | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.

var meetingId = 56; // Number | The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \"id\" property.

var opts = { 
  'email': false, // Boolean | Dispatch an email to participants with the specified cancellation message.
  'cancellationMessage': "cancellationMessage_example" // String | Message sent to participants when meeting is deleted and email is selected
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.cancelMeeting(userId, meetingId, opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. | 
 **meetingId** | **Number**| The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property. | 
 **email** | **Boolean**| Dispatch an email to participants with the specified cancellation message. | [optional] [default to false]
 **cancellationMessage** | **String**| Message sent to participants when meeting is deleted and email is selected | [optional] 

### Return type

null (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="createMeeting"></a>
# **createMeeting**
> Meeting createMeeting(userId, meeting, opts)

Create Meeting

This endpoint will create a scheduled meeting.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR ACCESS TOKEN';
access_token.name   = "access_token";
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.MeetingApi();

var userId = 56; // Number | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.

var meeting = new BlueJeansMeetingsRestApi.ScheduleMeetingMinComp(); // ScheduleMeetingMinComp | The desired configuration for the meeting. (<b>NOTE</b> The model provided here is a <i>typical</i> minimum set of meeting parameters.)

var opts = { 
  'email': true // Boolean | If set to true, sends invitation emails to all listed participants.
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.createMeeting(userId, meeting, opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. | 
 **meeting** | [**ScheduleMeetingMinComp**](ScheduleMeetingMinComp.md)| The desired configuration for the meeting. (&lt;b&gt;NOTE&lt;/b&gt; The model provided here is a &lt;i&gt;typical&lt;/i&gt; minimum set of meeting parameters.) | 
 **email** | **Boolean**| If set to true, sends invitation emails to all listed participants. | [optional] 

### Return type

[**Meeting**](Meeting.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="dialoutPstn"></a>
# **dialoutPstn**
> DialoutPstn dialoutPstn(userId, numericMeetingId, payloadDialout)

Dialout via PSTN

Places a PSTN call to a user to join meeting. **Note:** call this API using a meeting access token

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR ACCESS TOKEN';
access_token.name   = "access_token";
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.MeetingApi();

var userId = 56; // Number | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.

var numericMeetingId = 56; // Number | The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.

var payloadDialout = new BlueJeansMeetingsRestApi.PayloadDialout(); // PayloadDialout | 


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.dialoutPstn(userId, numericMeetingId, payloadDialout, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. | 
 **numericMeetingId** | **Number**| The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. | 
 **payloadDialout** | [**PayloadDialout**](PayloadDialout.md)|  | 

### Return type

[**DialoutPstn**](DialoutPstn.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="generatePairingCodePstn"></a>
# **generatePairingCodePstn**
> PairingCodePSTN generatePairingCodePstn(userId, numericMeetingId, payloadPairingCodePstn, opts)

Generate Pairing Code (PSTN)

This endpoint generates a PSTN pairing code that can be used to connect to a meeting via telephone. **Note:** call this API using a meeting access token

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR ACCESS TOKEN';
access_token.name   = "access_token";
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.MeetingApi();

var userId = 56; // Number | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.

var numericMeetingId = 56; // Number | The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.

var payloadPairingCodePstn = new BlueJeansMeetingsRestApi.PayloadPairingCodePstn(); // PayloadPairingCodePstn | 

var opts = { 
  'role': "USER" // String | 
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.generatePairingCodePstn(userId, numericMeetingId, payloadPairingCodePstn, opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. | 
 **numericMeetingId** | **Number**| The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. | 
 **payloadPairingCodePstn** | [**PayloadPairingCodePstn**](PayloadPairingCodePstn.md)|  | 
 **role** | **String**|  | [optional] [default to USER]

### Return type

[**PairingCodePSTN**](PairingCodePSTN.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="generatePairingCodeSip"></a>
# **generatePairingCodeSip**
> PairingCodeSIP generatePairingCodeSip(userId, numericMeetingId, payloadPairingCodeSIP)

Generate Pairing Code (SIP)

This endpoint generates a SIP pairing code that can be used to connect to a meeting. **Note:** call this API using a meeting access token

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR ACCESS TOKEN';
access_token.name   = "access_token";
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.MeetingApi();

var userId = 56; // Number | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.

var numericMeetingId = 56; // Number | The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.

var payloadPairingCodeSIP = new BlueJeansMeetingsRestApi.PayloadPairingCodeSIP(); // PayloadPairingCodeSIP | Information about the device that will be joining via SIP.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.generatePairingCodeSip(userId, numericMeetingId, payloadPairingCodeSIP, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. | 
 **numericMeetingId** | **Number**| The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. | 
 **payloadPairingCodeSIP** | [**PayloadPairingCodeSIP**](PayloadPairingCodeSIP.md)| Information about the device that will be joining via SIP. | 

### Return type

[**PairingCodeSIP**](PairingCodeSIP.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="generatePairingCodeWebRtc"></a>
# **generatePairingCodeWebRtc**
> PairingCodeWebRTC generatePairingCodeWebRtc(userId, numericMeetingId, payloadPairingCodeWebRTC, opts)

Generate Pairing Code (WebRTC)

This endpoint generates a WebRTC pairing code that can be used to connect to a meeting. **Note:** call this API using a meeting access token

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR ACCESS TOKEN';
access_token.name   = "access_token";
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.MeetingApi();

var userId = 56; // Number | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.

var numericMeetingId = 56; // Number | The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.

var payloadPairingCodeWebRTC = new BlueJeansMeetingsRestApi.PayloadPairingCodeWebRTC(); // PayloadPairingCodeWebRTC | 

var opts = { 
  'role': "USER" // String | 
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.generatePairingCodeWebRtc(userId, numericMeetingId, payloadPairingCodeWebRTC, opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. | 
 **numericMeetingId** | **Number**| The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. | 
 **payloadPairingCodeWebRTC** | [**PayloadPairingCodeWebRTC**](PayloadPairingCodeWebRTC.md)|  | 
 **role** | **String**|  | [optional] [default to USER]

### Return type

[**PairingCodeWebRTC**](PairingCodeWebRTC.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getEndpointLayout"></a>
# **getEndpointLayout**
> Layout getEndpointLayout(userId, numericMeetingId, endpointGuid)

Get Endpoint Layout

This endpoint allows you to retrieve an individual endpoint’s current layout setting.  Can use either of a general or meeting access token.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR ACCESS TOKEN';
access_token.name   = "access_token";
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.MeetingApi();

var userId = 56; // Number | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.

var numericMeetingId = 56; // Number | The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.

var endpointGuid = "endpointGuid_example"; // String | The GUID of an endpoint.  Usually retrieved from the List Meeting Endpoints endpoint.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getEndpointLayout(userId, numericMeetingId, endpointGuid, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. | 
 **numericMeetingId** | **Number**| The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. | 
 **endpointGuid** | **String**| The GUID of an endpoint.  Usually retrieved from the List Meeting Endpoints endpoint. | 

### Return type

[**Layout**](Layout.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getMeeting"></a>
# **getMeeting**
> Meeting getMeeting(userId, meetingId)

Get Meeting

This endpoint gets the settings for a user&#39;s meeting.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR ACCESS TOKEN';
access_token.name   = "access_token";
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.MeetingApi();

var userId = 56; // Number | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.

var meetingId = 56; // Number | The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \"id\" property. This is not the numeric meeting ID visible to users.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getMeeting(userId, meetingId, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. | 
 **meetingId** | **Number**| The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property. This is not the numeric meeting ID visible to users. | 

### Return type

[**Meeting**](Meeting.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getMeetingEmails"></a>
# **getMeetingEmails**
> MeetingEmails getMeetingEmails(userId, meetingId, opts)

Get Meeting Email

This endpoint retrieves the email object for a scheduled meeting.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR ACCESS TOKEN';
access_token.name   = "access_token";
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.MeetingApi();

var userId = 56; // Number | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.

var meetingId = 56; // Number | The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \"id\" property.

var opts = { 
  'type': "type_example", // String | TEXT, ICS, HTML
  'role': "role_example", // String | moderator, participant
  'action': "action_example" // String | create, edit, delete
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getMeetingEmails(userId, meetingId, opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. | 
 **meetingId** | **Number**| The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property. | 
 **type** | **String**| TEXT, ICS, HTML | [optional] 
 **role** | **String**| moderator, participant | [optional] 
 **action** | **String**| create, edit, delete | [optional] 

### Return type

[**MeetingEmails**](MeetingEmails.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getMeetingEndpoint"></a>
# **getMeetingEndpoint**
> Endpoint getMeetingEndpoint(userId, numericMeetingId, endpointGuid)

Get Endpoint Information

This endpoint allows you to retrieve information about an endpoint in the meeting.  Can use either of a general or meeting access token.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR ACCESS TOKEN';
access_token.name   = "access_token";
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.MeetingApi();

var userId = 56; // Number | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.

var numericMeetingId = 56; // Number | The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.

var endpointGuid = "endpointGuid_example"; // String | The GUID of an endpoint.  Usually retrieved from the List Meeting Endpoints endpoint.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getMeetingEndpoint(userId, numericMeetingId, endpointGuid, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. | 
 **numericMeetingId** | **Number**| The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. | 
 **endpointGuid** | **String**| The GUID of an endpoint.  Usually retrieved from the List Meeting Endpoints endpoint. | 

### Return type

[**Endpoint**](Endpoint.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getMeetingEndpoints"></a>
# **getMeetingEndpoints**
> Endpoints getMeetingEndpoints(userId, numericMeetingId)

List Meeting Endpoints

This endpoint returns an array of all endpoints in the current meeting.  Can use either of a general or meeting access token.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR ACCESS TOKEN';
access_token.name   = "access_token";
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.MeetingApi();

var userId = 56; // Number | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.

var numericMeetingId = 56; // Number | The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getMeetingEndpoints(userId, numericMeetingId, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. | 
 **numericMeetingId** | **Number**| The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. | 

### Return type

[**Endpoints**](Endpoints.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getMeetingNumbers"></a>
# **getMeetingNumbers**
> Numbers getMeetingNumbers(userId, meetingId)

Get Meeting Join Info

This endpoint retrieves the join information for a scheduled meeting.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR ACCESS TOKEN';
access_token.name   = "access_token";
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.MeetingApi();

var userId = 56; // Number | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.

var meetingId = 56; // Number | The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \"id\" property.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getMeetingNumbers(userId, meetingId, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. | 
 **meetingId** | **Number**| The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property. | 

### Return type

[**Numbers**](Numbers.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getMeetingState"></a>
# **getMeetingState**
> MeetingState getMeetingState(userId, numericMeetingId)

Get Meeting State

This endpoint’s purpose is to return whether the meeting is in progress or not.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR ACCESS TOKEN';
access_token.name   = "access_token";
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.MeetingApi();

var userId = 56; // Number | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.

var numericMeetingId = 56; // Number | The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getMeetingState(userId, numericMeetingId, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. | 
 **numericMeetingId** | **Number**| The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. | 

### Return type

[**MeetingState**](MeetingState.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="listMeetings"></a>
# **listMeetings**
> [Meeting] listMeetings(userId, opts)

List Meetings

This endpoint gets a list of the user&#39;s scheduled upcoming meetings.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR ACCESS TOKEN';
access_token.name   = "access_token";
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.MeetingApi();

var userId = 56; // Number | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.

var opts = { 
  'numericMeetingId': "numericMeetingId_example" // String | Filter the results by the meeting ID that participants will see and use to join the conference.
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.listMeetings(userId, opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. | 
 **numericMeetingId** | **String**| Filter the results by the meeting ID that participants will see and use to join the conference. | [optional] 

### Return type

[**[Meeting]**](Meeting.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="sendMeetingInvite"></a>
# **sendMeetingInvite**
> sendMeetingInvite(userId, numericMeetingId, payloadInvite)

Send Email Invite

This endpoint generates an email invite to the specified meeting. **Note:** call this API using a meeting access token

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR ACCESS TOKEN';
access_token.name   = "access_token";
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.MeetingApi();

var userId = 56; // Number | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.

var numericMeetingId = 56; // Number | The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.

var payloadInvite = new BlueJeansMeetingsRestApi.PayloadInvite(); // PayloadInvite | 


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.sendMeetingInvite(userId, numericMeetingId, payloadInvite, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. | 
 **numericMeetingId** | **Number**| The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. | 
 **payloadInvite** | [**PayloadInvite**](PayloadInvite.md)|  | 

### Return type

null (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="updateEndpointLayout"></a>
# **updateEndpointLayout**
> updateEndpointLayout(userId, numericMeetingId, endpointGuid, layout, opts)

Update Endpoint Layout

This endpoint allows you to update an individual endpoint’s current layout setting. Requires Meeting access token with moderator privileges

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR ACCESS TOKEN';
access_token.name   = "access_token";
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.MeetingApi();

var userId = 56; // Number | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.

var numericMeetingId = 56; // Number | The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.

var endpointGuid = "endpointGuid_example"; // String | The GUID of an endpoint.  Usually retrieved from the List Meeting Endpoints endpoint.

var layout = new BlueJeansMeetingsRestApi.Layout(); // Layout | Specifies the video layout format.

var opts = { 
  'isLeader': true, // Boolean | 
  'push': true // Boolean | Push these changes to all participants.  Requires Meeting access token with moderator privileges.
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.updateEndpointLayout(userId, numericMeetingId, endpointGuid, layout, opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. | 
 **numericMeetingId** | **Number**| The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. | 
 **endpointGuid** | **String**| The GUID of an endpoint.  Usually retrieved from the List Meeting Endpoints endpoint. | 
 **layout** | [**Layout**](Layout.md)| Specifies the video layout format. | 
 **isLeader** | **Boolean**|  | [optional] 
 **push** | **Boolean**| Push these changes to all participants.  Requires Meeting access token with moderator privileges. | [optional] 

### Return type

null (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="updateMeeting"></a>
# **updateMeeting**
> Meeting updateMeeting(userId, meetingId, meeting)

Update Meeting

This endpoint changes the settings for a user&#39;s meeting. For example, use for rescheduling.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR ACCESS TOKEN';
access_token.name   = "access_token";
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.MeetingApi();

var userId = 56; // Number | The ID of the user of interest.  This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.

var meetingId = 56; // Number | The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \"id\" property.

var meeting = new BlueJeansMeetingsRestApi.Meeting(); // Meeting | The user's room details that you wish to update.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.updateMeeting(userId, meetingId, meeting, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| The ID of the user of interest.  This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. | 
 **meetingId** | **Number**| The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property. | 
 **meeting** | [**Meeting**](Meeting.md)| The user&#39;s room details that you wish to update. | 

### Return type

[**Meeting**](Meeting.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="updateMeetingEndpoint"></a>
# **updateMeetingEndpoint**
> updateMeetingEndpoint(userId, numericMeetingId, endpointGuid, opts)

Update Endpoint Video/Audio State

This endpoint allows you to update an individual endpoint’s ability to send audio or video, and also allows removing an endpoint from the meeting. Requires Meeting access token with moderator privileges

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR ACCESS TOKEN';
access_token.name   = "access_token";
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.MeetingApi();

var userId = 56; // Number | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.

var numericMeetingId = 56; // Number | The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.

var endpointGuid = "endpointGuid_example"; // String | The GUID of an endpoint.  Usually retrieved from the List Meeting Endpoints endpoint.

var opts = { 
  'muteAudio': true, // Boolean | Toggle the audio source mute.
  'muteVideo': true, // Boolean | Toggle the video source mute.
  'leaveMeeting': true // Boolean | Remove the user from the meeting.
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.updateMeetingEndpoint(userId, numericMeetingId, endpointGuid, opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. | 
 **numericMeetingId** | **Number**| The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. | 
 **endpointGuid** | **String**| The GUID of an endpoint.  Usually retrieved from the List Meeting Endpoints endpoint. | 
 **muteAudio** | **Boolean**| Toggle the audio source mute. | [optional] 
 **muteVideo** | **Boolean**| Toggle the video source mute. | [optional] 
 **leaveMeeting** | **Boolean**| Remove the user from the meeting. | [optional] 

### Return type

null (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="updateMeetingEndpoints"></a>
# **updateMeetingEndpoints**
> updateMeetingEndpoints(userId, numericMeetingId, opts)

Update Meeting Endpoints State

This endpoint’s purpose is to be able to modify the endpoints in a meeting. Requires Meeting access token with moderator privileges

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR ACCESS TOKEN';
access_token.name   = "access_token";
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.MeetingApi();

var userId = 56; // Number | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.

var numericMeetingId = 56; // Number | The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.

var opts = { 
  'mute': true, // Boolean | Allows you to mute/unmute all participants in a meeting. Set mute to true to mute.  Set mute to false to unmute.
  'media': "media_example" // String | Specify the type of media you which to mute/unmute.
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.updateMeetingEndpoints(userId, numericMeetingId, opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. | 
 **numericMeetingId** | **Number**| The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. | 
 **mute** | **Boolean**| Allows you to mute/unmute all participants in a meeting. Set mute to true to mute.  Set mute to false to unmute. | [optional] 
 **media** | **String**| Specify the type of media you which to mute/unmute. | [optional] 

### Return type

null (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="updateMeetingState"></a>
# **updateMeetingState**
> Meeting updateMeetingState(userId, numericMeetingId, payloadMeetingState, opts)

Update Meeting State

This endpoint’s purpose is to be able to modify a meeting. Actions include locking the meeting, or terminating the meeting.  This API requires a meeting access token with moderator privileges.

### Example
```javascript
var BlueJeansMeetingsRestApi = require('bluejeans-api-rest-meetings');
var defaultClient = BlueJeansMeetingsRestApi.ApiClient.instance;

// Configure API key authorization: access_token
var access_token = defaultClient.authentications['access_token'];
access_token.apiKey = 'YOUR ACCESS TOKEN';
access_token.name   = "access_token";
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.apiKeyPrefix = 'Token';

var apiInstance = new BlueJeansMeetingsRestApi.MeetingApi();

var userId = 56; // Number | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.

var numericMeetingId = 56; // Number | The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.

var payloadMeetingState = new BlueJeansMeetingsRestApi.PayloadMeetingState(); // PayloadMeetingState | The meeting properties that you wish to update.

var opts = { 
  'delay': 56 // Number | Number of seconds to delay the end meeting operation.
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.updateMeetingState(userId, numericMeetingId, payloadMeetingState, opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **Number**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. | 
 **numericMeetingId** | **Number**| The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. | 
 **payloadMeetingState** | [**PayloadMeetingState**](PayloadMeetingState.md)| The meeting properties that you wish to update. | 
 **delay** | **Number**| Number of seconds to delay the end meeting operation. | [optional] 

### Return type

[**Meeting**](Meeting.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

