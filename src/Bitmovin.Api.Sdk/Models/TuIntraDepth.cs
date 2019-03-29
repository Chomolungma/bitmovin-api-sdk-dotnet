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
    /// TuIntraDepth
    /// </summary>
    public enum TuIntraDepth
    {
        /// <summary>
        /// Extra recursion depth for inter coded units
        /// </summary>
        [EnumMember(Value = "1")]
        D1,
        
        /// <summary>
        /// Extra recursion depth for inter coded units
        /// </summary>
        [EnumMember(Value = "2")]
        D2,
        
        /// <summary>
        /// Extra recursion depth for inter coded units
        /// </summary>
        [EnumMember(Value = "3")]
        D3,
        
        /// <summary>
        /// Extra recursion depth for inter coded units
        /// </summary>
        [EnumMember(Value = "4")]
        D4
        
    }

}
