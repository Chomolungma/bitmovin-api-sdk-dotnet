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
    /// AzureOutput
    /// </summary>

    public class AzureOutput : Output
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "AZURE";

        /// <summary>
        /// Azure Account Name (required)
        /// </summary>
        [JsonProperty(PropertyName = "accountName")]
        public string AccountName { get; set; }
        
        /// <summary>
        /// Azure Account Key (required)
        /// </summary>
        [JsonProperty(PropertyName = "accountKey")]
        public string AccountKey { get; set; }
        
        /// <summary>
        /// Name of the bucket (required)
        /// </summary>
        [JsonProperty(PropertyName = "container")]
        public string Container { get; set; }
    }

}
