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
    /// PositionMode
    /// </summary>
    public enum PositionMode
    {
        /// <summary>
        /// The custom tag will be inserted in the manifest at a certain keyframe id and segment cut. (https://bitmovin.com/encoding-documentation/bitmovin-api/#/reference/encoding/encodings/create-keyframes)
        /// </summary>
        [EnumMember(Value = "KEYFRAME")]
        KEYFRAME,
        
        /// <summary>
        /// The custom tag will be inserted before the segment that is closest to that time (in seconds).
        /// </summary>
        [EnumMember(Value = "TIME")]
        TIME,
        
        /// <summary>
        /// The custom tag will be inserted before the specified segment number.
        /// </summary>
        [EnumMember(Value = "SEGMENT")]
        SEGMENT
        
    }

}
