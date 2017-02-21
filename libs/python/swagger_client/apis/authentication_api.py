# coding: utf-8

"""
    BlueJeans onVideo REST API

    _Video That Works Where You Do, from the world's leader in cloud video communication._ # Authentication Each API request that is sent to BlueJeans requires an access token, which is obtained through the BlueJeans Authentication API. There are several methods (grant types) for obtaining an access token, which follow the OAuth2.0 specification. ## Grant Types * Authorization Code Grant – This grant type is used in an authentication flow commonly referred to as \"three-legged OAuth\". The user authenticates via a BlueJeans page, which provides an authorization code. This code, along with a few other elements, can be used to obtain an access code. * Password Credentials Grant – This grant type is used in a two-legged OAuth flow. Username and password are sent to retrieve an access code. * Client Credentials Grant – This grant type is used in a two-legged OAuth flow.  ## Access & Permissions The access level that is associated with each access token is referred to as the scope. There are three basic levels of access that BlueJeans allows, which affect the level of scope.  Three access levels exist within the Blue Jeans service today. * Meeting-level – Authentication takes place using a meeting ID and passcode, and the scope is limited to APIs that relate to the individual meeting. * User-level – Authentication either takes place via three-legged OAuth, or else a direct authorization token request containing a username or password. Access level depends on the requested scope permissions. * App-level – An application is provisioned either by BlueJeans personnel, or within the BlueJeans Enterprise Admin interface. When provisioning an app, a client key and secret are provided, which is then used to obtain an access token, via the BlueJeans Authentication API. The scope that is associated with the token will provide access to an entire enterprise and all of its users.  All endpoints in this document that require Enterprise Admin access will be marked as such. ## Testing In order to make effective use of this page, you will first use one of the authentication methods to obtain an access token. Once the token is given, use the Authenticate button up in the header to store the token. Each BlueJeans API called after that will use the access token provided. 

    OpenAPI spec version: 1.0.0
    Contact: brandon@bluejeans.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

        http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.
"""

from __future__ import absolute_import

import sys
import os
import re

# python 2 and python 3 compatibility library
from six import iteritems

from ..configuration import Configuration
from ..api_client import ApiClient


class AuthenticationApi(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    Ref: https://github.com/swagger-api/swagger-codegen
    """

    def __init__(self, api_client=None):
        config = Configuration()
        if api_client:
            self.api_client = api_client
        else:
            if not config.api_client:
                config.api_client = ApiClient()
            self.api_client = config.api_client

    def get_token_by_client(self, grant_type_client, **kwargs):
        """
        Authentication via Client Grant Type
        This grant type is commonly used by an app. Client ID and Secret are provisioned within the BlueJeans Enterprise Administration console.

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.get_token_by_client(grant_type_client, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param GrantTypeClient grant_type_client: Contains information about the type of grant you are requesting. (required)
        :return: GrantClient
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('callback'):
            return self.get_token_by_client_with_http_info(grant_type_client, **kwargs)
        else:
            (data) = self.get_token_by_client_with_http_info(grant_type_client, **kwargs)
            return data

    def get_token_by_client_with_http_info(self, grant_type_client, **kwargs):
        """
        Authentication via Client Grant Type
        This grant type is commonly used by an app. Client ID and Secret are provisioned within the BlueJeans Enterprise Administration console.

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.get_token_by_client_with_http_info(grant_type_client, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param GrantTypeClient grant_type_client: Contains information about the type of grant you are requesting. (required)
        :return: GrantClient
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['grant_type_client']
        all_params.append('callback')
        all_params.append('_return_http_data_only')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method get_token_by_client" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'grant_type_client' is set
        if ('grant_type_client' not in params) or (params['grant_type_client'] is None):
            raise ValueError("Missing the required parameter `grant_type_client` when calling `get_token_by_client`")

        resource_path = '/oauth2/token?Client'.replace('{format}', 'json')
        path_params = {}

        query_params = {}

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        if 'grant_type_client' in params:
            body_params = params['grant_type_client']

        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])
        if not header_params['Accept']:
            del header_params['Accept']

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.\
            select_header_content_type(['application/json'])

        # Authentication setting
        auth_settings = ['access_token']

        return self.api_client.call_api(resource_path, 'POST',
                                            path_params,
                                            query_params,
                                            header_params,
                                            body=body_params,
                                            post_params=form_params,
                                            files=local_var_files,
                                            response_type='GrantClient',
                                            auth_settings=auth_settings,
                                            callback=params.get('callback'),
                                            _return_http_data_only=params.get('_return_http_data_only'))

    def get_token_by_meeting(self, grant_type_meeting, **kwargs):
        """
        Authentication via Meeting Grant Type
        This is not a traditional OAuth grant type, but it behaves closely to the password grant type. This level of authentication allows for obtaining access to the meeting only. If a Moderator passcode is sent, moderator privileges are granted. If an Attendee access code is passed, the access token will have a limited scope of access that an attendee has within a meeting.

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.get_token_by_meeting(grant_type_meeting, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param GrantTypeMeeting grant_type_meeting: Contains information about the type of grant you are requesting. (required)
        :return: GrantMeeting
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('callback'):
            return self.get_token_by_meeting_with_http_info(grant_type_meeting, **kwargs)
        else:
            (data) = self.get_token_by_meeting_with_http_info(grant_type_meeting, **kwargs)
            return data

    def get_token_by_meeting_with_http_info(self, grant_type_meeting, **kwargs):
        """
        Authentication via Meeting Grant Type
        This is not a traditional OAuth grant type, but it behaves closely to the password grant type. This level of authentication allows for obtaining access to the meeting only. If a Moderator passcode is sent, moderator privileges are granted. If an Attendee access code is passed, the access token will have a limited scope of access that an attendee has within a meeting.

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.get_token_by_meeting_with_http_info(grant_type_meeting, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param GrantTypeMeeting grant_type_meeting: Contains information about the type of grant you are requesting. (required)
        :return: GrantMeeting
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['grant_type_meeting']
        all_params.append('callback')
        all_params.append('_return_http_data_only')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method get_token_by_meeting" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'grant_type_meeting' is set
        if ('grant_type_meeting' not in params) or (params['grant_type_meeting'] is None):
            raise ValueError("Missing the required parameter `grant_type_meeting` when calling `get_token_by_meeting`")

        resource_path = '/oauth2/token?Meeting'.replace('{format}', 'json')
        path_params = {}

        query_params = {}

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        if 'grant_type_meeting' in params:
            body_params = params['grant_type_meeting']

        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])
        if not header_params['Accept']:
            del header_params['Accept']

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.\
            select_header_content_type(['application/json'])

        # Authentication setting
        auth_settings = ['access_token']

        return self.api_client.call_api(resource_path, 'POST',
                                            path_params,
                                            query_params,
                                            header_params,
                                            body=body_params,
                                            post_params=form_params,
                                            files=local_var_files,
                                            response_type='GrantMeeting',
                                            auth_settings=auth_settings,
                                            callback=params.get('callback'),
                                            _return_http_data_only=params.get('_return_http_data_only'))

    def get_token_by_password(self, grant_type_password, **kwargs):
        """
        Authentication via Password Grant Type
        An access token can be obtained by using a user’s username and password.

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.get_token_by_password(grant_type_password, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param GrantTypePassword grant_type_password: Contains information about the type of grant you are requesting. (required)
        :return: GrantPassword
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('callback'):
            return self.get_token_by_password_with_http_info(grant_type_password, **kwargs)
        else:
            (data) = self.get_token_by_password_with_http_info(grant_type_password, **kwargs)
            return data

    def get_token_by_password_with_http_info(self, grant_type_password, **kwargs):
        """
        Authentication via Password Grant Type
        An access token can be obtained by using a user’s username and password.

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.get_token_by_password_with_http_info(grant_type_password, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param GrantTypePassword grant_type_password: Contains information about the type of grant you are requesting. (required)
        :return: GrantPassword
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['grant_type_password']
        all_params.append('callback')
        all_params.append('_return_http_data_only')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method get_token_by_password" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'grant_type_password' is set
        if ('grant_type_password' not in params) or (params['grant_type_password'] is None):
            raise ValueError("Missing the required parameter `grant_type_password` when calling `get_token_by_password`")

        resource_path = '/oauth2/token?Password'.replace('{format}', 'json')
        path_params = {}

        query_params = {}

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        if 'grant_type_password' in params:
            body_params = params['grant_type_password']

        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])
        if not header_params['Accept']:
            del header_params['Accept']

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.\
            select_header_content_type(['application/json'])

        # Authentication setting
        auth_settings = ['access_token']

        return self.api_client.call_api(resource_path, 'POST',
                                            path_params,
                                            query_params,
                                            header_params,
                                            body=body_params,
                                            post_params=form_params,
                                            files=local_var_files,
                                            response_type='GrantPassword',
                                            auth_settings=auth_settings,
                                            callback=params.get('callback'),
                                            _return_http_data_only=params.get('_return_http_data_only'))