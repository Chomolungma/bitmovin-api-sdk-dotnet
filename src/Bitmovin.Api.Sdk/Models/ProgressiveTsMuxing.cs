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
    /// ProgressiveTsMuxing
    /// </summary>

    public class ProgressiveTsMuxing : Muxing
    {
        /// <summary>
        /// Length of the segments in seconds
        /// </summary>
        [JsonProperty(PropertyName = "segmentLength")]
        public double? SegmentLength { get; set; }
        
        /// <summary>
        /// Name of the new Video
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }
        
        /// <summary>
        /// Offset of MPEG-TS timestamps in seconds. E.g., first packet will start with PTS 900,000 for a 10 seconds offset (90,000 MPEG-TS timescale).
        /// </summary>
        [JsonProperty(PropertyName = "startOffset")]
        public double? StartOffset { get; set; }
        
        /// <summary>
        /// Modifies the internal chunk length used for chunked encoding
        /// </summary>
        [JsonProperty(PropertyName = "internalChunkLength")]
        public InternalChunkLength InternalChunkLength { get; set; }
    }

}
