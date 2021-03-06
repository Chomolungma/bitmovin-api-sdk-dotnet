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
    /// Organization
    /// </summary>
    public class Organization : BitmovinResource
    {
        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public OrganizationType? Type { get; set; }

        /// <summary>
        /// ID of the parent organization
        /// </summary>
        [JsonProperty(PropertyName = "parentId")]
        public string ParentId { get; internal set; }

        /// <summary>
        /// Hexadecimal color
        /// </summary>
        [JsonProperty(PropertyName = "labelColor")]
        public string LabelColor { get; set; }

        /// <summary>
        /// LimitsPerResource
        /// </summary>
        [JsonProperty(PropertyName = "limitsPerResource")]
        public List<ResourceLimitContainer> LimitsPerResource { get; set; } = new List<ResourceLimitContainer>();
    }
}
