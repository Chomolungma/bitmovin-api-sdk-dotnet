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
    /// DomainList
    /// </summary>

    public class DomainList
    {
        /// <summary>
        /// Domains
        /// </summary>
        [JsonProperty(PropertyName = "domains")]
        public List<Domain> Domains { get; set; }
    }

}
