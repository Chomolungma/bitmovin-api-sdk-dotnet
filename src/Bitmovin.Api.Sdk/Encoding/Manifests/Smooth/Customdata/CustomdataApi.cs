using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Smooth.Customdata
{
    public class CustomdataApi
    {
        private readonly ICustomdataApiClient _apiClient;

        public CustomdataApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ICustomdataApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of CustomdataApi
        /// </summary>
        public static BitmovinApiBuilder<CustomdataApi> Builder => new BitmovinApiBuilder<CustomdataApi>();

        /// <summary>
        /// Smooth Streaming Manifest Custom Data
        /// </summary>
        /// <param name="manifestId">UUID of the Smooth Streaming manifest (required)</param>
        public async Task<Models.CustomData> GetAsync(string manifestId)
        {
            return await _apiClient.GetAsync(manifestId);
        }

        internal interface ICustomdataApiClient
        {
            [Get("/encoding/manifests/smooth/{manifest_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetAsync([Path("manifest_id")] string manifestId);
        }
    }
}
