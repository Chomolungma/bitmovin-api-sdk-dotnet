﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Notifications.State
{
    public class StateApi
    {
        private readonly IStateApiClient _apiClient;

        public StateApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<IStateApiClient>();

        }

        /// <summary>
        /// Fluent builder for creating an instance of StateApi
        /// </summary>
        public static BitmovinApiBuilder<StateApi> Builder => new BitmovinApiBuilder<StateApi>();

        
        /// <summary>
        /// List Notification State History (Specific Resource)
        /// </summary>
        /// <param name="notificationId">Id of the notification</param>
        /// <param name="resourceId">Id of the resource, e.g. encoding id</param>
        /// <param name="queryParams">The query parameters for sorting, filtering and paging options (optional)</param>
        public async Task<Models.PaginationResponse<Models.NotificationStateEntry>> ListAsync(string notificationId, string resourceId, params Func<ListQueryParams, ListQueryParams>[] queryParams)
        {
            ListQueryParams q = new ListQueryParams();

            foreach (var builderFunc in queryParams)
            {
                builderFunc(q);
            }

            return await _apiClient.ListAsync(notificationId, resourceId, q);
        }
        
        internal interface IStateApiClient
        {
            
            [Get("/notifications/{notification_id}/state/{resource_id}")]
            [AllowAnyStatusCode]
            Task<Models.PaginationResponse<Models.NotificationStateEntry>> ListAsync([Path("notification_id")] string notificationId, [Path("resource_id")] string resourceId, [QueryMap] IDictionary<String, Object> queryParams);
            
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
