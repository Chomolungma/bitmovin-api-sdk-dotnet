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
    /// FilterType
    /// </summary>
    public enum FilterType
    {
        /// <summary>
        /// CROP
        /// </summary>
        [EnumMember(Value = "CROP")]
        CROP,
        
        /// <summary>
        /// WATERMARK
        /// </summary>
        [EnumMember(Value = "WATERMARK")]
        WATERMARK,
        
        /// <summary>
        /// ENHANCEDWATERMARK
        /// </summary>
        [EnumMember(Value = "ENHANCED_WATERMARK")]
        ENHANCEDWATERMARK,
        
        /// <summary>
        /// ROTATE
        /// </summary>
        [EnumMember(Value = "ROTATE")]
        ROTATE,
        
        /// <summary>
        /// DEINTERLACE
        /// </summary>
        [EnumMember(Value = "DEINTERLACE")]
        DEINTERLACE,
        
        /// <summary>
        /// AUDIOMIX
        /// </summary>
        [EnumMember(Value = "AUDIO_MIX")]
        AUDIOMIX,
        
        /// <summary>
        /// DENOISEHQDN3D
        /// </summary>
        [EnumMember(Value = "DENOISE_HQDN3D")]
        DENOISEHQDN3D,
        
        /// <summary>
        /// TEXT
        /// </summary>
        [EnumMember(Value = "TEXT")]
        TEXT,
        
        /// <summary>
        /// UNSHARP
        /// </summary>
        [EnumMember(Value = "UNSHARP")]
        UNSHARP,
        
        /// <summary>
        /// SCALE
        /// </summary>
        [EnumMember(Value = "SCALE")]
        SCALE,
        
        /// <summary>
        /// INTERLACE
        /// </summary>
        [EnumMember(Value = "INTERLACE")]
        INTERLACE,
        
        /// <summary>
        /// AUDIOVOLUME
        /// </summary>
        [EnumMember(Value = "AUDIO_VOLUME")]
        AUDIOVOLUME
        
    }

}
