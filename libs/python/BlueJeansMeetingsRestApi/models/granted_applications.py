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


class GrantedApplications(object):
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
        'app_name': 'str',
        'app_description': 'str',
        'client_id': 'str',
        'user_id': 'int',
        'scope': 'str'
    }

    attribute_map = {
        'app_name': 'appName',
        'app_description': 'appDescription',
        'client_id': 'clientId',
        'user_id': 'userId',
        'scope': 'scope'
    }

    def __init__(self, app_name=None, app_description=None, client_id=None, user_id=None, scope=None):  # noqa: E501
        """GrantedApplications - a model defined in Swagger"""  # noqa: E501

        self._app_name = None
        self._app_description = None
        self._client_id = None
        self._user_id = None
        self._scope = None
        self.discriminator = None

        if app_name is not None:
            self.app_name = app_name
        if app_description is not None:
            self.app_description = app_description
        if client_id is not None:
            self.client_id = client_id
        if user_id is not None:
            self.user_id = user_id
        if scope is not None:
            self.scope = scope

    @property
    def app_name(self):
        """Gets the app_name of this GrantedApplications.  # noqa: E501

        Name of the Application  # noqa: E501

        :return: The app_name of this GrantedApplications.  # noqa: E501
        :rtype: str
        """
        return self._app_name

    @app_name.setter
    def app_name(self, app_name):
        """Sets the app_name of this GrantedApplications.

        Name of the Application  # noqa: E501

        :param app_name: The app_name of this GrantedApplications.  # noqa: E501
        :type: str
        """

        self._app_name = app_name

    @property
    def app_description(self):
        """Gets the app_description of this GrantedApplications.  # noqa: E501

        A summary of the client application.  # noqa: E501

        :return: The app_description of this GrantedApplications.  # noqa: E501
        :rtype: str
        """
        return self._app_description

    @app_description.setter
    def app_description(self, app_description):
        """Sets the app_description of this GrantedApplications.

        A summary of the client application.  # noqa: E501

        :param app_description: The app_description of this GrantedApplications.  # noqa: E501
        :type: str
        """

        self._app_description = app_description

    @property
    def client_id(self):
        """Gets the client_id of this GrantedApplications.  # noqa: E501

        The client ID will be generated on creation of the application. Normally, a 32 character hexadecimal numeric string.  # noqa: E501

        :return: The client_id of this GrantedApplications.  # noqa: E501
        :rtype: str
        """
        return self._client_id

    @client_id.setter
    def client_id(self, client_id):
        """Sets the client_id of this GrantedApplications.

        The client ID will be generated on creation of the application. Normally, a 32 character hexadecimal numeric string.  # noqa: E501

        :param client_id: The client_id of this GrantedApplications.  # noqa: E501
        :type: str
        """

        self._client_id = client_id

    @property
    def user_id(self):
        """Gets the user_id of this GrantedApplications.  # noqa: E501

        Same user ID as passed in path parameter.  # noqa: E501

        :return: The user_id of this GrantedApplications.  # noqa: E501
        :rtype: int
        """
        return self._user_id

    @user_id.setter
    def user_id(self, user_id):
        """Sets the user_id of this GrantedApplications.

        Same user ID as passed in path parameter.  # noqa: E501

        :param user_id: The user_id of this GrantedApplications.  # noqa: E501
        :type: int
        """

        self._user_id = user_id

    @property
    def scope(self):
        """Gets the scope of this GrantedApplications.  # noqa: E501

        Comma-delimited list of granted permissions to the application.  # noqa: E501

        :return: The scope of this GrantedApplications.  # noqa: E501
        :rtype: str
        """
        return self._scope

    @scope.setter
    def scope(self, scope):
        """Sets the scope of this GrantedApplications.

        Comma-delimited list of granted permissions to the application.  # noqa: E501

        :param scope: The scope of this GrantedApplications.  # noqa: E501
        :type: str
        """

        self._scope = scope

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
        if issubclass(GrantedApplications, dict):
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
        if not isinstance(other, GrantedApplications):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other