using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using JsonSubTypes;
using Newtonsoft.Json;

using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Models;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// SmoothStreamingRepresentation
    /// </summary>

    public class SmoothStreamingRepresentation : BitmovinResource
    {
        /// <summary>
        /// Id of the encoding
        /// </summary>
        [JsonProperty(PropertyName = "encodingId")]
        public string EncodingId { get; set; }
        
        /// <summary>
        /// Id of the muxing.
        /// </summary>
        [JsonProperty(PropertyName = "muxingId")]
        public string MuxingId { get; set; }
        
        /// <summary>
        /// The Smooth Streaming ismv or isma file that will be referenced in the manifest.
        /// </summary>
        [JsonProperty(PropertyName = "mediaFile")]
        public string MediaFile { get; set; }
        
        /// <summary>
        /// Language of the MP4 file
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }
        
        /// <summary>
        /// Track where this MP4 shoudl be added
        /// </summary>
        [JsonProperty(PropertyName = "trackName")]
        public string TrackName { get; set; }
    }

}
