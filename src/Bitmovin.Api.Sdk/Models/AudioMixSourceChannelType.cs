using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// Type of this source channel
    /// </summary>
    public enum AudioMixSourceChannelType
    {
        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "CHANNEL_NUMBER")]
        CHANNELNUMBER,

        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "FRONT_LEFT")]
        FRONTLEFT,

        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "FRONT_RIGHT")]
        FRONTRIGHT,

        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "CENTER")]
        CENTER,

        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "LOW_FREQUENCY")]
        LOWFREQUENCY,

        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "BACK_LEFT")]
        BACKLEFT,

        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "BACK_RIGHT")]
        BACKRIGHT,

        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "SURROUND_LEFT")]
        SURROUNDLEFT,

        /// <summary>
        /// Type of this source channel
        /// </summary>
        [EnumMember(Value = "SURROUND_RIGHT")]
        SURROUNDRIGHT
    }
}
