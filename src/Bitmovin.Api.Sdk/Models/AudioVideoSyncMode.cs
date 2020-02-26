using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// AudioVideoSyncMode
    /// </summary>
    public enum AudioVideoSyncMode
    {
        /// <summary>
        /// Default audio video sync handling
        /// </summary>
        [EnumMember(Value = "STANDARD")]
        STANDARD,

        /// <summary>
        /// Adds a sync at the start of the file. Useful if the source file was cut out of already encoded content.
        /// </summary>
        [EnumMember(Value = "RESYNC_AT_START")]
        RESYNC_AT_START
    }
}
