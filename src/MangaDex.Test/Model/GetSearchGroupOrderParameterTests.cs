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
    ///  Class for testing GetSearchGroupOrderParameter
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetSearchGroupOrderParameterTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GetSearchGroupOrderParameter
        //private GetSearchGroupOrderParameter instance;

        public GetSearchGroupOrderParameterTests()
        {
            // TODO uncomment below to create an instance of GetSearchGroupOrderParameter
            //instance = new GetSearchGroupOrderParameter();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetSearchGroupOrderParameter
        /// </summary>
        [Fact]
        public void GetSearchGroupOrderParameterInstanceTest()
        {
            // TODO uncomment below to test "IsType" GetSearchGroupOrderParameter
            //Assert.IsType<GetSearchGroupOrderParameter>(instance);
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Fact]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
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
        /// Test the property 'FollowedCount'
        /// </summary>
        [Fact]
        public void FollowedCountTest()
        {
            // TODO unit test for the property 'FollowedCount'
        }

        /// <summary>
        /// Test the property 'Relevance'
        /// </summary>
        [Fact]
        public void RelevanceTest()
        {
            // TODO unit test for the property 'Relevance'
        }
    }
}
