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
    ///  Class for testing UploadSessionFileAttributes
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UploadSessionFileAttributesTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UploadSessionFileAttributes
        //private UploadSessionFileAttributes instance;

        public UploadSessionFileAttributesTests()
        {
            // TODO uncomment below to create an instance of UploadSessionFileAttributes
            //instance = new UploadSessionFileAttributes();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UploadSessionFileAttributes
        /// </summary>
        [Fact]
        public void UploadSessionFileAttributesInstanceTest()
        {
            // TODO uncomment below to test "IsType" UploadSessionFileAttributes
            //Assert.IsType<UploadSessionFileAttributes>(instance);
        }

        /// <summary>
        /// Test the property 'OriginalFileName'
        /// </summary>
        [Fact]
        public void OriginalFileNameTest()
        {
            // TODO unit test for the property 'OriginalFileName'
        }

        /// <summary>
        /// Test the property 'FileHash'
        /// </summary>
        [Fact]
        public void FileHashTest()
        {
            // TODO unit test for the property 'FileHash'
        }

        /// <summary>
        /// Test the property 'FileSize'
        /// </summary>
        [Fact]
        public void FileSizeTest()
        {
            // TODO unit test for the property 'FileSize'
        }

        /// <summary>
        /// Test the property 'MimeType'
        /// </summary>
        [Fact]
        public void MimeTypeTest()
        {
            // TODO unit test for the property 'MimeType'
        }

        /// <summary>
        /// Test the property 'Source'
        /// </summary>
        [Fact]
        public void SourceTest()
        {
            // TODO unit test for the property 'Source'
        }

        /// <summary>
        /// Test the property 'VarVersion'
        /// </summary>
        [Fact]
        public void VarVersionTest()
        {
            // TODO unit test for the property 'VarVersion'
        }
    }
}
