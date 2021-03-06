using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Encodings.Live.InsertableContent;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Live
{
    public class LiveApi
    {
        private readonly ILiveApiClient _apiClient;

        public LiveApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ILiveApiClient>();
            InsertableContent = new InsertableContentApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of LiveApi
        /// </summary>
        public static BitmovinApiBuilder<LiveApi> Builder => new BitmovinApiBuilder<LiveApi>();

        public InsertableContentApi InsertableContent { get; }

        /// <summary>
        /// Live Encoding Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding. (required)</param>
        public async Task<Models.LiveEncoding> GetAsync(string encodingId)
        {
            return await _apiClient.GetAsync(encodingId);
        }

        /// <summary>
        /// Live Encoding Start Details
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        public async Task<Models.StartLiveEncodingRequest> GetStartRequestAsync(string encodingId)
        {
            return await _apiClient.GetStartRequestAsync(encodingId);
        }

        /// <summary>
        /// Re-Start Live Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        public async Task<Models.BitmovinResponse> RestartAsync(string encodingId)
        {
            return await _apiClient.RestartAsync(encodingId);
        }

        /// <summary>
        /// Start Live Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        /// <param name="startLiveEncodingRequest">Live Encoding startup options</param>
        public async Task<Models.BitmovinResponse> StartAsync(string encodingId, Models.StartLiveEncodingRequest startLiveEncodingRequest)
        {
            return await _apiClient.StartAsync(encodingId, startLiveEncodingRequest);
        }

        /// <summary>
        /// Stop Live Encoding
        /// </summary>
        /// <param name="encodingId">Id of the encoding (required)</param>
        public async Task<Models.BitmovinResponse> StopAsync(string encodingId)
        {
            return await _apiClient.StopAsync(encodingId);
        }

        internal interface ILiveApiClient
        {
            [Get("/encoding/encodings/{encoding_id}/live")]
            [AllowAnyStatusCode]
            Task<Models.LiveEncoding> GetAsync([Path("encoding_id")] string encodingId);

            [Get("/encoding/encodings/{encoding_id}/live/start")]
            [AllowAnyStatusCode]
            Task<Models.StartLiveEncodingRequest> GetStartRequestAsync([Path("encoding_id")] string encodingId);

            [Post("/encoding/encodings/{encoding_id}/live/restart")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> RestartAsync([Path("encoding_id")] string encodingId);

            [Post("/encoding/encodings/{encoding_id}/live/start")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> StartAsync([Path("encoding_id")] string encodingId, [Body] Models.StartLiveEncodingRequest startLiveEncodingRequest);

            [Post("/encoding/encodings/{encoding_id}/live/stop")]
            [AllowAnyStatusCode]
            Task<Models.BitmovinResponse> StopAsync([Path("encoding_id")] string encodingId);
        }
    }
}
