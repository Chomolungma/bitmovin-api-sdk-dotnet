using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestEase;
using Bitmovin.Api.Sdk.Common;

namespace Bitmovin.Api.Sdk.Encoding.Encodings.Muxings.ProgressiveTs.Id3.Raw.Customdata
{
    public class CustomdataApi
    {
        private readonly ICustomdataApiClient _apiClient;

        public CustomdataApi(IBitmovinApiClientFactory apiClientFactory)
        {
            _apiClient = apiClientFactory.CreateClient<ICustomdataApiClient>();
        }

        /// <summary>
        /// Fluent builder for creating an instance of CustomdataApi
        /// </summary>
        public static BitmovinApiBuilder<CustomdataApi> Builder => new BitmovinApiBuilder<CustomdataApi>();

        /// <summary>
        /// Raw ID3 Tag Custom Data of a Progressive TS muxing
        /// </summary>
        /// <param name="encodingId">ID of the Encoding. (required)</param>
        /// <param name="muxingId">ID of the Progressive TS muxing (required)</param>
        /// <param name="id3TagId">ID of the RAW ID3 Tag (required)</param>
        public async Task<Models.CustomData> GetAsync(string encodingId, string muxingId, string id3TagId)
        {
            return await _apiClient.GetAsync(encodingId, muxingId, id3TagId);
        }

        internal interface ICustomdataApiClient
        {
            [Get("/encoding/encodings/{encoding_id}/muxings/progressive-ts/{muxing_id}/id3/raw/{id3_tag_id}/customData")]
            [AllowAnyStatusCode]
            Task<Models.CustomData> GetAsync([Path("encoding_id")] string encodingId, [Path("muxing_id")] string muxingId, [Path("id3_tag_id")] string id3TagId);
        }
    }
}
