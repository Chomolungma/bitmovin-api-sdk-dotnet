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
    /// FairPlayDrm
    /// </summary>
    public class FairPlayDrm : Drm
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "FAIRPLAY";

        /// <summary>
        /// 16 byte Encryption key, 32 hexadecimal characters (required)
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// 16 byte initialization vector (required)
        /// </summary>
        [JsonProperty(PropertyName = "iv")]
        public string Iv { get; set; }

        /// <summary>
        /// Url of the licensing server
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
    }
}
