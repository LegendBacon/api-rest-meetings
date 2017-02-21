# swagger_client
_Video That Works Where You Do, from the world's leader in cloud video communication._ # Authentication Each API request that is sent to BlueJeans requires an access token, which is obtained through the BlueJeans Authentication API. There are several methods (grant types) for obtaining an access token, which follow the OAuth2.0 specification. ## Grant Types * Authorization Code Grant – This grant type is used in an authentication flow commonly referred to as \"three-legged OAuth\". The user authenticates via a BlueJeans page, which provides an authorization code. This code, along with a few other elements, can be used to obtain an access code. * Password Credentials Grant – This grant type is used in a two-legged OAuth flow. Username and password are sent to retrieve an access code. * Client Credentials Grant – This grant type is used in a two-legged OAuth flow.  ## Access & Permissions The access level that is associated with each access token is referred to as the scope. There are three basic levels of access that BlueJeans allows, which affect the level of scope.  Three access levels exist within the Blue Jeans service today. * Meeting-level – Authentication takes place using a meeting ID and passcode, and the scope is limited to APIs that relate to the individual meeting. * User-level – Authentication either takes place via three-legged OAuth, or else a direct authorization token request containing a username or password. Access level depends on the requested scope permissions. * App-level – An application is provisioned either by BlueJeans personnel, or within the BlueJeans Enterprise Admin interface. When provisioning an app, a client key and secret are provided, which is then used to obtain an access token, via the BlueJeans Authentication API. The scope that is associated with the token will provide access to an entire enterprise and all of its users.  All endpoints in this document that require Enterprise Admin access will be marked as such. ## Testing In order to make effective use of this page, you will first use one of the authentication methods to obtain an access token. Once the token is given, use the Authenticate button up in the header to store the token. Each BlueJeans API called after that will use the access token provided. 

This Python package is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0
- Package version: 1.0.0
- Build date: 2017-02-21T16:41:32.140-07:00
- Build package: class io.swagger.codegen.languages.PythonClientCodegen
For more information, please visit [http://bluejeans.com/](http://bluejeans.com/)

## Requirements.

Python 2.7 and 3.4+

## Installation & Usage
### pip install

If the python package is hosted on Github, you can install directly from Github

```sh
pip install git+https://github.com/GIT_USER_ID/GIT_REPO_ID.git
```
(you may need to run `pip` with root permission: `sudo pip install git+https://github.com/GIT_USER_ID/GIT_REPO_ID.git`)

Then import the package:
```python
import swagger_client 
```

### Setuptools

Install via [Setuptools](http://pypi.python.org/pypi/setuptools).

```sh
python setup.py install --user
```
(or `sudo python setup.py install` to install the package for all users)

Then import the package:
```python
import swagger_client
```

## Getting Started

Please follow the [installation procedure](#installation--usage) and then run the following:

```python
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# Configure API key authorization: access_token
swagger_client.configuration.api_key['access_token'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# swagger_client.configuration.api_key_prefix['access_token'] = 'Bearer'
# create an instance of the API class
api_instance = swagger_client.AnalyticsApi
enterprise_id = 56 # int | The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.
filter = '[{\"type\":\"date\",\"comparison\":\"gt\",\"value\":\"2017-01-16T00:00:00-07:00\",\"field\":\"creation_time\"},{\"type\":\"date\",\"comparison\":\"lt\",\"value\":\"2017-01-23T23:59:59-07:00\",\"field\":\"creation_time\"}]' # str | URL-encoded JSON string (optional) (default to [{"type":"date","comparison":"gt","value":"2017-01-16T00:00:00-07:00","field":"creation_time"},{"type":"date","comparison":"lt","value":"2017-01-23T23:59:59-07:00","field":"creation_time"}])

try:
    # Endpoint Distribution
    api_response = api_instance.get_endpoint_distribution(enterprise_id, filter=filter)
    pprint(api_response)
except ApiException as e:
    print "Exception when calling AnalyticsApi->get_endpoint_distribution: %s\n" % e

```

## Documentation for API Endpoints

All URIs are relative to *https://api.bluejeans.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AnalyticsApi* | [**get_endpoint_distribution**](docs/AnalyticsApi.md#get_endpoint_distribution) | **GET** /v1/enterprise/{enterprise_id}/indigo/analytics/endpoints/distribution | Endpoint Distribution
*AnalyticsApi* | [**get_feedback_comments**](docs/AnalyticsApi.md#get_feedback_comments) | **GET** /v1/enterprise/{enterprise_id}/indigo/analytics/feedback/comments | Survey Feedback Comments
*AnalyticsApi* | [**get_feedback_count**](docs/AnalyticsApi.md#get_feedback_count) | **GET** /v1/enterprise/{enterprise_id}/indigo/feedback/count | Survey Feedback Scores
*AnalyticsApi* | [**get_meeting_usage**](docs/AnalyticsApi.md#get_meeting_usage) | **GET** /v1/enterprise/{enterprise_id}/indigo/analytics/meetings/usage | Meeting Usage Over Time
*AnalyticsApi* | [**get_roi_ranges**](docs/AnalyticsApi.md#get_roi_ranges) | **GET** /v1/enterprise/{enterprise_id}/indigo/analytics/roi_ranges | ROI Data
*AnalyticsApi* | [**get_top_users**](docs/AnalyticsApi.md#get_top_users) | **GET** /v1/enterprise/{enterprise_id}/indigo/analytics/users/usage | Top Users
*AuthenticationApi* | [**get_token_by_client**](docs/AuthenticationApi.md#get_token_by_client) | **POST** /oauth2/token?Client | Authentication via Client Grant Type
*AuthenticationApi* | [**get_token_by_meeting**](docs/AuthenticationApi.md#get_token_by_meeting) | **POST** /oauth2/token?Meeting | Authentication via Meeting Grant Type
*AuthenticationApi* | [**get_token_by_password**](docs/AuthenticationApi.md#get_token_by_password) | **POST** /oauth2/token?Password | Authentication via Password Grant Type
*CommandCenterApi* | [**v1_enterprise_enterprise_id_indigo_meetings_get**](docs/CommandCenterApi.md#v1_enterprise_enterprise_id_indigo_meetings_get) | **GET** /v1/enterprise/{enterprise_id}/indigo/meetings | List Past Meetings by Enterprise
*CommandCenterApi* | [**v1_enterprise_enterprise_id_indigo_meetings_live_get**](docs/CommandCenterApi.md#v1_enterprise_enterprise_id_indigo_meetings_live_get) | **GET** /v1/enterprise/{enterprise_id}/indigo/meetings/live | Live Meetings Summary by Enterprise
*CommandCenterApi* | [**v1_enterprise_enterprise_id_indigo_meetings_live_meeting_guid_endpoints_get**](docs/CommandCenterApi.md#v1_enterprise_enterprise_id_indigo_meetings_live_meeting_guid_endpoints_get) | **GET** /v1/enterprise/{enterprise_id}/indigo/meetings/live/{meeting_guid}/endpoints/ | List Live Meeting Endpoints by Enterprise
*CommandCenterApi* | [**v1_enterprise_enterprise_id_indigo_meetings_meeting_guid_get**](docs/CommandCenterApi.md#v1_enterprise_enterprise_id_indigo_meetings_meeting_guid_get) | **GET** /v1/enterprise/{enterprise_id}/indigo/meetings/{meeting_guid} | List Meeting Endpoints &amp; Stats by Enterprise
*CommandCenterApi* | [**v1_user_user_id_indigo_meetings_get**](docs/CommandCenterApi.md#v1_user_user_id_indigo_meetings_get) | **GET** /v1/user/{user_id}/indigo/meetings | List Past Meetings by User
*CommandCenterApi* | [**v1_user_user_id_indigo_meetings_meeting_guid_get**](docs/CommandCenterApi.md#v1_user_user_id_indigo_meetings_meeting_guid_get) | **GET** /v1/user/{user_id}/indigo/meetings/{meeting_guid} | List Meeting Endpoints &amp; Stats by User
*EnterpriseApi* | [**create_user**](docs/EnterpriseApi.md#create_user) | **POST** /v1/enterprise/{enterprise_id}/users | Create Enterprise User
*EnterpriseApi* | [**list_users**](docs/EnterpriseApi.md#list_users) | **GET** /v1/enterprise/{enterprise_id}/users | List Enterprise Users
*EnterpriseApi* | [**remove_user**](docs/EnterpriseApi.md#remove_user) | **DELETE** /v1/enterprise/{enterprise_id}/users/{user_id} | Remove Enterprise User
*HistoryApi* | [**get_history_by_enterprise**](docs/HistoryApi.md#get_history_by_enterprise) | **GET** /v1/enterprise/{enterprise_id}/meeting_history/{meeting_guid} | Get Meeting History by Enterprise
*HistoryApi* | [**get_history_by_user**](docs/HistoryApi.md#get_history_by_user) | **GET** /v1/user/{user_id}/meeting_history/{meeting_guid} | Get Meeting History by User
*HistoryApi* | [**get_recording**](docs/HistoryApi.md#get_recording) | **GET** /v1/user/{user_id}/meeting_history/recordings/{recording_entity_id} | Get Recording
*HistoryApi* | [**list_history_by_enterprise**](docs/HistoryApi.md#list_history_by_enterprise) | **GET** /v1/enterprise/{enterprise_id}/meeting_history | List History by Enterprise
*HistoryApi* | [**list_history_by_user**](docs/HistoryApi.md#list_history_by_user) | **GET** /v1/user/{user_id}/meeting_history | List History by User
*HistoryApi* | [**list_recordings**](docs/HistoryApi.md#list_recordings) | **GET** /v1/user/{user_id}/meeting_history/recordings | List Meeting Recordings
*MeetingApi* | [**cancel_meeting**](docs/MeetingApi.md#cancel_meeting) | **DELETE** /v1/user/{user_id}/scheduled_meeting/{meeting_id} | Cancel Meeting
*MeetingApi* | [**create_meeting**](docs/MeetingApi.md#create_meeting) | **POST** /v1/user/{user_id}/scheduled_meeting | Create Meeting
*MeetingApi* | [**get_endpoint_layout**](docs/MeetingApi.md#get_endpoint_layout) | **GET** /v1/user/{user_id}/live_meetings/{meeting_id}/endpoints/{endpoint_guid}/layout | Get Endpoint Layout
*MeetingApi* | [**get_meeting**](docs/MeetingApi.md#get_meeting) | **GET** /v1/user/{user_id}/scheduled_meeting/{meeting_id} | Get Meeting
*MeetingApi* | [**list_meetings**](docs/MeetingApi.md#list_meetings) | **GET** /v1/user/{user_id}/scheduled_meeting | List Meetings
*MeetingApi* | [**update_endpoint_layout**](docs/MeetingApi.md#update_endpoint_layout) | **PUT** /v1/user/{user_id}/live_meetings/{meeting_id}/endpoints/{endpoint_guid}/layout | Update Endpoint Layout
*MeetingApi* | [**update_meeting**](docs/MeetingApi.md#update_meeting) | **PUT** /v1/user/{user_id}/scheduled_meeting/{meeting_id} | Update Meeting
*MeetingApi* | [**v1_user_user_id_live_meetings_meeting_id_endpoints_endpoint_guid_get**](docs/MeetingApi.md#v1_user_user_id_live_meetings_meeting_id_endpoints_endpoint_guid_get) | **GET** /v1/user/{user_id}/live_meetings/{meeting_id}/endpoints/{endpoint_guid} | Get Endpoint Information
*MeetingApi* | [**v1_user_user_id_live_meetings_meeting_id_endpoints_endpoint_guid_put**](docs/MeetingApi.md#v1_user_user_id_live_meetings_meeting_id_endpoints_endpoint_guid_put) | **PUT** /v1/user/{user_id}/live_meetings/{meeting_id}/endpoints/{endpoint_guid} | Update Endpoint Video/Audio State
*MeetingApi* | [**v1_user_user_id_live_meetings_meeting_id_endpoints_get**](docs/MeetingApi.md#v1_user_user_id_live_meetings_meeting_id_endpoints_get) | **GET** /v1/user/{user_id}/live_meetings/{meeting_id}/endpoints | List Meeting Endpoints
*MeetingApi* | [**v1_user_user_id_live_meetings_meeting_id_endpoints_put**](docs/MeetingApi.md#v1_user_user_id_live_meetings_meeting_id_endpoints_put) | **PUT** /v1/user/{user_id}/live_meetings/{meeting_id}/endpoints | Update Meeting Endpoints State
*MeetingApi* | [**v1_user_user_id_live_meetings_meeting_id_get**](docs/MeetingApi.md#v1_user_user_id_live_meetings_meeting_id_get) | **GET** /v1/user/{user_id}/live_meetings/{meeting_id} | Get Meeting State
*MeetingApi* | [**v1_user_user_id_live_meetings_meeting_id_invite_post**](docs/MeetingApi.md#v1_user_user_id_live_meetings_meeting_id_invite_post) | **POST** /v1/user/{user_id}/live_meetings/{meeting_id}/invite | Send Email Invite
*MeetingApi* | [**v1_user_user_id_live_meetings_meeting_id_pairing_code_sip_post**](docs/MeetingApi.md#v1_user_user_id_live_meetings_meeting_id_pairing_code_sip_post) | **POST** /v1/user/{user_id}/live_meetings/{meeting_id}/pairing_code/sip | Generate Pairing Code (SIP)
*MeetingApi* | [**v1_user_user_id_live_meetings_meeting_id_pairing_code_webrtc_post**](docs/MeetingApi.md#v1_user_user_id_live_meetings_meeting_id_pairing_code_webrtc_post) | **POST** /v1/user/{user_id}/live_meetings/{meeting_id}/pairing_code/webrtc | Generate Pairing Code (WebRTC)
*MeetingApi* | [**v1_user_user_id_live_meetings_meeting_id_put**](docs/MeetingApi.md#v1_user_user_id_live_meetings_meeting_id_put) | **PUT** /v1/user/{user_id}/live_meetings/{meeting_id} | Update Meeting State
*MeetingApi* | [**v1_user_user_id_meetings_meeting_id_numbers_get**](docs/MeetingApi.md#v1_user_user_id_meetings_meeting_id_numbers_get) | **GET** /v1/user/{user_id}/meetings/{meeting_id}/numbers | Get Meeting Join Info
*MeetingApi* | [**v1_user_user_id_scheduled_meeting_meeting_id_emails_get**](docs/MeetingApi.md#v1_user_user_id_scheduled_meeting_meeting_id_emails_get) | **GET** /v1/user/{user_id}/scheduled_meeting/{meeting_id}/emails | Get Meeting Email
*RecordingApi* | [**get_recording_content**](docs/RecordingApi.md#get_recording_content) | **GET** /v1/user/{user_id}/cms/{content_id}?isDownloadable&#x3D;true | Get Recording Download Link
*RecordingApi* | [**start_recording**](docs/RecordingApi.md#start_recording) | **POST** /v1/user/{user_id}/live_meetings/{meeting_id}/recordings/?action&#x3D;start | Start Recording
*RecordingApi* | [**stop_recording**](docs/RecordingApi.md#stop_recording) | **PUT** /v1/user/{user_id}/live_meetings/{meeting_id}/recordings?action&#x3D;stop | Stop Recording
*RecordingApi* | [**v1_user_user_id_live_meetings_meeting_id_recordings_get**](docs/RecordingApi.md#v1_user_user_id_live_meetings_meeting_id_recordings_get) | **GET** /v1/user/{user_id}/live_meetings/{meeting_id}/recordings | Get All Recordings for a Specified Meeting ID
*RecordingApi* | [**v1_user_user_id_live_meetings_meeting_id_recordingsmeeting_guidmeeting_guid_get**](docs/RecordingApi.md#v1_user_user_id_live_meetings_meeting_id_recordingsmeeting_guidmeeting_guid_get) | **GET** /v1/user/{user_id}/live_meetings/{meeting_id}/recordings?meetingGuid&#x3D;{meeting_guid} | Get All Recordings for a Specified Meeting GUID
*RecordingApi* | [**v1_user_user_id_meeting_history_meeting_guid_recordings_delete**](docs/RecordingApi.md#v1_user_user_id_meeting_history_meeting_guid_recordings_delete) | **DELETE** /v1/user/{user_id}/meeting_history/{meeting_guid}/recordings | Delete All Recordings for a Specified Meeting GUID
*RecordingApi* | [**v1_user_user_id_meeting_history_meeting_id_recordings_recording_chapter_id_delete**](docs/RecordingApi.md#v1_user_user_id_meeting_history_meeting_id_recordings_recording_chapter_id_delete) | **DELETE** /v1/user/{user_id}/meeting_history/{meeting_id}/recordings/{recording_chapter_id}/ | Delete a Specified Recording Chapter
*UserApi* | [**get_enterprise_profile**](docs/UserApi.md#get_enterprise_profile) | **GET** /v1/user/{user_id}/enterprise_profile | Get Enterprise Profile
*UserApi* | [**get_room**](docs/UserApi.md#get_room) | **GET** /v1/user/{user_id}/room | Get User’s Default Meeting Settings
*UserApi* | [**get_user**](docs/UserApi.md#get_user) | **GET** /v1/user/{user_id} | Get User Account Details
*UserApi* | [**update_room**](docs/UserApi.md#update_room) | **PUT** /v1/user/{user_id}/room | Update User’s Default Meeting Settings
*UserApi* | [**update_user**](docs/UserApi.md#update_user) | **PUT** /v1/user/{user_id} | Update User Account Details


## Documentation For Models

 - [AnalyticsEndpointDistribution](docs/AnalyticsEndpointDistribution.md)
 - [AnalyticsEndpointDistributionDistribution](docs/AnalyticsEndpointDistributionDistribution.md)
 - [AnalyticsFeedbackComments](docs/AnalyticsFeedbackComments.md)
 - [AnalyticsFeedbackCommentsComments](docs/AnalyticsFeedbackCommentsComments.md)
 - [AnalyticsFeedbackScores](docs/AnalyticsFeedbackScores.md)
 - [AnalyticsRoiData](docs/AnalyticsRoiData.md)
 - [AnalyticsRoiDataRoiRanges](docs/AnalyticsRoiDataRoiRanges.md)
 - [AnalyticsTopUsers](docs/AnalyticsTopUsers.md)
 - [AnalyticsTopUsersUsage](docs/AnalyticsTopUsersUsage.md)
 - [AnalyticsUsage](docs/AnalyticsUsage.md)
 - [AnalyticsUsageUsage](docs/AnalyticsUsageUsage.md)
 - [Content](docs/Content.md)
 - [ContentContentProperties](docs/ContentContentProperties.md)
 - [ContentContentPropertiesLevels](docs/ContentContentPropertiesLevels.md)
 - [Endpoint](docs/Endpoint.md)
 - [Endpoints](docs/Endpoints.md)
 - [EndpointsInner](docs/EndpointsInner.md)
 - [EndpointsInnerConnections](docs/EndpointsInnerConnections.md)
 - [Enterprise](docs/Enterprise.md)
 - [EnterpriseUserList](docs/EnterpriseUserList.md)
 - [EnterpriseUserListUsers](docs/EnterpriseUserListUsers.md)
 - [Error](docs/Error.md)
 - [GrantClient](docs/GrantClient.md)
 - [GrantClientScope](docs/GrantClientScope.md)
 - [GrantMeeting](docs/GrantMeeting.md)
 - [GrantMeetingScope](docs/GrantMeetingScope.md)
 - [GrantMeetingScopeMeeting](docs/GrantMeetingScopeMeeting.md)
 - [GrantPassword](docs/GrantPassword.md)
 - [GrantPasswordScope](docs/GrantPasswordScope.md)
 - [GrantTypeClient](docs/GrantTypeClient.md)
 - [GrantTypeMeeting](docs/GrantTypeMeeting.md)
 - [GrantTypePassword](docs/GrantTypePassword.md)
 - [Layout](docs/Layout.md)
 - [Meeting](docs/Meeting.md)
 - [MeetingAdvancedMeetingOptions](docs/MeetingAdvancedMeetingOptions.md)
 - [MeetingHistory](docs/MeetingHistory.md)
 - [MeetingHistoryLeaderInfo](docs/MeetingHistoryLeaderInfo.md)
 - [MeetingHistoryParticipantList](docs/MeetingHistoryParticipantList.md)
 - [MeetingState](docs/MeetingState.md)
 - [MeetingStateRecordinginfo](docs/MeetingStateRecordinginfo.md)
 - [Numbers](docs/Numbers.md)
 - [NumbersLabel](docs/NumbersLabel.md)
 - [NumbersNumbers](docs/NumbersNumbers.md)
 - [PairingCode](docs/PairingCode.md)
 - [PairingCodeTurnservers](docs/PairingCodeTurnservers.md)
 - [Partition](docs/Partition.md)
 - [PayloadInvite](docs/PayloadInvite.md)
 - [PayloadMeetingState](docs/PayloadMeetingState.md)
 - [PayloadPairingCodeSIP](docs/PayloadPairingCodeSIP.md)
 - [PayloadPairingCodeWebRTC](docs/PayloadPairingCodeWebRTC.md)
 - [Recording](docs/Recording.md)
 - [RecordingRecordingChapters](docs/RecordingRecordingChapters.md)
 - [RecordingRecordingSessions](docs/RecordingRecordingSessions.md)
 - [RecordingStartedBy](docs/RecordingStartedBy.md)
 - [RecordingSummary](docs/RecordingSummary.md)
 - [Room](docs/Room.md)
 - [User](docs/User.md)
 - [UserId](docs/UserId.md)


## Documentation For Authorization


## access_token

- **Type**: API key
- **API key parameter name**: access_token
- **Location**: URL query string


## Author

brandon@bluejeans.com
