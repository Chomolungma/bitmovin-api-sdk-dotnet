using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Analytics.Queries.Count
{
    public class CountApi
    {
        private readonly ICountApiClient _apiClient;

        public CountApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ICountApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of CountApi
        /// </summary>
        public static BitmovinApiBuilder<CountApi> Builder => new BitmovinApiBuilder<CountApi>();

        /// <summary>
        /// Count
        /// </summary>
        /// <param name="analyticsCountQueryRequest">Analytics Query Object</param>
        public async Task<Models.AnalyticsResponse> CreateAsync(Models.AnalyticsCountQueryRequest analyticsCountQueryRequest)
        {
            return await _apiClient.CreateAsync(analyticsCountQueryRequest);
        }

        internal interface ICountApiClient
        {
            [Post("/analytics/queries/count")]
            [AllowAnyStatusCode]
            Task<Models.AnalyticsResponse> CreateAsync([Body] Models.AnalyticsCountQueryRequest analyticsCountQueryRequest);
        }
    }
}
