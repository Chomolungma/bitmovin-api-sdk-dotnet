using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Aac;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.HeAacV1;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.HeAacV2;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Vorbis;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Opus;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Ac3;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Eac3;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Mp2;
using Bitmovin.Api.Sdk.Encoding.Configurations.Audio.Mp3;

namespace Bitmovin.Api.Sdk.Encoding.Configurations.Audio
{
    public class AudioApi
    {
        public AudioApi(IBitmovinApiClientFactory apiClientFactory)
        {
            Aac = new AacApi(apiClientFactory);
            HeAacV1 = new HeAacV1Api(apiClientFactory);
            HeAacV2 = new HeAacV2Api(apiClientFactory);
            Vorbis = new VorbisApi(apiClientFactory);
            Opus = new OpusApi(apiClientFactory);
            Ac3 = new Ac3Api(apiClientFactory);
            Eac3 = new Eac3Api(apiClientFactory);
            Mp2 = new Mp2Api(apiClientFactory);
            Mp3 = new Mp3Api(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of AudioApi
        /// </summary>
        public static BitmovinApiBuilder<AudioApi> Builder => new BitmovinApiBuilder<AudioApi>();

        public AacApi Aac { get; }
        public HeAacV1Api HeAacV1 { get; }
        public HeAacV2Api HeAacV2 { get; }
        public VorbisApi Vorbis { get; }
        public OpusApi Opus { get; }
        public Ac3Api Ac3 { get; }
        public Eac3Api Eac3 { get; }
        public Mp2Api Mp2 { get; }
        public Mp3Api Mp3 { get; }
    }
}
