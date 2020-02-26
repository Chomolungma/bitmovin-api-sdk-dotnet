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
    /// DefaultManifestAndCondition
    /// </summary>
    public class DefaultManifestAndCondition : DefaultManifestCondition
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "AND";

        /// <summary>
        /// Array to perform the AND evaluation on. This conditions evaluates to true if all sub conditions evaluate to true. 
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public List<DefaultManifestCondition> Conditions { get; set; } = new List<DefaultManifestCondition>();
    }
}
