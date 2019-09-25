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
    /// AdAnalyticsContainsFilter
    /// </summary>

    public class AdAnalyticsContainsFilter : AdAnalyticsAbstractFilter
    {
        [JsonProperty(PropertyName = "operator")]
        private readonly string _operator = "CONTAINS";

        /// <summary>
        /// Value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public Object Value { get; set; }
    }

}
