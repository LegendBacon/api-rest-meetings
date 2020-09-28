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

from BlueJeansMeetingsRestApi.models.numbers_numbers import NumbersNumbers  # noqa: F401,E501


class Numbers(object):
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
        'meeting_id': 'str',
        'allow_direct_dial': 'bool',
        'use_attendee_passcode': 'bool',
        'pstn_numbers_url': 'str',
        'moderator_passcode': 'str',
        'precision': 'str',
        'pstn_localization_supported': 'bool',
        'partner_integrated_meeting': 'bool',
        'numbers': 'list[NumbersNumbers]'
    }

    attribute_map = {
        'meeting_id': 'meetingId',
        'allow_direct_dial': 'allowDirectDial',
        'use_attendee_passcode': 'useAttendeePasscode',
        'pstn_numbers_url': 'pstnNumbersUrl',
        'moderator_passcode': 'moderatorPasscode',
        'precision': 'precision',
        'pstn_localization_supported': 'pstnLocalizationSupported',
        'partner_integrated_meeting': 'partnerIntegratedMeeting',
        'numbers': 'numbers'
    }

    def __init__(self, meeting_id=None, allow_direct_dial=None, use_attendee_passcode=None, pstn_numbers_url=None, moderator_passcode=None, precision=None, pstn_localization_supported=None, partner_integrated_meeting=None, numbers=None):  # noqa: E501
        """Numbers - a model defined in Swagger"""  # noqa: E501

        self._meeting_id = None
        self._allow_direct_dial = None
        self._use_attendee_passcode = None
        self._pstn_numbers_url = None
        self._moderator_passcode = None
        self._precision = None
        self._pstn_localization_supported = None
        self._partner_integrated_meeting = None
        self._numbers = None
        self.discriminator = None

        if meeting_id is not None:
            self.meeting_id = meeting_id
        if allow_direct_dial is not None:
            self.allow_direct_dial = allow_direct_dial
        if use_attendee_passcode is not None:
            self.use_attendee_passcode = use_attendee_passcode
        if pstn_numbers_url is not None:
            self.pstn_numbers_url = pstn_numbers_url
        if moderator_passcode is not None:
            self.moderator_passcode = moderator_passcode
        if precision is not None:
            self.precision = precision
        if pstn_localization_supported is not None:
            self.pstn_localization_supported = pstn_localization_supported
        if partner_integrated_meeting is not None:
            self.partner_integrated_meeting = partner_integrated_meeting
        if numbers is not None:
            self.numbers = numbers

    @property
    def meeting_id(self):
        """Gets the meeting_id of this Numbers.  # noqa: E501


        :return: The meeting_id of this Numbers.  # noqa: E501
        :rtype: str
        """
        return self._meeting_id

    @meeting_id.setter
    def meeting_id(self, meeting_id):
        """Sets the meeting_id of this Numbers.


        :param meeting_id: The meeting_id of this Numbers.  # noqa: E501
        :type: str
        """

        self._meeting_id = meeting_id

    @property
    def allow_direct_dial(self):
        """Gets the allow_direct_dial of this Numbers.  # noqa: E501


        :return: The allow_direct_dial of this Numbers.  # noqa: E501
        :rtype: bool
        """
        return self._allow_direct_dial

    @allow_direct_dial.setter
    def allow_direct_dial(self, allow_direct_dial):
        """Sets the allow_direct_dial of this Numbers.


        :param allow_direct_dial: The allow_direct_dial of this Numbers.  # noqa: E501
        :type: bool
        """

        self._allow_direct_dial = allow_direct_dial

    @property
    def use_attendee_passcode(self):
        """Gets the use_attendee_passcode of this Numbers.  # noqa: E501


        :return: The use_attendee_passcode of this Numbers.  # noqa: E501
        :rtype: bool
        """
        return self._use_attendee_passcode

    @use_attendee_passcode.setter
    def use_attendee_passcode(self, use_attendee_passcode):
        """Sets the use_attendee_passcode of this Numbers.


        :param use_attendee_passcode: The use_attendee_passcode of this Numbers.  # noqa: E501
        :type: bool
        """

        self._use_attendee_passcode = use_attendee_passcode

    @property
    def pstn_numbers_url(self):
        """Gets the pstn_numbers_url of this Numbers.  # noqa: E501


        :return: The pstn_numbers_url of this Numbers.  # noqa: E501
        :rtype: str
        """
        return self._pstn_numbers_url

    @pstn_numbers_url.setter
    def pstn_numbers_url(self, pstn_numbers_url):
        """Sets the pstn_numbers_url of this Numbers.


        :param pstn_numbers_url: The pstn_numbers_url of this Numbers.  # noqa: E501
        :type: str
        """

        self._pstn_numbers_url = pstn_numbers_url

    @property
    def moderator_passcode(self):
        """Gets the moderator_passcode of this Numbers.  # noqa: E501


        :return: The moderator_passcode of this Numbers.  # noqa: E501
        :rtype: str
        """
        return self._moderator_passcode

    @moderator_passcode.setter
    def moderator_passcode(self, moderator_passcode):
        """Sets the moderator_passcode of this Numbers.


        :param moderator_passcode: The moderator_passcode of this Numbers.  # noqa: E501
        :type: str
        """

        self._moderator_passcode = moderator_passcode

    @property
    def precision(self):
        """Gets the precision of this Numbers.  # noqa: E501


        :return: The precision of this Numbers.  # noqa: E501
        :rtype: str
        """
        return self._precision

    @precision.setter
    def precision(self, precision):
        """Sets the precision of this Numbers.


        :param precision: The precision of this Numbers.  # noqa: E501
        :type: str
        """

        self._precision = precision

    @property
    def pstn_localization_supported(self):
        """Gets the pstn_localization_supported of this Numbers.  # noqa: E501


        :return: The pstn_localization_supported of this Numbers.  # noqa: E501
        :rtype: bool
        """
        return self._pstn_localization_supported

    @pstn_localization_supported.setter
    def pstn_localization_supported(self, pstn_localization_supported):
        """Sets the pstn_localization_supported of this Numbers.


        :param pstn_localization_supported: The pstn_localization_supported of this Numbers.  # noqa: E501
        :type: bool
        """

        self._pstn_localization_supported = pstn_localization_supported

    @property
    def partner_integrated_meeting(self):
        """Gets the partner_integrated_meeting of this Numbers.  # noqa: E501


        :return: The partner_integrated_meeting of this Numbers.  # noqa: E501
        :rtype: bool
        """
        return self._partner_integrated_meeting

    @partner_integrated_meeting.setter
    def partner_integrated_meeting(self, partner_integrated_meeting):
        """Sets the partner_integrated_meeting of this Numbers.


        :param partner_integrated_meeting: The partner_integrated_meeting of this Numbers.  # noqa: E501
        :type: bool
        """

        self._partner_integrated_meeting = partner_integrated_meeting

    @property
    def numbers(self):
        """Gets the numbers of this Numbers.  # noqa: E501


        :return: The numbers of this Numbers.  # noqa: E501
        :rtype: list[NumbersNumbers]
        """
        return self._numbers

    @numbers.setter
    def numbers(self, numbers):
        """Sets the numbers of this Numbers.


        :param numbers: The numbers of this Numbers.  # noqa: E501
        :type: list[NumbersNumbers]
        """

        self._numbers = numbers

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
        if issubclass(Numbers, dict):
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
        if not isinstance(other, Numbers):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other