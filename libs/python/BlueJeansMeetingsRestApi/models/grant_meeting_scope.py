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

from BlueJeansMeetingsRestApi.models.grant_meeting_scope_meeting import GrantMeetingScopeMeeting  # noqa: F401,E501
from BlueJeansMeetingsRestApi.models.partition import Partition  # noqa: F401,E501


class GrantMeetingScope(object):
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
        'meeting': 'GrantMeetingScopeMeeting',
        'partition_name': 'str',
        'partition': 'Partition'
    }

    attribute_map = {
        'meeting': 'meeting',
        'partition_name': 'partitionName',
        'partition': 'partition'
    }

    def __init__(self, meeting=None, partition_name=None, partition=None):  # noqa: E501
        """GrantMeetingScope - a model defined in Swagger"""  # noqa: E501

        self._meeting = None
        self._partition_name = None
        self._partition = None
        self.discriminator = None

        if meeting is not None:
            self.meeting = meeting
        if partition_name is not None:
            self.partition_name = partition_name
        if partition is not None:
            self.partition = partition

    @property
    def meeting(self):
        """Gets the meeting of this GrantMeetingScope.  # noqa: E501


        :return: The meeting of this GrantMeetingScope.  # noqa: E501
        :rtype: GrantMeetingScopeMeeting
        """
        return self._meeting

    @meeting.setter
    def meeting(self, meeting):
        """Sets the meeting of this GrantMeetingScope.


        :param meeting: The meeting of this GrantMeetingScope.  # noqa: E501
        :type: GrantMeetingScopeMeeting
        """

        self._meeting = meeting

    @property
    def partition_name(self):
        """Gets the partition_name of this GrantMeetingScope.  # noqa: E501

        The name of the partition you are on.  # noqa: E501

        :return: The partition_name of this GrantMeetingScope.  # noqa: E501
        :rtype: str
        """
        return self._partition_name

    @partition_name.setter
    def partition_name(self, partition_name):
        """Sets the partition_name of this GrantMeetingScope.

        The name of the partition you are on.  # noqa: E501

        :param partition_name: The partition_name of this GrantMeetingScope.  # noqa: E501
        :type: str
        """

        self._partition_name = partition_name

    @property
    def partition(self):
        """Gets the partition of this GrantMeetingScope.  # noqa: E501


        :return: The partition of this GrantMeetingScope.  # noqa: E501
        :rtype: Partition
        """
        return self._partition

    @partition.setter
    def partition(self, partition):
        """Sets the partition of this GrantMeetingScope.


        :param partition: The partition of this GrantMeetingScope.  # noqa: E501
        :type: Partition
        """

        self._partition = partition

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
        if issubclass(GrantMeetingScope, dict):
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
        if not isinstance(other, GrantMeetingScope):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other