using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Manifests.Type;
using Bitmovin.Api.Sdk.Encoding.Manifests.Dash;
using Bitmovin.Api.Sdk.Encoding.Manifests.Hls;
using Bitmovin.Api.Sdk.Encoding.Manifests.Smooth;

namespace Bitmovin.Api.Sdk.Encoding.Manifests
{
    public class ManifestsApi
    {
        private readonly IManifestsApiClient _apiClient;

        public ManifestsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IManifestsApiClient>();
            Type = new TypeApi(apiClientFactory);
            Dash = new DashApi(apiClientFactory);
            Hls = new HlsApi(apiClientFactory);
            Smooth = new SmoothApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of ManifestsApi
        /// </summary>
        public static BitmovinApiBuilder<ManifestsApi> Builder => new BitmovinApiBuilder<ManifestsApi>();

        public TypeApi Type { get; }
        public DashApi Dash { get; }
        public HlsApi Hls { get; }
        public SmoothApi Smooth { get; }

        /// <summary>
        /// List all Manifests
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.Manifest>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }

        internal interface IManifestsApiClient
        {
            [Get("/encoding/manifests")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.Manifest>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
        }

        public class ListQueryParams : Dictionary<string,Object>
        {
            /// <summary>
            /// Index of the first item to return, starting at 0. Default is 0
            /// </summary>
            public ListQueryParams Offset(int? offset) => SetQueryParam("offset", offset);

            /// <summary>
            /// Maximum number of items to return. Default is 25, maximum is 100
            /// </summary>
            public ListQueryParams Limit(int? limit) => SetQueryParam("limit", limit);

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
