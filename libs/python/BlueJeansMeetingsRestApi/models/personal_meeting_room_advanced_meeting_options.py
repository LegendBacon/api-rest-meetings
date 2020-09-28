# coding: utf-8

"""
    BlueJeans Meetings REST API

     ## Video That Works Where You Do. <p>This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you can see and try actual API calls to manage User Accounts, Meetings, and Recordings, pull Analytical Data and Current State information.</p>    <nosdk> <hr> <div> <div class=\"key\">     <a href=\"./basics.html\" target=\"_\"><img class=\"keyimg\" src=\"./img/bjnmeeting.png\"/></a> </div> <div class=\"keybox\"> Basic instructions about What is a BlueJeans Meeting, and Getting Started Using API's, are <a href=\"./basics.html\" target=\"_blank\">available here <i class=\"glyphicon glyphicon-new-window\"></i></a>. </div> </div> <hr> <alert>2/21/2019</alert> Change response of Change layout and Endpoint API's to 204<br/> 12/03/2018 Add API for setting user profile photograph.<br/> 10/17/2018 Updated API field definitions for time variables to be 64-bit .<br/> 7/23/2018 Corrected errors in API definition file.<br/> 7/10/2018 Deprecated some Command Center API's.  Exposed API's that Summarize usage.<br/> 7/06/2018 Added API for changing ownership of recordings.<br/> 6/28/2018 Restored Create Enterprise Account, added Enterprise and User Profile Tag API's.<br/> 6/01/2018 Clarified Access Token requirements for meeting endpoint API's.<br/> 5/21/2018 Corrected return model for meeting history call.<br/> </nosdk> <hr>   # noqa: E501

    OpenAPI spec version: 1.0.4402212019
    Contact: glenn@bluejeans.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


import pprint
import re  # noqa: F401

import six

from BlueJeansMeetingsRestApi.models.personal_meeting_room_advanced_meeting_options_editability import PersonalMeetingRoomAdvancedMeetingOptionsEditability  # noqa: F401,E501


class PersonalMeetingRoomAdvancedMeetingOptions(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """

    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'video_best_fit': 'bool',
        'publish_meeting': 'bool',
        'encryption_type': 'str',
        'moderator_less': 'bool',
        'allow_stream': 'bool',
        'auto_record': 'bool',
        'disallow_chat': 'bool',
        'mute_participants_on_entry': 'bool',
        'show_all_attendees_in_meeting_invite': 'bool',
        'editability': 'PersonalMeetingRoomAdvancedMeetingOptionsEditability'
    }

    attribute_map = {
        'video_best_fit': 'videoBestFit',
        'publish_meeting': 'publishMeeting',
        'encryption_type': 'encryptionType',
        'moderator_less': 'moderatorLess',
        'allow_stream': 'allowStream',
        'auto_record': 'autoRecord',
        'disallow_chat': 'disallowChat',
        'mute_participants_on_entry': 'muteParticipantsOnEntry',
        'show_all_attendees_in_meeting_invite': 'showAllAttendeesInMeetingInvite',
        'editability': 'editability'
    }

    def __init__(self, video_best_fit=None, publish_meeting=None, encryption_type=None, moderator_less=None, allow_stream=None, auto_record=None, disallow_chat=None, mute_participants_on_entry=None, show_all_attendees_in_meeting_invite=None, editability=None):  # noqa: E501
        """PersonalMeetingRoomAdvancedMeetingOptions - a model defined in Swagger"""  # noqa: E501

        self._video_best_fit = None
        self._publish_meeting = None
        self._encryption_type = None
        self._moderator_less = None
        self._allow_stream = None
        self._auto_record = None
        self._disallow_chat = None
        self._mute_participants_on_entry = None
        self._show_all_attendees_in_meeting_invite = None
        self._editability = None
        self.discriminator = None

        if video_best_fit is not None:
            self.video_best_fit = video_best_fit
        if publish_meeting is not None:
            self.publish_meeting = publish_meeting
        if encryption_type is not None:
            self.encryption_type = encryption_type
        if moderator_less is not None:
            self.moderator_less = moderator_less
        if allow_stream is not None:
            self.allow_stream = allow_stream
        if auto_record is not None:
            self.auto_record = auto_record
        if disallow_chat is not None:
            self.disallow_chat = disallow_chat
        if mute_participants_on_entry is not None:
            self.mute_participants_on_entry = mute_participants_on_entry
        if show_all_attendees_in_meeting_invite is not None:
            self.show_all_attendees_in_meeting_invite = show_all_attendees_in_meeting_invite
        if editability is not None:
            self.editability = editability

    @property
    def video_best_fit(self):
        """Gets the video_best_fit of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501

        Same user ID as passed in path parameter.  # noqa: E501

        :return: The video_best_fit of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501
        :rtype: bool
        """
        return self._video_best_fit

    @video_best_fit.setter
    def video_best_fit(self, video_best_fit):
        """Sets the video_best_fit of this PersonalMeetingRoomAdvancedMeetingOptions.

        Same user ID as passed in path parameter.  # noqa: E501

        :param video_best_fit: The video_best_fit of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501
        :type: bool
        """

        self._video_best_fit = video_best_fit

    @property
    def publish_meeting(self):
        """Gets the publish_meeting of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501

        Same user ID as passed in path parameter.  # noqa: E501

        :return: The publish_meeting of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501
        :rtype: bool
        """
        return self._publish_meeting

    @publish_meeting.setter
    def publish_meeting(self, publish_meeting):
        """Sets the publish_meeting of this PersonalMeetingRoomAdvancedMeetingOptions.

        Same user ID as passed in path parameter.  # noqa: E501

        :param publish_meeting: The publish_meeting of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501
        :type: bool
        """

        self._publish_meeting = publish_meeting

    @property
    def encryption_type(self):
        """Gets the encryption_type of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501

        How this meeting is to be encrypted.  # noqa: E501

        :return: The encryption_type of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501
        :rtype: str
        """
        return self._encryption_type

    @encryption_type.setter
    def encryption_type(self, encryption_type):
        """Sets the encryption_type of this PersonalMeetingRoomAdvancedMeetingOptions.

        How this meeting is to be encrypted.  # noqa: E501

        :param encryption_type: The encryption_type of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501
        :type: str
        """
        allowed_values = ["NO_ENCRYPTION", "ENCRYPTED_ONLY", "ENCRYPTED_OR_PSTN_ONLY"]  # noqa: E501
        if encryption_type not in allowed_values:
            raise ValueError(
                "Invalid value for `encryption_type` ({0}), must be one of {1}"  # noqa: E501
                .format(encryption_type, allowed_values)
            )

        self._encryption_type = encryption_type

    @property
    def moderator_less(self):
        """Gets the moderator_less of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501

        If set require that a user enter's a moderator passcode to start meeting.  # noqa: E501

        :return: The moderator_less of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501
        :rtype: bool
        """
        return self._moderator_less

    @moderator_less.setter
    def moderator_less(self, moderator_less):
        """Sets the moderator_less of this PersonalMeetingRoomAdvancedMeetingOptions.

        If set require that a user enter's a moderator passcode to start meeting.  # noqa: E501

        :param moderator_less: The moderator_less of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501
        :type: bool
        """

        self._moderator_less = moderator_less

    @property
    def allow_stream(self):
        """Gets the allow_stream of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501

        Allow sending of streamed video  # noqa: E501

        :return: The allow_stream of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501
        :rtype: bool
        """
        return self._allow_stream

    @allow_stream.setter
    def allow_stream(self, allow_stream):
        """Sets the allow_stream of this PersonalMeetingRoomAdvancedMeetingOptions.

        Allow sending of streamed video  # noqa: E501

        :param allow_stream: The allow_stream of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501
        :type: bool
        """

        self._allow_stream = allow_stream

    @property
    def auto_record(self):
        """Gets the auto_record of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501

        By default start recording anytime 2 or more join this room.  # noqa: E501

        :return: The auto_record of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501
        :rtype: bool
        """
        return self._auto_record

    @auto_record.setter
    def auto_record(self, auto_record):
        """Sets the auto_record of this PersonalMeetingRoomAdvancedMeetingOptions.

        By default start recording anytime 2 or more join this room.  # noqa: E501

        :param auto_record: The auto_record of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501
        :type: bool
        """

        self._auto_record = auto_record

    @property
    def disallow_chat(self):
        """Gets the disallow_chat of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501

        If set, disable the ability to send chat message within this meeting.  # noqa: E501

        :return: The disallow_chat of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501
        :rtype: bool
        """
        return self._disallow_chat

    @disallow_chat.setter
    def disallow_chat(self, disallow_chat):
        """Sets the disallow_chat of this PersonalMeetingRoomAdvancedMeetingOptions.

        If set, disable the ability to send chat message within this meeting.  # noqa: E501

        :param disallow_chat: The disallow_chat of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501
        :type: bool
        """

        self._disallow_chat = disallow_chat

    @property
    def mute_participants_on_entry(self):
        """Gets the mute_participants_on_entry of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501

        If set, force each joining participant to be muted.  # noqa: E501

        :return: The mute_participants_on_entry of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501
        :rtype: bool
        """
        return self._mute_participants_on_entry

    @mute_participants_on_entry.setter
    def mute_participants_on_entry(self, mute_participants_on_entry):
        """Sets the mute_participants_on_entry of this PersonalMeetingRoomAdvancedMeetingOptions.

        If set, force each joining participant to be muted.  # noqa: E501

        :param mute_participants_on_entry: The mute_participants_on_entry of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501
        :type: bool
        """

        self._mute_participants_on_entry = mute_participants_on_entry

    @property
    def show_all_attendees_in_meeting_invite(self):
        """Gets the show_all_attendees_in_meeting_invite of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501

        When sending email invitations, include the exhaustive list of invited people.  # noqa: E501

        :return: The show_all_attendees_in_meeting_invite of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501
        :rtype: bool
        """
        return self._show_all_attendees_in_meeting_invite

    @show_all_attendees_in_meeting_invite.setter
    def show_all_attendees_in_meeting_invite(self, show_all_attendees_in_meeting_invite):
        """Sets the show_all_attendees_in_meeting_invite of this PersonalMeetingRoomAdvancedMeetingOptions.

        When sending email invitations, include the exhaustive list of invited people.  # noqa: E501

        :param show_all_attendees_in_meeting_invite: The show_all_attendees_in_meeting_invite of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501
        :type: bool
        """

        self._show_all_attendees_in_meeting_invite = show_all_attendees_in_meeting_invite

    @property
    def editability(self):
        """Gets the editability of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501


        :return: The editability of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501
        :rtype: PersonalMeetingRoomAdvancedMeetingOptionsEditability
        """
        return self._editability

    @editability.setter
    def editability(self, editability):
        """Sets the editability of this PersonalMeetingRoomAdvancedMeetingOptions.


        :param editability: The editability of this PersonalMeetingRoomAdvancedMeetingOptions.  # noqa: E501
        :type: PersonalMeetingRoomAdvancedMeetingOptionsEditability
        """

        self._editability = editability

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value
        if issubclass(PersonalMeetingRoomAdvancedMeetingOptions, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, PersonalMeetingRoomAdvancedMeetingOptions):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other