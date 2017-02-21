/* 
 * BlueJeans onVideo REST API
 *
 * _Video That Works Where You Do, from the world's leader in cloud video communication._ # Authentication Each API request that is sent to BlueJeans requires an access token, which is obtained through the BlueJeans Authentication API. There are several methods (grant types) for obtaining an access token, which follow the OAuth2.0 specification. ## Grant Types * Authorization Code Grant – This grant type is used in an authentication flow commonly referred to as \"three-legged OAuth\". The user authenticates via a BlueJeans page, which provides an authorization code. This code, along with a few other elements, can be used to obtain an access code. * Password Credentials Grant – This grant type is used in a two-legged OAuth flow. Username and password are sent to retrieve an access code. * Client Credentials Grant – This grant type is used in a two-legged OAuth flow.  ## Access & Permissions The access level that is associated with each access token is referred to as the scope. There are three basic levels of access that BlueJeans allows, which affect the level of scope.  Three access levels exist within the Blue Jeans service today. * Meeting-level – Authentication takes place using a meeting ID and passcode, and the scope is limited to APIs that relate to the individual meeting. * User-level – Authentication either takes place via three-legged OAuth, or else a direct authorization token request containing a username or password. Access level depends on the requested scope permissions. * App-level – An application is provisioned either by BlueJeans personnel, or within the BlueJeans Enterprise Admin interface. When provisioning an app, a client key and secret are provided, which is then used to obtain an access token, via the BlueJeans Authentication API. The scope that is associated with the token will provide access to an entire enterprise and all of its users.  All endpoints in this document that require Enterprise Admin access will be marked as such. ## Testing In order to make effective use of this page, you will first use one of the authentication methods to obtain an access token. Once the token is given, use the Authenticate button up in the header to store the token. Each BlueJeans API called after that will use the access token provided. 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing MeetingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MeetingApiTests
    {
        private MeetingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MeetingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MeetingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MeetingApi
            //Assert.IsInstanceOfType(typeof(MeetingApi), instance, "instance is a MeetingApi");
        }

        
        /// <summary>
        /// Test CancelMeeting
        /// </summary>
        [Test]
        public void CancelMeetingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? meetingId = null;
            //instance.CancelMeeting(userId, meetingId);
            
        }
        
        /// <summary>
        /// Test CreateMeeting
        /// </summary>
        [Test]
        public void CreateMeetingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //Meeting meeting = null;
            //bool? email = null;
            //var response = instance.CreateMeeting(userId, meeting, email);
            //Assert.IsInstanceOf<Meeting> (response, "response is Meeting");
        }
        
        /// <summary>
        /// Test GetEndpointLayout
        /// </summary>
        [Test]
        public void GetEndpointLayoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? meetingId = null;
            //string endpointGuid = null;
            //var response = instance.GetEndpointLayout(userId, meetingId, endpointGuid);
            //Assert.IsInstanceOf<Layout> (response, "response is Layout");
        }
        
        /// <summary>
        /// Test GetMeeting
        /// </summary>
        [Test]
        public void GetMeetingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? meetingId = null;
            //var response = instance.GetMeeting(userId, meetingId);
            //Assert.IsInstanceOf<Meeting> (response, "response is Meeting");
        }
        
        /// <summary>
        /// Test ListMeetings
        /// </summary>
        [Test]
        public void ListMeetingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //var response = instance.ListMeetings(userId);
            //Assert.IsInstanceOf<List<Meeting>> (response, "response is List<Meeting>");
        }
        
        /// <summary>
        /// Test UpdateEndpointLayout
        /// </summary>
        [Test]
        public void UpdateEndpointLayoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? meetingId = null;
            //string endpointGuid = null;
            //bool? isLeader = null;
            //bool? push = null;
            //var response = instance.UpdateEndpointLayout(userId, meetingId, endpointGuid, isLeader, push);
            //Assert.IsInstanceOf<Layout> (response, "response is Layout");
        }
        
        /// <summary>
        /// Test UpdateMeeting
        /// </summary>
        [Test]
        public void UpdateMeetingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? meetingId = null;
            //Meeting meeting = null;
            //var response = instance.UpdateMeeting(userId, meetingId, meeting);
            //Assert.IsInstanceOf<Meeting> (response, "response is Meeting");
        }
        
        /// <summary>
        /// Test V1UserUserIdLiveMeetingsMeetingIdEndpointsEndpointGuidGet
        /// </summary>
        [Test]
        public void V1UserUserIdLiveMeetingsMeetingIdEndpointsEndpointGuidGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? meetingId = null;
            //string endpointGuid = null;
            //var response = instance.V1UserUserIdLiveMeetingsMeetingIdEndpointsEndpointGuidGet(userId, meetingId, endpointGuid);
            //Assert.IsInstanceOf<Endpoint> (response, "response is Endpoint");
        }
        
        /// <summary>
        /// Test V1UserUserIdLiveMeetingsMeetingIdEndpointsEndpointGuidPut
        /// </summary>
        [Test]
        public void V1UserUserIdLiveMeetingsMeetingIdEndpointsEndpointGuidPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? meetingId = null;
            //string endpointGuid = null;
            //bool? muteAudio = null;
            //bool? muteVideo = null;
            //bool? leaveMeeting = null;
            //var response = instance.V1UserUserIdLiveMeetingsMeetingIdEndpointsEndpointGuidPut(userId, meetingId, endpointGuid, muteAudio, muteVideo, leaveMeeting);
            //Assert.IsInstanceOf<Endpoint> (response, "response is Endpoint");
        }
        
        /// <summary>
        /// Test V1UserUserIdLiveMeetingsMeetingIdEndpointsGet
        /// </summary>
        [Test]
        public void V1UserUserIdLiveMeetingsMeetingIdEndpointsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? meetingId = null;
            //var response = instance.V1UserUserIdLiveMeetingsMeetingIdEndpointsGet(userId, meetingId);
            //Assert.IsInstanceOf<Endpoints> (response, "response is Endpoints");
        }
        
        /// <summary>
        /// Test V1UserUserIdLiveMeetingsMeetingIdEndpointsPut
        /// </summary>
        [Test]
        public void V1UserUserIdLiveMeetingsMeetingIdEndpointsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? meetingId = null;
            //bool? mute = null;
            //string media = null;
            //instance.V1UserUserIdLiveMeetingsMeetingIdEndpointsPut(userId, meetingId, mute, media);
            
        }
        
        /// <summary>
        /// Test V1UserUserIdLiveMeetingsMeetingIdGet
        /// </summary>
        [Test]
        public void V1UserUserIdLiveMeetingsMeetingIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? meetingId = null;
            //var response = instance.V1UserUserIdLiveMeetingsMeetingIdGet(userId, meetingId);
            //Assert.IsInstanceOf<MeetingState> (response, "response is MeetingState");
        }
        
        /// <summary>
        /// Test V1UserUserIdLiveMeetingsMeetingIdInvitePost
        /// </summary>
        [Test]
        public void V1UserUserIdLiveMeetingsMeetingIdInvitePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? meetingId = null;
            //PayloadInvite payloadInvite = null;
            //instance.V1UserUserIdLiveMeetingsMeetingIdInvitePost(userId, meetingId, payloadInvite);
            
        }
        
        /// <summary>
        /// Test V1UserUserIdLiveMeetingsMeetingIdPairingCodeSipPost
        /// </summary>
        [Test]
        public void V1UserUserIdLiveMeetingsMeetingIdPairingCodeSipPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? meetingId = null;
            //PayloadPairingCodeSIP payloadPairingCodeSIP = null;
            //var response = instance.V1UserUserIdLiveMeetingsMeetingIdPairingCodeSipPost(userId, meetingId, payloadPairingCodeSIP);
            //Assert.IsInstanceOf<PairingCode> (response, "response is PairingCode");
        }
        
        /// <summary>
        /// Test V1UserUserIdLiveMeetingsMeetingIdPairingCodeWebrtcPost
        /// </summary>
        [Test]
        public void V1UserUserIdLiveMeetingsMeetingIdPairingCodeWebrtcPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? meetingId = null;
            //PayloadPairingCodeWebRTC payloadPairingCodeWebRTC = null;
            //string role = null;
            //var response = instance.V1UserUserIdLiveMeetingsMeetingIdPairingCodeWebrtcPost(userId, meetingId, payloadPairingCodeWebRTC, role);
            //Assert.IsInstanceOf<PairingCode> (response, "response is PairingCode");
        }
        
        /// <summary>
        /// Test V1UserUserIdLiveMeetingsMeetingIdPut
        /// </summary>
        [Test]
        public void V1UserUserIdLiveMeetingsMeetingIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? meetingId = null;
            //PayloadMeetingState payloadMeetingState = null;
            //int? delay = null;
            //var response = instance.V1UserUserIdLiveMeetingsMeetingIdPut(userId, meetingId, payloadMeetingState, delay);
            //Assert.IsInstanceOf<Meeting> (response, "response is Meeting");
        }
        
        /// <summary>
        /// Test V1UserUserIdMeetingsMeetingIdNumbersGet
        /// </summary>
        [Test]
        public void V1UserUserIdMeetingsMeetingIdNumbersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? meetingId = null;
            //var response = instance.V1UserUserIdMeetingsMeetingIdNumbersGet(userId, meetingId);
            //Assert.IsInstanceOf<Numbers> (response, "response is Numbers");
        }
        
        /// <summary>
        /// Test V1UserUserIdScheduledMeetingMeetingIdEmailsGet
        /// </summary>
        [Test]
        public void V1UserUserIdScheduledMeetingMeetingIdEmailsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //int? meetingId = null;
            //string type = null;
            //string role = null;
            //string action = null;
            //var response = instance.V1UserUserIdScheduledMeetingMeetingIdEmailsGet(userId, meetingId, type, role, action);
            //Assert.IsInstanceOf<Meeting> (response, "response is Meeting");
        }
        
    }

}