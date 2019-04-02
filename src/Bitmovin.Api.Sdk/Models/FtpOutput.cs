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
    /// FtpOutput
    /// </summary>

    public class FtpOutput : Output
    {
        /// <summary>
        /// Host URL or IP of the FTP server
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }
        
        /// <summary>
        /// Port to use, standard for FTP: 21
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
        
        /// <summary>
        /// Use passive mode. Default is true.
        /// </summary>
        [JsonProperty(PropertyName = "passive")]
        public bool? Passive { get; set; }
        
        /// <summary>
        /// Your FTP Username
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        /// <summary>
        /// Your FTP password
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        
        /// <summary>
        /// Controls which transfer version should be used
        /// </summary>
        [JsonProperty(PropertyName = "transferVersion")]
        public TransferVersion TransferVersion { get; set; }
        
        /// <summary>
        /// Restrict maximum concurrent connections. Requires at least version 1.1.0.
        /// </summary>
        [JsonProperty(PropertyName = "maxConcurrentConnections")]
        public int? MaxConcurrentConnections { get; set; }
    }

}
