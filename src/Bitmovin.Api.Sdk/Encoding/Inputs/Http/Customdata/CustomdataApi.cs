using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.Http.Customdata
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
        /// HTTP Custom Data
        /// </summary>
        /// <param name="inputId">Id of the input (required)</param>
        public async Task<Models.CustomData> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }

        internal interface ICustomdataApiClient
        {
            [Get("/encoding/inputs/http/{input_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetAsync([Path("input_id")] string inputId);
        }
    }
}
