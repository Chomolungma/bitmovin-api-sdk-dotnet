using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// MinCodingUnitSize
    /// </summary>
    public enum MinCodingUnitSize
    {
        /// <summary>
        /// minimum 8x8 CU
        /// </summary>
        [EnumMember(Value = "MCU_8x8")]
        MCU_8x8,

        /// <summary>
        /// minimum 16x16 CU
        /// </summary>
        [EnumMember(Value = "MCU_16x16")]
        MCU_16x16,

        /// <summary>
        /// minimum 32x32 CU
        /// </summary>
        [EnumMember(Value = "MCU_32x32")]
        MCU_32x32
    }
}
