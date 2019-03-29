﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.BroadcastTs.Customdata
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
        /// Broadcast TS Muxing Custom Data
        /// </summary>
        /// <param name="encodingId">ID of the Encoding.</param>
        /// <param name="muxingId">ID of the Broadcast TS muxing</param>
        public async Task<Models.CustomData> GetCustomDataAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetCustomDataAsync(encodingId, muxingId);
        }
        
        internal interface ICustomdataApiClient
        {
            
            [Get("/encoding/encodings/{encoding_id}/muxings/broadcast-ts/{muxing_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetCustomDataAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
            
        }
        
    }
}
