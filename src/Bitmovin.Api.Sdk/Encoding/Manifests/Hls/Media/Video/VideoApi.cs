﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media.Video.Iframe;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media.Video
{
    public class VideoApi
    {
        private readonly IVideoApiClient _apiClient;

        public VideoApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IVideoApiClient>();

            Iframe = new IframeApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of VideoApi
        /// </summary>
        public static BitmovinApiBuilder<VideoApi> Builder => new BitmovinApiBuilder<VideoApi>();

        public IframeApi Iframe { get; private set; }
        
        /// <summary>
        /// Add Video Media
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest.</param>
        /// <param name="videoMediaInfo">The request payload</param>
        public async Task<Models.VideoMediaInfo> CreateAsync(string manifestId, Models.VideoMediaInfo videoMediaInfo)
        {
            return await _apiClient.CreateAsync(manifestId, videoMediaInfo);
        }
        
        /// <summary>
        /// Delete Video Media
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest.</param>
        /// <param name="mediaId">Id of the video media.</param>
        public async Task<Models.BitmovinResponse> DeleteAsync(string manifestId, string mediaId)
        {
            return await _apiClient.DeleteAsync(manifestId, mediaId);
        }
        
        /// <summary>
        /// Video Media Details
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest.</param>
        /// <param name="mediaId">Id of the video media.</param>
        public async Task<Models.VideoMediaInfo> GetAsync(string manifestId, string mediaId)
        {
            return await _apiClient.GetAsync(manifestId, mediaId);
        }
        
        /// <summary>
        /// List all Video Media
        /// </summary>
        /// <param name="manifestId">Id of the hls manifest.</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.VideoMediaInfo>> ListAsync(string manifestId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(manifestId, q);
        }
        
        internal interface IVideoApiClient
        {
            
            [Post("/encoding/manifests/hls/{manifest_id}/media/video")]
            [AllowAnyStatusCode]
            Task<Models.VideoMediaInfo> CreateAsync([Path("manifest_id")] string manifestId, [Body] Models.VideoMediaInfo videoMediaInfo);
            
            [Delete("/encoding/manifests/hls/{manifest_id}/media/video/{media_id}")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> DeleteAsync([Path("manifest_id")] string manifestId, [Path("media_id")] string mediaId);
            
            [Get("/encoding/manifests/hls/{manifest_id}/media/video/{media_id}")]
            [AllowAnyStatusCode]
            Task<Models.VideoMediaInfo> GetAsync([Path("manifest_id")] string manifestId, [Path("media_id")] string mediaId);
            
            [Get("/encoding/manifests/hls/{manifest_id}/media/video")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.VideoMediaInfo>> ListAsync([Path("manifest_id")] string manifestId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
