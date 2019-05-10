﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Filters.Text.Customdata
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
        /// Text Filter Custom Data
        /// </summary>
        /// <param name="filterId">Id of the Text Filter</param>
        public async Task<Models.CustomData> GetCustomDataAsync(string filterId)
        {
            return await _apiClient.GetCustomDataAsync(filterId);
        }
        
        internal interface ICustomdataApiClient
        {
            
            [Get("/encoding/filters/text/{filter_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetCustomDataAsync([Path("filter_id")] string filterId);
            
        }
        
    }
}