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
    /// EmailNotification
    /// </summary>
    public class EmailNotification : Notification
    {
        /// <summary>
        /// Emails
        /// </summary>
        [JsonProperty(PropertyName = "emails")]
        public List<string> Emails { get; set; } = new List<string>();
    }
}
