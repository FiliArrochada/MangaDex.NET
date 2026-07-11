/*
 * MangaDex API
 *
 * MangaDex is an ad-free manga reader offering high-quality images!  This document details our API as it is right now. It is in no way a promise to never change it, although we will endeavour to publicly notify any major change.  # Acceptable use policy  Usage of our services implies acceptance of the following: - You **MUST** credit us - You **MUST** credit scanlation groups if you offer the ability to read chapters - You **CANNOT** run ads or paid services on your website and/or apps  These may change at any time for any and no reason and it is up to you check for updates from time to time.  # Security issues  If you believe you found a security issue in our API, please check our [security.txt](/security.txt) to get in touch privately. 
 *
 * The version of the OpenAPI document: 5.10.0
 * Contact: support@mangadex.org
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using MangaDex.Model;
using MangaDex.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace MangaDex.Test.Model
{
    /// <summary>
    ///  Class for testing GetSettings200Response
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetSettings200ResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GetSettings200Response
        //private GetSettings200Response instance;

        public GetSettings200ResponseTests()
        {
            // TODO uncomment below to create an instance of GetSettings200Response
            //instance = new GetSettings200Response();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetSettings200Response
        /// </summary>
        [Fact]
        public void GetSettings200ResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" GetSettings200Response
            //Assert.IsType<GetSettings200Response>(instance);
        }

        /// <summary>
        /// Test the property 'Result'
        /// </summary>
        [Fact]
        public void ResultTest()
        {
            // TODO unit test for the property 'Result'
        }

        /// <summary>
        /// Test the property 'UpdatedAt'
        /// </summary>
        [Fact]
        public void UpdatedAtTest()
        {
            // TODO unit test for the property 'UpdatedAt'
        }

        /// <summary>
        /// Test the property 'Settings'
        /// </summary>
        [Fact]
        public void SettingsTest()
        {
            // TODO unit test for the property 'Settings'
        }

        /// <summary>
        /// Test the property 'Template'
        /// </summary>
        [Fact]
        public void TemplateTest()
        {
            // TODO unit test for the property 'Template'
        }
    }
}
