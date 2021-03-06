using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// BAdapt
    /// </summary>
    public enum BAdapt
    {
        /// <summary>
        /// Very fast, but not recommended
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,

        /// <summary>
        /// A good balance between speed and quality
        /// </summary>
        [EnumMember(Value = "FAST")]
        FAST,

        /// <summary>
        /// Best Quality, but slow with high bframes
        /// </summary>
        [EnumMember(Value = "FULL")]
        FULL
    }
}
