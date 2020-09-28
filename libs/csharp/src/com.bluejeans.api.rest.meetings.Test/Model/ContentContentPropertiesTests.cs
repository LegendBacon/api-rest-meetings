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
    ///  Class for testing ContentContentProperties
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ContentContentPropertiesTests
    {
        // TODO uncomment below to declare an instance variable for ContentContentProperties
        //private ContentContentProperties instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ContentContentProperties
            //instance = new ContentContentProperties();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContentContentProperties
        /// </summary>
        [Test]
        public void ContentContentPropertiesInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ContentContentProperties
            //Assert.IsInstanceOfType<ContentContentProperties> (instance, "variable 'instance' is a ContentContentProperties");
        }


        /// <summary>
        /// Test the property 'Duration'
        /// </summary>
        [Test]
        public void DurationTest()
        {
            // TODO unit test for the property 'Duration'
        }
        /// <summary>
        /// Test the property 'Thumbnail'
        /// </summary>
        [Test]
        public void ThumbnailTest()
        {
            // TODO unit test for the property 'Thumbnail'
        }
        /// <summary>
        /// Test the property 'ThumbnailSprite'
        /// </summary>
        [Test]
        public void ThumbnailSpriteTest()
        {
            // TODO unit test for the property 'ThumbnailSprite'
        }
        /// <summary>
        /// Test the property 'HdsUrl'
        /// </summary>
        [Test]
        public void HdsUrlTest()
        {
            // TODO unit test for the property 'HdsUrl'
        }
        /// <summary>
        /// Test the property 'ThumbnailCount'
        /// </summary>
        [Test]
        public void ThumbnailCountTest()
        {
            // TODO unit test for the property 'ThumbnailCount'
        }
        /// <summary>
        /// Test the property 'ThumbnailWidth'
        /// </summary>
        [Test]
        public void ThumbnailWidthTest()
        {
            // TODO unit test for the property 'ThumbnailWidth'
        }
        /// <summary>
        /// Test the property 'ThumbnailHeight'
        /// </summary>
        [Test]
        public void ThumbnailHeightTest()
        {
            // TODO unit test for the property 'ThumbnailHeight'
        }
        /// <summary>
        /// Test the property 'ThumbnailInterval'
        /// </summary>
        [Test]
        public void ThumbnailIntervalTest()
        {
            // TODO unit test for the property 'ThumbnailInterval'
        }
        /// <summary>
        /// Test the property 'HlsUrl'
        /// </summary>
        [Test]
        public void HlsUrlTest()
        {
            // TODO unit test for the property 'HlsUrl'
        }
        /// <summary>
        /// Test the property 'Levels'
        /// </summary>
        [Test]
        public void LevelsTest()
        {
            // TODO unit test for the property 'Levels'
        }

    }

}