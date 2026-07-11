/*
 * MangaDex API
 *
 * MangaDex is an ad-free manga reader offering high-quality images!  This document details our API as it is right now. It is in no way a promise to never change it, although we will endeavour to publicly notify any major change.  # Acceptable use policy  Usage of our services implies acceptance of the following: - You **MUST** credit us - You **MUST** credit scanlation groups if you offer the ability to read chapters - You **CANNOT** run ads or paid services on your website and/or apps  These may change at any time for any and no reason and it is up to you check for updates from time to time.  # Security issues  If you believe you found a security issue in our API, please check our [security.txt](/security.txt) to get in touch privately. 
 *
 * The version of the OpenAPI document: 5.13.1
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
    ///  Class for testing GetMangaStatus200Response
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetMangaStatus200ResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GetMangaStatus200Response
        //private GetMangaStatus200Response instance;

        public GetMangaStatus200ResponseTests()
        {
            // TODO uncomment below to create an instance of GetMangaStatus200Response
            //instance = new GetMangaStatus200Response();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetMangaStatus200Response
        /// </summary>
        [Fact]
        public void GetMangaStatus200ResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" GetMangaStatus200Response
            //Assert.IsType<GetMangaStatus200Response>(instance);
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
        /// Test the property 'Statuses'
        /// </summary>
        [Fact]
        public void StatusesTest()
        {
            // TODO unit test for the property 'Statuses'
        }
    }
}
