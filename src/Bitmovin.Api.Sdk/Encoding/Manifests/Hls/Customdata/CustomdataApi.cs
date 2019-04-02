﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Customdata
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
        /// HLS Manifest Custom Data
        /// </summary>
        /// <param name="manifestId">UUID of the HLS manifest</param>
        public async Task<Models.CustomData> GetCustomDataAsync(string manifestId)
        {
            return await _apiClient.GetCustomDataAsync(manifestId);
        }
        
        internal interface ICustomdataApiClient
        {
            
            [Get("/encoding/manifests/hls/{manifest_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetCustomDataAsync([Path("manifest_id")] string manifestId);
            
        }
        
    }
}
