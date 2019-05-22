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
    /// AkamaiMslStreamFormat
    /// </summary>
    public enum AkamaiMslStreamFormat
    {
        /// <summary>
        /// DASH
        /// </summary>
        [EnumMember(Value = "DASH")]
        DASH,
        
        /// <summary>
        /// HLS
        /// </summary>
        [EnumMember(Value = "HLS")]
        HLS,
        
        /// <summary>
        /// CMAF
        /// </summary>
        [EnumMember(Value = "CMAF")]
        CMAF
        
    }

}
