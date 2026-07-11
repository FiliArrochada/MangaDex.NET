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
    ///  Class for testing UploadSessionAttributes
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UploadSessionAttributesTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UploadSessionAttributes
        //private UploadSessionAttributes instance;

        public UploadSessionAttributesTests()
        {
            // TODO uncomment below to create an instance of UploadSessionAttributes
            //instance = new UploadSessionAttributes();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UploadSessionAttributes
        /// </summary>
        [Fact]
        public void UploadSessionAttributesInstanceTest()
        {
            // TODO uncomment below to test "IsType" UploadSessionAttributes
            //Assert.IsType<UploadSessionAttributes>(instance);
        }

        /// <summary>
        /// Test the property 'IsCommitted'
        /// </summary>
        [Fact]
        public void IsCommittedTest()
        {
            // TODO unit test for the property 'IsCommitted'
        }

        /// <summary>
        /// Test the property 'IsProcessed'
        /// </summary>
        [Fact]
        public void IsProcessedTest()
        {
            // TODO unit test for the property 'IsProcessed'
        }

        /// <summary>
        /// Test the property 'IsDeleted'
        /// </summary>
        [Fact]
        public void IsDeletedTest()
        {
            // TODO unit test for the property 'IsDeleted'
        }

        /// <summary>
        /// Test the property 'VarVersion'
        /// </summary>
        [Fact]
        public void VarVersionTest()
        {
            // TODO unit test for the property 'VarVersion'
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
    }
}
