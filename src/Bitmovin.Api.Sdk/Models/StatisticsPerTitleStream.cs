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
    /// StatisticsPerTitleStream
    /// </summary>
    public enum StatisticsPerTitleStream
    {
        /// <summary>
        /// DISABLED
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED,
        
        /// <summary>
        /// ENABLED
        /// </summary>
        [EnumMember(Value = "ENABLED")]
        ENABLED
        
    }

}
