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
    /// LiveEncodingStatsEvent
    /// </summary>

    public class LiveEncodingStatsEvent
    {
        /// <summary>
        /// Timestamp of the event expressed in UTC: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public DateTime? Time { get; set; }
        
        /// <summary>
        /// Details
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public LiveEncodingStatsEventDetails Details { get; set; }
    }

}
