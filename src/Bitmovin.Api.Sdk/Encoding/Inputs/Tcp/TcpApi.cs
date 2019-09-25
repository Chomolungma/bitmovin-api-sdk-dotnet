using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Inputs.Tcp
{
    public class TcpApi
    {
        private readonly ITcpApiClient _apiClient;

        public TcpApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ITcpApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of TcpApi
        /// </summary>
        public static BitmovinApiBuilder<TcpApi> Builder => new BitmovinApiBuilder<TcpApi>();

        
        /// <summary>
        /// TCP Input Details
        /// </summary>
        /// <param name="inputId">Id of the input</param>
        public async Task<Models.TcpInput> GetAsync(string inputId)
        {
            return await _apiClient.GetAsync(inputId);
        }
        
        /// <summary>
        /// List TCP inputs
        /// </summary>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.TcpInput>> ListAsync(params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(q);
        }
        
        internal interface ITcpApiClient
        {
            
            [Get("/encoding/inputs/tcp/{input_id}")]
            [AllowAnyStatusCode]
            Task<Models.TcpInput> GetAsync([Path("input_id")] string inputId);
            
            [Get("/encoding/inputs/tcp")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.TcpInput>> ListAsync([QueryMap] IDictionary<String, Object> queryParams);
            
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
            /// Filter inputs by name
            /// </summary>
            public ListQueryParams Name(string Name) => SetQueryParam("name", Name);

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
