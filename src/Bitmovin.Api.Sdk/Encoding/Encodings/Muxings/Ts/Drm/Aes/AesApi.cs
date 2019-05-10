﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Ts.Drm.Aes.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Ts.Drm.Aes
{
    public class AesApi
    {
        private readonly IAesApiClient _apiClient;

        public AesApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IAesApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AesApi
        /// </summary>
        public static BitmovinApiBuilder<AesApi> Builder => new BitmovinApiBuilder<AesApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Add AES Encryption to TS Segment
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the TS muxing.</param>
        /// <param name="aesEncryptionDrm">The request payload</param>
        public async Task<Models.AesEncryptionDrm> CreateAsync(string encodingId, string muxingId, Models.AesEncryptionDrm aesEncryptionDrm)
        {
            return await _apiClient.CreateAsync(encodingId, muxingId, aesEncryptionDrm);
        }
        
        /// <summary>
        /// Delete AES Encryption from TS Segment
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the transport stream segment.</param>
        /// <param name="drmId">Id of the PlayReady DRM configuration.</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId, string drmId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId, drmId);
        }
        
        /// <summary>
        /// AES Encryption Details of TS Segment
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the transport stream segment.</param>
        /// <param name="drmId">Id of the AESEncryption configuration.</param>
        public async Task<Models.AesEncryptionDrm> GetAsync(string encodingId, string muxingId, string drmId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId, drmId);
        }
        
        /// <summary>
        /// List AES Encryption of TS Segment
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the transport stream segment.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.AesEncryptionDrm>> ListAsync(string encodingId, string muxingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, muxingId, q);
        }
        
        internal interface IAesApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/muxings/ts/{muxing_id}/drm/aes")]
            [AllowAnyStatusCode]
            Task<Models.AesEncryptionDrm> CreateAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Body] Models.AesEncryptionDrm aesEncryptionDrm);
            
            [Delete("/encoding/encodings/{encoding_id}/muxings/ts/{muxing_id}/drm/aes/{drm_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("drm_id")] string drmId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/ts/{muxing_id}/drm/aes/{drm_id}")]
            [AllowAnyStatusCode]
            Task<Models.AesEncryptionDrm> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("drm_id")] string drmId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/ts/{muxing_id}/drm/aes")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.AesEncryptionDrm>> ListAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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