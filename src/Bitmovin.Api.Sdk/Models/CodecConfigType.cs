using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// CodecConfigType
    /// </summary>
    public enum CodecConfigType
    {
        /// <summary>
        /// AAC
        /// </summary>
        [EnumMember(Value = "AAC")]
        AAC,

        /// <summary>
        /// HE_AAC_V1
        /// </summary>
        [EnumMember(Value = "HE_AAC_V1")]
        HE_AAC_V1,

        /// <summary>
        /// HE_AAC_V2
        /// </summary>
        [EnumMember(Value = "HE_AAC_V2")]
        HE_AAC_V2,

        /// <summary>
        /// H264
        /// </summary>
        [EnumMember(Value = "H264")]
        H264,

        /// <summary>
        /// H265
        /// </summary>
        [EnumMember(Value = "H265")]
        H265,

        /// <summary>
        /// VP9
        /// </summary>
        [EnumMember(Value = "VP9")]
        VP9,

        /// <summary>
        /// VP8
        /// </summary>
        [EnumMember(Value = "VP8")]
        VP8,

        /// <summary>
        /// MP2
        /// </summary>
        [EnumMember(Value = "MP2")]
        MP2,

        /// <summary>
        /// MP3
        /// </summary>
        [EnumMember(Value = "MP3")]
        MP3,

        /// <summary>
        /// AC3
        /// </summary>
        [EnumMember(Value = "AC3")]
        AC3,

        /// <summary>
        /// EAC3
        /// </summary>
        [EnumMember(Value = "EAC3")]
        EAC3,

        /// <summary>
        /// OPUS
        /// </summary>
        [EnumMember(Value = "OPUS")]
        OPUS,

        /// <summary>
        /// VORBIS
        /// </summary>
        [EnumMember(Value = "VORBIS")]
        VORBIS,

        /// <summary>
        /// MJPEG
        /// </summary>
        [EnumMember(Value = "MJPEG")]
        MJPEG,

        /// <summary>
        /// AV1
        /// </summary>
        [EnumMember(Value = "AV1")]
        AV1
    }
}
