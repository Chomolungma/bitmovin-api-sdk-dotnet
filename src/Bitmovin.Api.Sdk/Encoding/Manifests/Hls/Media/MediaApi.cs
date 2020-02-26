using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media.CustomTags;
using Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media.Type;
using Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media.Video;
using Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media.Audio;
using Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media.Subtitles;
using Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media.Vtt;
using Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media.ClosedCaptions;

namespace Bitmovin.Api.Sdk.Encoding.Manifests.Hls.Media
{
    public class MediaApi
    {
        public MediaApi(IBitmovinApiClientFactory apiClientFactory)
        {
            CustomTags = new CustomTagsApi(apiClientFactory);
            Type = new TypeApi(apiClientFactory);
            Video = new VideoApi(apiClientFactory);
            Audio = new AudioApi(apiClientFactory);
            Subtitles = new SubtitlesApi(apiClientFactory);
            Vtt = new VttApi(apiClientFactory);
            ClosedCaptions = new ClosedCaptionsApi(apiClientFactory);
        }

        /// <summary>
        /// Fluent builder for creating an instance of MediaApi
        /// </summary>
        public static BitmovinApiBuilder<MediaApi> Builder => new BitmovinApiBuilder<MediaApi>();

        public CustomTagsApi CustomTags { get; }
        public TypeApi Type { get; }
        public VideoApi Video { get; }
        public AudioApi Audio { get; }
        public SubtitlesApi Subtitles { get; }
        public VttApi Vtt { get; }
        public ClosedCaptionsApi ClosedCaptions { get; }
    }
}
