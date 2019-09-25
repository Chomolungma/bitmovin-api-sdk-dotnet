using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mp4.Drm.Clearkey.Customdata;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.Mp4.Drm.Clearkey
{
    public class ClearkeyApi
    {
        private readonly IClearkeyApiClient _apiClient;

        public ClearkeyApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IClearkeyApiClient>();

            Customdata = new CustomdataApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ClearkeyApi
        /// </summary>
        public static BitmovinApiBuilder<ClearkeyApi> Builder => new BitmovinApiBuilder<ClearkeyApi>();

        public CustomdataApi Customdata { get; private set; }
        
        /// <summary>
        /// Add ClearKey DRM to MP4
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the MP4 muxing.</param>
        /// <param name="clearKeyDrm">The request payload</param>
        public async Task<Models.ClearKeyDrm> CreateAsync(string encodingId, string muxingId, Models.ClearKeyDrm clearKeyDrm)
        {
            return await _apiClient.CreateAsync(encodingId, muxingId, clearKeyDrm);
        }
        
        /// <summary>
        /// Delete ClearKey DRM from MP4
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the mp4.</param>
        /// <param name="drmId">Id of the ClearKey DRM configuration.</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string encodingId, string muxingId, string drmId)
        {
            return await _apiClient.DeleteAsync(encodingId, muxingId, drmId);
        }
        
        /// <summary>
        /// ClearKey DRM Details of MP4
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the mp4.</param>
        /// <param name="drmId">Id of the ClearKey DRM configuration.</param>
        public async Task<Models.ClearKeyDrm> GetAsync(string encodingId, string muxingId, string drmId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId, drmId);
        }
        
        /// <summary>
        /// List ClearKey DRMs of MP4
        /// </summary>
        /// <param name="encodingId">Id of the encoding.</param>
        /// <param name="muxingId">Id of the mp4.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.ClearKeyDrm>> ListAsync(string encodingId, string muxingId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(encodingId, muxingId, q);
        }
        
        internal interface IClearkeyApiClient
        {
            
            [Post("/encoding/encodings/{encoding_id}/muxings/mp4/{muxing_id}/drm/clearkey")]
            [AllowAnyStatusCode]
            Task<Models.ClearKeyDrm> CreateAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Body] Models.ClearKeyDrm clearKeyDrm);
            
            [Delete("/encoding/encodings/{encoding_id}/muxings/mp4/{muxing_id}/drm/clearkey/{drm_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("drm_id")] string drmId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/mp4/{muxing_id}/drm/clearkey/{drm_id}")]
            [AllowAnyStatusCode]
            Task<Models.ClearKeyDrm> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("drm_id")] string drmId);
            
            [Get("/encoding/encodings/{encoding_id}/muxings/mp4/{muxing_id}/drm/clearkey")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.ClearKeyDrm>> ListAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
