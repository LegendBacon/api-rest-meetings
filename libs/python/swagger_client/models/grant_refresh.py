# coding: utf-8

"""
    BlueJeans onVideo REST API

    _Video That Works Where You Do._  This site provides developers access to API's from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data as well retrieve current state information.  With these API's  you should be able to quickly integrate **BlueJeans** video into your applications.     # Authentication All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ## Grant Types Bluejeans provides 3 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to the user. * Authorization Code Grant – Authenticate via a BlueJeans page, and receive an authorization code. Submit authorization with other tokens and receive an access code. (\"three-legged OAuth\") * Password Credentials Grant – Authenticate with a Username and password and receives an access code. (\"two-legged OAuth\"); * Client Credentials Grant – Similar to Password Grant (\"two-legged OAuth\").  ## Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – scope of APIs is limited to individual meetings. * User-level – scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users.  All endpoints in this document that require **Enterprise Admin** access will be marked as such. # Getting Started Before you start using the API's on this site, you must first have a BlueJeans account.  With your BlueJean credentials, use one of the Authentication methods to obtain an access token. - Click on the Authorize button at the top of page - Enter your access token in the field marked \"api_key\" Now the web site will automatically include your access token on all API calls you make. 

    OpenAPI spec version: 1.0.0
    Contact: brandon@bluejeans.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


from pprint import pformat
from six import iteritems
import re


class GrantRefresh(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self, access_token=None, refresh_token=None, expires_in=None, scope=None):
        """
        GrantRefresh - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'access_token': 'str',
            'refresh_token': 'str',
            'expires_in': 'int',
            'scope': 'GrantCodeScope'
        }

        self.attribute_map = {
            'access_token': 'access_token',
            'refresh_token': 'refresh_token',
            'expires_in': 'expires_in',
            'scope': 'scope'
        }

        self._access_token = access_token
        self._refresh_token = refresh_token
        self._expires_in = expires_in
        self._scope = scope

    @property
    def access_token(self):
        """
        Gets the access_token of this GrantRefresh.
        The access token acts as a kind of \"valet key\" that the application can include with its requests to the identity provider, which prove that it has permission from the user to access those APIs.

        :return: The access_token of this GrantRefresh.
        :rtype: str
        """
        return self._access_token

    @access_token.setter
    def access_token(self, access_token):
        """
        Sets the access_token of this GrantRefresh.
        The access token acts as a kind of \"valet key\" that the application can include with its requests to the identity provider, which prove that it has permission from the user to access those APIs.

        :param access_token: The access_token of this GrantRefresh.
        :type: str
        """

        self._access_token = access_token

    @property
    def refresh_token(self):
        """
        Gets the refresh_token of this GrantRefresh.
        A longer lasting token that may be used to retrieve new access tokens upon access token expiration.

        :return: The refresh_token of this GrantRefresh.
        :rtype: str
        """
        return self._refresh_token

    @refresh_token.setter
    def refresh_token(self, refresh_token):
        """
        Sets the refresh_token of this GrantRefresh.
        A longer lasting token that may be used to retrieve new access tokens upon access token expiration.

        :param refresh_token: The refresh_token of this GrantRefresh.
        :type: str
        """

        self._refresh_token = refresh_token

    @property
    def expires_in(self):
        """
        Gets the expires_in of this GrantRefresh.
        Seconds that access token is valid for from now.

        :return: The expires_in of this GrantRefresh.
        :rtype: int
        """
        return self._expires_in

    @expires_in.setter
    def expires_in(self, expires_in):
        """
        Sets the expires_in of this GrantRefresh.
        Seconds that access token is valid for from now.

        :param expires_in: The expires_in of this GrantRefresh.
        :type: int
        """

        self._expires_in = expires_in

    @property
    def scope(self):
        """
        Gets the scope of this GrantRefresh.

        :return: The scope of this GrantRefresh.
        :rtype: GrantCodeScope
        """
        return self._scope

    @scope.setter
    def scope(self, scope):
        """
        Sets the scope of this GrantRefresh.

        :param scope: The scope of this GrantRefresh.
        :type: GrantCodeScope
        """

        self._scope = scope

    def to_dict(self):
        """
        Returns the model properties as a dict
        """
        result = {}

        for attr, _ in iteritems(self.swagger_types):
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

        return result

    def to_str(self):
        """
        Returns the string representation of the model
        """
        return pformat(self.to_dict())

    def __repr__(self):
        """
        For `print` and `pprint`
        """
        return self.to_str()

    def __eq__(self, other):
        """
        Returns true if both objects are equal
        """
        if not isinstance(other, GrantRefresh):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """
        Returns true if both objects are not equal
        """
        return not self == other
