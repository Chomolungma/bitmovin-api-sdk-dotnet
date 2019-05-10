﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Cmaf;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.SegmentedRaw;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Ts;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Webm;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mp3;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mp4;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveTs;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.BroadcastTs;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveWebm;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveMov;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings
{
    public class MuxingsApi
    {
        private readonly IMuxingsApiClient _apiClient;

        public MuxingsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IMuxingsApiClient>();

            Fmp4 = new Fmp4Api(apiClientFactory);
            Cmaf = new CmafApi(apiClientFactory);
            SegmentedRaw = new SegmentedRawApi(apiClientFactory);
            Ts = new TsApi(apiClientFactory);
            Webm = new WebmApi(apiClientFactory);
            Mp3 = new Mp3Api(apiClientFactory);
            Mp4 = new Mp4Api(apiClientFactory);
            ProgressiveTs = new ProgressiveTsApi(apiClientFactory);
            BroadcastTs = new BroadcastTsApi(apiClientFactory);
            ProgressiveWebm = new ProgressiveWebmApi(apiClientFactory);
            ProgressiveMov = new ProgressiveMovApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of MuxingsApi
        /// </summary>
        public static BitmovinApiBuilder<MuxingsApi> Builder => new BitmovinApiBuilder<MuxingsApi>();

        public Fmp4Api Fmp4 { get; private set; }
        public CmafApi Cmaf { get; private set; }
        public SegmentedRawApi SegmentedRaw { get; private set; }
        public TsApi Ts { get; private set; }
        public WebmApi Webm { get; private set; }
        public Mp3Api Mp3 { get; private set; }
        public Mp4Api Mp4 { get; private set; }
        public ProgressiveTsApi ProgressiveTs { get; private set; }
        public BroadcastTsApi BroadcastTs { get; private set; }
        public ProgressiveWebmApi ProgressiveWebm { get; private set; }
        public ProgressiveMovApi ProgressiveMov { get; private set; }
        
        /// <summary>
        /// List All Muxings
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Muxing>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        internal interface IMuxingsApiClient
        {
            
            [Get("/encoding/encodings/{encoding_id}/muxings")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Muxing>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
        }
        
        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? Offset) => SetQueryParam("offset", Offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? Limit) => SetQueryParam("limit", Limit);

            /// <summary>
            /// Filter muxings to only show the ones with the stream modes specified. Accepts multiple values separated by commas.
            /// </summary>
            public ListQueryParams StreamMode(Models.StreamMode StreamMode) => SetQueryParam("streamMode", StreamMode);

            private ListQueryParams SetQueryParam<T>(string key, T value)
            {
                if (value != null)
                {
                    this[key] = value;
                }

                return this;
            }
        }
    }
}