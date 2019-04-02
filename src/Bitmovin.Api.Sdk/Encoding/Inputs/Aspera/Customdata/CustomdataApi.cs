﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.Aspera.Customdata
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
        /// Aspera Custom Data
        /// </summary>
        /// <param name="inputId">Id of the input</param>
        public async Task<Models.CustomData> GetCustomDataAsync(string inputId)
        {
            return await _apiClient.GetCustomDataAsync(inputId);
        }
        
        internal interface ICustomdataApiClient
        {
            
            [Get("/encoding/inputs/aspera/{input_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetCustomDataAsync([Path("input_id")] string inputId);
            
        }
        
    }
}
