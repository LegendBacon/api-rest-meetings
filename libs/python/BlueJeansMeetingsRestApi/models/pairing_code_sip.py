# coding: utf-8

"""
    BlueJeans Meetings REST API

     ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.    <alert>7/010/2018 </alert>Deprecated some Command Center API's.  Exposed API's that Summarize usage.<br/> 7/06/2018 Added API for changing ownership of recordings.<br/> 6/28/2018 Restored Create Enterprise Account, added Enterprise and User Profile Tag API's.<br/> 6/01/2018 Clarified Access Token requirements for meeting endpoint API's.<br/> 5/21/2018 Corrected return model for meeting history call.<br/> <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 

    OpenAPI spec version: 1.0.0.mm44 (7/06/2018)
    Contact: glenn@bluejeans.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


from pprint import pformat
from six import iteritems
import re


class PairingCodeSIP(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
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
        'endpoint_guid': 'str',
        'force_turn': 'bool',
        'pairing_code': 'str',
        'turnservers': 'list[PairingCodeSIPTurnservers]',
        'uri': 'str',
        'seam_endpoint_guid': 'str',
        'connection_guid': 'str'
    }

    attribute_map = {
        'endpoint_guid': 'endpointGuid',
        'force_turn': 'forceTURN',
        'pairing_code': 'pairingCode',
        'turnservers': 'turnservers',
        'uri': 'uri',
        'seam_endpoint_guid': 'seamEndpointGuid',
        'connection_guid': 'connectionGuid'
    }

    def __init__(self, endpoint_guid=None, force_turn=None, pairing_code=None, turnservers=None, uri=None, seam_endpoint_guid=None, connection_guid=None):
        """
        PairingCodeSIP - a model defined in Swagger
        """

        self._endpoint_guid = None
        self._force_turn = None
        self._pairing_code = None
        self._turnservers = None
        self._uri = None
        self._seam_endpoint_guid = None
        self._connection_guid = None

        if endpoint_guid is not None:
          self.endpoint_guid = endpoint_guid
        if force_turn is not None:
          self.force_turn = force_turn
        if pairing_code is not None:
          self.pairing_code = pairing_code
        if turnservers is not None:
          self.turnservers = turnservers
        if uri is not None:
          self.uri = uri
        if seam_endpoint_guid is not None:
          self.seam_endpoint_guid = seam_endpoint_guid
        if connection_guid is not None:
          self.connection_guid = connection_guid

    @property
    def endpoint_guid(self):
        """
        Gets the endpoint_guid of this PairingCodeSIP.

        :return: The endpoint_guid of this PairingCodeSIP.
        :rtype: str
        """
        return self._endpoint_guid

    @endpoint_guid.setter
    def endpoint_guid(self, endpoint_guid):
        """
        Sets the endpoint_guid of this PairingCodeSIP.

        :param endpoint_guid: The endpoint_guid of this PairingCodeSIP.
        :type: str
        """

        self._endpoint_guid = endpoint_guid

    @property
    def force_turn(self):
        """
        Gets the force_turn of this PairingCodeSIP.

        :return: The force_turn of this PairingCodeSIP.
        :rtype: bool
        """
        return self._force_turn

    @force_turn.setter
    def force_turn(self, force_turn):
        """
        Sets the force_turn of this PairingCodeSIP.

        :param force_turn: The force_turn of this PairingCodeSIP.
        :type: bool
        """

        self._force_turn = force_turn

    @property
    def pairing_code(self):
        """
        Gets the pairing_code of this PairingCodeSIP.

        :return: The pairing_code of this PairingCodeSIP.
        :rtype: str
        """
        return self._pairing_code

    @pairing_code.setter
    def pairing_code(self, pairing_code):
        """
        Sets the pairing_code of this PairingCodeSIP.

        :param pairing_code: The pairing_code of this PairingCodeSIP.
        :type: str
        """

        self._pairing_code = pairing_code

    @property
    def turnservers(self):
        """
        Gets the turnservers of this PairingCodeSIP.

        :return: The turnservers of this PairingCodeSIP.
        :rtype: list[PairingCodeSIPTurnservers]
        """
        return self._turnservers

    @turnservers.setter
    def turnservers(self, turnservers):
        """
        Sets the turnservers of this PairingCodeSIP.

        :param turnservers: The turnservers of this PairingCodeSIP.
        :type: list[PairingCodeSIPTurnservers]
        """

        self._turnservers = turnservers

    @property
    def uri(self):
        """
        Gets the uri of this PairingCodeSIP.

        :return: The uri of this PairingCodeSIP.
        :rtype: str
        """
        return self._uri

    @uri.setter
    def uri(self, uri):
        """
        Sets the uri of this PairingCodeSIP.

        :param uri: The uri of this PairingCodeSIP.
        :type: str
        """

        self._uri = uri

    @property
    def seam_endpoint_guid(self):
        """
        Gets the seam_endpoint_guid of this PairingCodeSIP.

        :return: The seam_endpoint_guid of this PairingCodeSIP.
        :rtype: str
        """
        return self._seam_endpoint_guid

    @seam_endpoint_guid.setter
    def seam_endpoint_guid(self, seam_endpoint_guid):
        """
        Sets the seam_endpoint_guid of this PairingCodeSIP.

        :param seam_endpoint_guid: The seam_endpoint_guid of this PairingCodeSIP.
        :type: str
        """

        self._seam_endpoint_guid = seam_endpoint_guid

    @property
    def connection_guid(self):
        """
        Gets the connection_guid of this PairingCodeSIP.

        :return: The connection_guid of this PairingCodeSIP.
        :rtype: str
        """
        return self._connection_guid

    @connection_guid.setter
    def connection_guid(self, connection_guid):
        """
        Sets the connection_guid of this PairingCodeSIP.

        :param connection_guid: The connection_guid of this PairingCodeSIP.
        :type: str
        """

        self._connection_guid = connection_guid

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
        if not isinstance(other, PairingCodeSIP):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """
        Returns true if both objects are not equal
        """
        return not self == other
