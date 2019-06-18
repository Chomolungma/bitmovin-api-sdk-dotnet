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
    /// Condition
    /// </summary>

    public class Condition : AbstractCondition
    {
        /// <summary>
        /// The attribute that should be used for the evaluation. Valid values include, depending on the context: - HEIGHT - WIDTH - BITRATE - FPS - ASPECTRATIO - INPUTSTREAM - LANGUAGE - CHANNELFORMAT - CHANNELLAYOUT - STREAMCOUNT - AUDIOSTREAMCOUNT - VIDEOSTREAMCOUNT - DURATION - CONNECTION_STATUS - CONNECTION_STATUS_JUST_CHANGED 
        /// </summary>
        [JsonProperty(PropertyName = "attribute")]
        public string Attribute { get; set; }
        
        /// <summary>
        /// The operator that should be used for the evaluation
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public ConditionOperator Operator { get; set; }
        
        /// <summary>
        /// The value that should be used for comparison
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }

}
