﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4.Customdata;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4.Drm;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4.Captions;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Fmp4
{
    public class Fmp4Api
    {
        private readonly IFmp4ApiClient _apiClient;

        public Fmp4Api(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IFmp4ApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
            Drm = new DrmApi(apiClientFactory);
            Captions = new CaptionsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of Fmp4Api
        /// </summary>
        public static BitmovinApiBuilder<Fmp4Api> Builder => new BitmovinApiBuilder<Fmp4Api>();

        public CustomdataApi Customdata { get; private set; }
        public DrmApi Drm { get; private set; }
        public CaptionsApi Captions { get; private set; }
        
        /// <summary>
        /// Add fMP4 Segment Muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="fmp4Muxing">The request payload</param>
        public async Task<Models.Fmp4Muxing> CreateAsync(string encodingId, Models.Fmp4Muxing fmp4Muxing)
        {
            return await _apiClient.CreateAsync(encodingId, fmp4Muxing);
        }
        
        /// <summary>
        /// Delete fMP4 Muxing
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the fMP4 muxing</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId);
        }
        
        /// <summary>
        /// fMP4 Segment Muxing Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the fMP4 muxing</param>
        public async Task<Models.Fmp4Muxing> GetAsync(string encodingId, string muxingId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId);
        }
        
        /// <summary>
        /// List fMP4 Segment Muxings
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Fmp4Muxing>> ListAsync(string encodingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, q);
        }
        
        internal interface IFmp4ApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/muxings/fmp4")]
            [AllowAnyStatusCode]
            Task<Models.Fmp4Muxing> CreateAsync([Path("encoding_id")] string encodingId, [Body] Models.Fmp4Muxing fmp4Muxing);
            
            [Delete("/encoding/encodings/{encoding_id}/muxings/fmp4/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/fmp4/{muxing_id}")]
            [AllowAnyStatusCode]
            Task<Models.Fmp4Muxing> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/fmp4")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Fmp4Muxing>> ListAsync([Path("encoding_id")] string encodingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
