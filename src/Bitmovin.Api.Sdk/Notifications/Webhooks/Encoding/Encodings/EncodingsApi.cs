using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings.Finished;
using Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings.Error;

namespace Bitmovin.Api.Sdk.Notifications.Webhooks.Encoding.Encodings
{
    public class EncodingsApi
    {
        public EncodingsApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Finished = new FinishedApi(apiClientFactory);
            Error = new ErrorApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of EncodingsApi
        /// </summary>
        public static BitmovinApiBuilder<EncodingsApi> Builder => new BitmovinApiBuilder<EncodingsApi>();

        public FinishedApi Finished { get; }
        public ErrorApi Error { get; }
    }
}
