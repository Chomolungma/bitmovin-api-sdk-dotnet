﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Smooth.Default
{
    public class DefaultApi
    {
        private readonly IDefaultApiClient _apiClient;

        public DefaultApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDefaultApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of DefaultApi
        /// </summary>
        public static BitmovinApiBuilder<DefaultApi> Builder => new BitmovinApiBuilder<DefaultApi>();

        
        /// <summary>
        /// Create Smooth Streaming Manifest Default
        /// </summary>
        /// <param name="smoothManifestDefault">The request payload</param>
        public async Task<Models.SmoothManifestDefault> CreateAsync(Models.SmoothManifestDefault smoothManifestDefault)
        {
            return await _apiClient.CreateAsync(smoothManifestDefault);
        }
        
        internal interface IDefaultApiClient
        {
            
            [Post("/encoding/manifests/smooth/default")]
            [AllowAnyStatusCode]
            Task<Models.SmoothManifestDefault> CreateAsync([Body] Models.SmoothManifestDefault smoothManifestDefault);
            
        }
        
    }
}