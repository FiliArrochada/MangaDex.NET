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
    ///  Class for testing GetStatisticsMangaUuid200ResponseStatisticsValueRating
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetStatisticsMangaUuid200ResponseStatisticsValueRatingTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GetStatisticsMangaUuid200ResponseStatisticsValueRating
        //private GetStatisticsMangaUuid200ResponseStatisticsValueRating instance;

        public GetStatisticsMangaUuid200ResponseStatisticsValueRatingTests()
        {
            // TODO uncomment below to create an instance of GetStatisticsMangaUuid200ResponseStatisticsValueRating
            //instance = new GetStatisticsMangaUuid200ResponseStatisticsValueRating();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetStatisticsMangaUuid200ResponseStatisticsValueRating
        /// </summary>
        [Fact]
        public void GetStatisticsMangaUuid200ResponseStatisticsValueRatingInstanceTest()
        {
            // TODO uncomment below to test "IsType" GetStatisticsMangaUuid200ResponseStatisticsValueRating
            //Assert.IsType<GetStatisticsMangaUuid200ResponseStatisticsValueRating>(instance);
        }

        /// <summary>
        /// Test the property 'Average'
        /// </summary>
        [Fact]
        public void AverageTest()
        {
            // TODO unit test for the property 'Average'
        }

        /// <summary>
        /// Test the property 'Bayesian'
        /// </summary>
        [Fact]
        public void BayesianTest()
        {
            // TODO unit test for the property 'Bayesian'
        }

        /// <summary>
        /// Test the property 'Distribution'
        /// </summary>
        [Fact]
        public void DistributionTest()
        {
            // TODO unit test for the property 'Distribution'
        }
    }
}
