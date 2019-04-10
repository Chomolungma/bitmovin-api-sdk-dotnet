﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Cmaf.Drm.Widevine;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Cmaf.Drm.Playready;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Cmaf.Drm.Primetime;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Cmaf.Drm.Fairplay;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Cmaf.Drm.Marlin;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Cmaf.Drm.Clearkey;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Cmaf.Drm.Cenc;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Cmaf.Drm
{
    public class DrmApi
    {
        private readonly IDrmApiClient _apiClient;

        public DrmApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IDrmApiClient>();

            Widevine = new WidevineApi(apiClientFactory);
            Playready = new PlayreadyApi(apiClientFactory);
            Primetime = new PrimetimeApi(apiClientFactory);
            Fairplay = new FairplayApi(apiClientFactory);
            Marlin = new MarlinApi(apiClientFactory);
            Clearkey = new ClearkeyApi(apiClientFactory);
            Cenc = new CencApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of DrmApi
        /// </summary>
        public static BitmovinApiBuilder<DrmApi> Builder => new BitmovinApiBuilder<DrmApi>();

        public WidevineApi Widevine { get; private set; }
        public PlayreadyApi Playready { get; private set; }
        public PrimetimeApi Primetime { get; private set; }
        public FairplayApi Fairplay { get; private set; }
        public MarlinApi Marlin { get; private set; }
        public ClearkeyApi Clearkey { get; private set; }
        public CencApi Cenc { get; private set; }
        
        /// <summary>
        /// List all DRMs of CMAF Muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the CMAF muxing</param>
        public async Task<Models.PaginationResponse<Models.Drm>> ListAsync(string encodingId, string muxingId)
        {
            return await _apiClient.ListAsync(encodingId, muxingId);
        }
        
        internal interface IDrmApiClient
        {
            
            [Get("/encoding/encodings/{encoding_id}/muxings/cmaf/{muxing_id}/drm")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Drm>> ListAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
            
        }
        
    }
}
