
# PersonalMeetingRoom

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **Integer** | This is a unique number that is associated with the personal meeting room. |  [optional]
**uuid** | **String** | This is a unique guid used in BlueJeans cloud that is associated with the personal meeting room. |  [optional]
**title** | **String** | This is the name associated with personal room. |  [optional]
**description** | **String** | This is a short descriptive text for the personal meeting room. |  [optional]
**start** | **Long** | This is the epoch-based starting time (in milliseconds) of the personal meeting. |  [optional]
**end** | **Long** | This is the epoch-based ending time (in milliseconds) of the personal meeting. |  [optional]
**timezone** | **String** | This is the unix timezone string describing the timezone for the meeting |  [optional]
**advancedMeetingOptions** | [**PersonalMeetingRoomAdvancedMeetingOptions**](PersonalMeetingRoomAdvancedMeetingOptions.md) |  |  [optional]
**notificationUrl** | **String** | this property is not used in the BlueJeans Meetings product |  [optional]
**notificationData** | **String** | this property is not used in the BlueJeans Meetings product |  [optional]
**moderator** | [**PersonalMeetingRoomModerator**](PersonalMeetingRoomModerator.md) |  |  [optional]
**numericMeetingId** | **String** | This is the number that a participant would enter when joining this meeting. |  [optional]
**attendeePasscode** | **String** | This is a passcode that must be provided by people joining the meeting. |  [optional]
**addAttendeePasscode** | **Boolean** | If set, causes BlueJeans to require participants to enter a passcode in order to join the meeting. |  [optional]
**deleted** | **Boolean** | If set, indicates that this meeting has been deleted. |  [optional]
**allow720p** | **Boolean** | If set allows clients to send and receive 720p video resolution. |  [optional]
**status** | **String** | This string indicates the meeting&#39;s operational status. |  [optional]
**locked** | **Boolean** | If set the meeting has been locked, and future attendees require a member to allow them to join. |  [optional]
**sequenceNumber** | **Integer** | Internal tracking number |  [optional]
**icsUid** | **String** | Internal tracking number |  [optional]
**endPointType** | **String** | This string is the name of the type of scheduling entity. |  [optional]
**endPointVersion** | **String** | This is a string that describes the version number of the endpoint type. |  [optional]
**attendees** | [**List&lt;PersonalMeetingRoomAttendees&gt;**](PersonalMeetingRoomAttendees.md) |  |  [optional]
**isLargeMeeting** | **Boolean** | If set indicates that this meeting will have a large |  [optional]
**created** | **Long** | This is the date and time (in milliseconds) when the meeting was created. |  [optional]
**lastModified** | **Long** | This is the date and time (in milliseconds) when the meeting was last changed. |  [optional]
**isExpired** | **Boolean** | If set indicates that the meeting has expired. |  [optional]
**parentMeetingId** | **Integer** | This is a unique number associated with the first meeting in a series of meetings. |  [optional]
**parentMeetingUUID** | **String** | This is the guid for the first meeting in a series of meetings. |  [optional]
**nextOccurrence** | **Integer** | This is a unique number associated with the next in a chain of meetings. |  [optional]
**timelessMeeting** | **Boolean** | This field, if set, indicates that this meeting is continously running. |  [optional]
**endlessMeeting** | **Boolean** | This field, if set, indicates that there is no end of recurring meetings. |  [optional]
**first** | [**PersonalMeetingRoomFirst**](PersonalMeetingRoomFirst.md) |  |  [optional]
**last** | [**PersonalMeetingRoomLast**](PersonalMeetingRoomLast.md) |  |  [optional]
**next** | [**PersonalMeetingRoomNext**](PersonalMeetingRoomNext.md) |  |  [optional]
**nextStart** | **Long** | This is the epoch-based starting time for the next in chain of meetings. |  [optional]
**nextEnd** | **Long** | This is the epoch-based ending time for the next in chain of meetings. |  [optional]
**isPersonalMeeting** | **Boolean** | if set, indicates that this ia personal meeting. |  [optional]
**inviteeJoinOption** | **Integer** | How Invitee should join |  [optional]



