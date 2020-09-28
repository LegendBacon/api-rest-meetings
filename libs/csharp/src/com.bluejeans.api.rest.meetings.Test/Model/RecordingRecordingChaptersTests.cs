/* 
 * BlueJeans Meetings REST API
 *
 *  ## Video That Works Where You Do. <p>This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you can see and try actual API calls to manage User Accounts, Meetings, and Recordings, pull Analytical Data and Current State information.</p>    <nosdk> <hr> <div> <div class=\"key\">     <a href=\"./basics.html\" target=\"_\"><img class=\"keyimg\" src=\"./img/bjnmeeting.png\"/></a> </div> <div class=\"keybox\"> Basic instructions about What is a BlueJeans Meeting, and Getting Started Using API's, are <a href=\"./basics.html\" target=\"_blank\">available here <i class=\"glyphicon glyphicon-new-window\"></i></a>. </div> </div> <hr> <alert>2/21/2019</alert> Change response of Change layout and Endpoint API's to 204<br/> 12/03/2018 Add API for setting user profile photograph.<br/> 10/17/2018 Updated API field definitions for time variables to be 64-bit .<br/> 7/23/2018 Corrected errors in API definition file.<br/> 7/10/2018 Deprecated some Command Center API's.  Exposed API's that Summarize usage.<br/> 7/06/2018 Added API for changing ownership of recordings.<br/> 6/28/2018 Restored Create Enterprise Account, added Enterprise and User Profile Tag API's.<br/> 6/01/2018 Clarified Access Token requirements for meeting endpoint API's.<br/> 5/21/2018 Corrected return model for meeting history call.<br/> </nosdk> <hr> 
 *
 * OpenAPI spec version: 1.0.4402212019
 * Contact: glenn@bluejeans.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using com.bluejeans.api.rest.meetings.Api;
using com.bluejeans.api.rest.meetings.Model;
using com.bluejeans.api.rest.meetings.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace com.bluejeans.api.rest.meetings.Test
{
    /// <summary>
    ///  Class for testing RecordingRecordingChapters
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class RecordingRecordingChaptersTests
    {
        // TODO uncomment below to declare an instance variable for RecordingRecordingChapters
        //private RecordingRecordingChapters instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of RecordingRecordingChapters
            //instance = new RecordingRecordingChapters();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RecordingRecordingChapters
        /// </summary>
        [Test]
        public void RecordingRecordingChaptersInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" RecordingRecordingChapters
            //Assert.IsInstanceOfType<RecordingRecordingChapters> (instance, "variable 'instance' is a RecordingRecordingChapters");
        }


        /// <summary>
        /// Test the property 'ChapterId'
        /// </summary>
        [Test]
        public void ChapterIdTest()
        {
            // TODO unit test for the property 'ChapterId'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'StartTimeOffset'
        /// </summary>
        [Test]
        public void StartTimeOffsetTest()
        {
            // TODO unit test for the property 'StartTimeOffset'
        }
        /// <summary>
        /// Test the property 'EndTimeOffset'
        /// </summary>
        [Test]
        public void EndTimeOffsetTest()
        {
            // TODO unit test for the property 'EndTimeOffset'
        }
        /// <summary>
        /// Test the property 'ChapterName'
        /// </summary>
        [Test]
        public void ChapterNameTest()
        {
            // TODO unit test for the property 'ChapterName'
        }
        /// <summary>
        /// Test the property 'TotalSize'
        /// </summary>
        [Test]
        public void TotalSizeTest()
        {
            // TODO unit test for the property 'TotalSize'
        }
        /// <summary>
        /// Test the property 'CompositeContentId'
        /// </summary>
        [Test]
        public void CompositeContentIdTest()
        {
            // TODO unit test for the property 'CompositeContentId'
        }
        /// <summary>
        /// Test the property 'CompositeContentStatus'
        /// </summary>
        [Test]
        public void CompositeContentStatusTest()
        {
            // TODO unit test for the property 'CompositeContentStatus'
        }
        /// <summary>
        /// Test the property 'ParentRecordingId'
        /// </summary>
        [Test]
        public void ParentRecordingIdTest()
        {
            // TODO unit test for the property 'ParentRecordingId'
        }
        /// <summary>
        /// Test the property 'ViewCount'
        /// </summary>
        [Test]
        public void ViewCountTest()
        {
            // TODO unit test for the property 'ViewCount'
        }
        /// <summary>
        /// Test the property 'RecordingSessions'
        /// </summary>
        [Test]
        public void RecordingSessionsTest()
        {
            // TODO unit test for the property 'RecordingSessions'
        }

    }

}