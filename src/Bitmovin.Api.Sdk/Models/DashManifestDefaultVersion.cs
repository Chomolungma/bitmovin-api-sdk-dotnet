using System.Runtime.Serialization;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// DashManifestDefaultVersion
    /// </summary>
    public enum DashManifestDefaultVersion
    {
        /// <summary>
        /// V1
        /// </summary>
        [EnumMember(Value = "V1")]
        V1,

        /// <summary>
        /// V2
        /// </summary>
        [EnumMember(Value = "V2")]
        V2
    }
}
