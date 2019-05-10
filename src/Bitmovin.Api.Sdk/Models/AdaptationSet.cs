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
    /// AdaptationSet
    /// </summary>

    public class AdaptationSet : BitmovinResponse
    {
        /// <summary>
        /// Custom adaptation set attributes
        /// </summary>
        [JsonProperty(PropertyName = "customAttributes")]
        public List<CustomAttribute> CustomAttributes { get; set; }
        
        /// <summary>
        /// Roles of the adaptation set
        /// </summary>
        [JsonProperty(PropertyName = "roles")]
        public List<AdaptationSetRole> Roles { get; set; }
        
        /// <summary>
        /// Provide signaling of CEA 607 and CEA 708
        /// </summary>
        [JsonProperty(PropertyName = "accessibilities")]
        public List<Accessibility> Accessibilities { get; set; }
    }

}