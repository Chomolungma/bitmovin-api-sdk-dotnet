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
    /// CloudRegion
    /// </summary>
    public enum CloudRegion
    {
        /// <summary>
        /// AWS_US_EAST_1
        /// </summary>
        [EnumMember(Value = "AWS_US_EAST_1")]
        AWS_US_EAST_1,
        
        /// <summary>
        /// AWS_US_EAST_2
        /// </summary>
        [EnumMember(Value = "AWS_US_EAST_2")]
        AWS_US_EAST_2,
        
        /// <summary>
        /// AWS_US_WEST_1
        /// </summary>
        [EnumMember(Value = "AWS_US_WEST_1")]
        AWS_US_WEST_1,
        
        /// <summary>
        /// AWS_US_WEST_2
        /// </summary>
        [EnumMember(Value = "AWS_US_WEST_2")]
        AWS_US_WEST_2,
        
        /// <summary>
        /// AWS_EU_WEST_1
        /// </summary>
        [EnumMember(Value = "AWS_EU_WEST_1")]
        AWS_EU_WEST_1,
        
        /// <summary>
        /// AWS_EU_CENTRAL_1
        /// </summary>
        [EnumMember(Value = "AWS_EU_CENTRAL_1")]
        AWS_EU_CENTRAL_1,
        
        /// <summary>
        /// AWS_AP_SOUTHEAST_1
        /// </summary>
        [EnumMember(Value = "AWS_AP_SOUTHEAST_1")]
        AWS_AP_SOUTHEAST_1,
        
        /// <summary>
        /// AWS_AP_SOUTHEAST_2
        /// </summary>
        [EnumMember(Value = "AWS_AP_SOUTHEAST_2")]
        AWS_AP_SOUTHEAST_2,
        
        /// <summary>
        /// AWS_AP_NORTHEAST_1
        /// </summary>
        [EnumMember(Value = "AWS_AP_NORTHEAST_1")]
        AWS_AP_NORTHEAST_1,
        
        /// <summary>
        /// AWS_AP_NORTHEAST_2
        /// </summary>
        [EnumMember(Value = "AWS_AP_NORTHEAST_2")]
        AWS_AP_NORTHEAST_2,
        
        /// <summary>
        /// AWS_AP_SOUTH_1
        /// </summary>
        [EnumMember(Value = "AWS_AP_SOUTH_1")]
        AWS_AP_SOUTH_1,
        
        /// <summary>
        /// AWS_SA_EAST_1
        /// </summary>
        [EnumMember(Value = "AWS_SA_EAST_1")]
        AWS_SA_EAST_1,
        
        /// <summary>
        /// Google Council Bluffs, Iowa, USA
        /// </summary>
        [EnumMember(Value = "GOOGLE_US_CENTRAL_1")]
        GOOGLE_US_CENTRAL_1,
        
        /// <summary>
        /// Google Moncks Corner, South Carolina, USA
        /// </summary>
        [EnumMember(Value = "GOOGLE_US_EAST_1")]
        GOOGLE_US_EAST_1,
        
        /// <summary>
        /// Google Changhua County, Taiwan
        /// </summary>
        [EnumMember(Value = "GOOGLE_ASIA_EAST_1")]
        GOOGLE_ASIA_EAST_1,
        
        /// <summary>
        /// Google St. Ghislain, Belgium
        /// </summary>
        [EnumMember(Value = "GOOGLE_EUROPE_WEST_1")]
        GOOGLE_EUROPE_WEST_1,
        
        /// <summary>
        /// Google The Dalles, Oregon, USA
        /// </summary>
        [EnumMember(Value = "GOOGLE_US_WEST_1")]
        GOOGLE_US_WEST_1,
        
        /// <summary>
        /// Google Hong Kong
        /// </summary>
        [EnumMember(Value = "GOOGLE_ASIA_EAST_2")]
        GOOGLE_ASIA_EAST_2,
        
        /// <summary>
        /// Google Tokyo, Japan
        /// </summary>
        [EnumMember(Value = "GOOGLE_ASIA_NORTHEAST_1")]
        GOOGLE_ASIA_NORTHEAST_1,
        
        /// <summary>
        /// Google Mumbai, India
        /// </summary>
        [EnumMember(Value = "GOOGLE_ASIA_SOUTH_1")]
        GOOGLE_ASIA_SOUTH_1,
        
        /// <summary>
        /// Google Jurong West, Singapore
        /// </summary>
        [EnumMember(Value = "GOOGLE_ASIA_SOUTHEAST_1")]
        GOOGLE_ASIA_SOUTHEAST_1,
        
        /// <summary>
        /// Google Sydney, Australia
        /// </summary>
        [EnumMember(Value = "GOOGLE_AUSTRALIA_SOUTHEAST_1")]
        GOOGLE_AUSTRALIA_SOUTHEAST_1,
        
        /// <summary>
        /// Google Hamina, Finland
        /// </summary>
        [EnumMember(Value = "GOOGLE_EUROPE_NORTH_1")]
        GOOGLE_EUROPE_NORTH_1,
        
        /// <summary>
        /// Google London, England, UK
        /// </summary>
        [EnumMember(Value = "GOOGLE_EUROPE_WEST_2")]
        GOOGLE_EUROPE_WEST_2,
        
        /// <summary>
        /// Google Eemshaven, Netherlands
        /// </summary>
        [EnumMember(Value = "GOOGLE_EUROPE_WEST_4")]
        GOOGLE_EUROPE_WEST_4,
        
        /// <summary>
        /// Google Montréal, Québec, Canada
        /// </summary>
        [EnumMember(Value = "GOOGLE_NORTHAMERICA_NORTHEAST_1")]
        GOOGLE_NORTHAMERICA_NORTHEAST_1,
        
        /// <summary>
        /// Google São Paulo, Brazil
        /// </summary>
        [EnumMember(Value = "GOOGLE_SOUTHAMERICA_EAST_1")]
        GOOGLE_SOUTHAMERICA_EAST_1,
        
        /// <summary>
        /// Google Ashburn, Northern Virginia, USA
        /// </summary>
        [EnumMember(Value = "GOOGLE_US_EAST_4")]
        GOOGLE_US_EAST_4,
        
        /// <summary>
        /// Google Los Angeles, California, USA
        /// </summary>
        [EnumMember(Value = "GOOGLE_US_WEST_2")]
        GOOGLE_US_WEST_2,
        
        /// <summary>
        /// AZURE_EUROPE_WEST
        /// </summary>
        [EnumMember(Value = "AZURE_EUROPE_WEST")]
        AZURE_EUROPE_WEST,
        
        /// <summary>
        /// AZURE_US_WEST2
        /// </summary>
        [EnumMember(Value = "AZURE_US_WEST2")]
        AZURE_US_WEST2,
        
        /// <summary>
        /// AZURE_US_EAST
        /// </summary>
        [EnumMember(Value = "AZURE_US_EAST")]
        AZURE_US_EAST,
        
        /// <summary>
        /// AZURE_AUSTRALIA_SOUTHEAST
        /// </summary>
        [EnumMember(Value = "AZURE_AUSTRALIA_SOUTHEAST")]
        AZURE_AUSTRALIA_SOUTHEAST,
        
        /// <summary>
        /// NORTH_AMERICA
        /// </summary>
        [EnumMember(Value = "NORTH_AMERICA")]
        NORTH_AMERICA,
        
        /// <summary>
        /// SOUTH_AMERICA
        /// </summary>
        [EnumMember(Value = "SOUTH_AMERICA")]
        SOUTH_AMERICA,
        
        /// <summary>
        /// EUROPE
        /// </summary>
        [EnumMember(Value = "EUROPE")]
        EUROPE,
        
        /// <summary>
        /// AFRICA
        /// </summary>
        [EnumMember(Value = "AFRICA")]
        AFRICA,
        
        /// <summary>
        /// ASIA
        /// </summary>
        [EnumMember(Value = "ASIA")]
        ASIA,
        
        /// <summary>
        /// AUSTRALIA
        /// </summary>
        [EnumMember(Value = "AUSTRALIA")]
        AUSTRALIA,
        
        /// <summary>
        /// AWS
        /// </summary>
        [EnumMember(Value = "AWS")]
        AWS,
        
        /// <summary>
        /// GOOGLE
        /// </summary>
        [EnumMember(Value = "GOOGLE")]
        GOOGLE,
        
        /// <summary>
        /// KUBERNETES
        /// </summary>
        [EnumMember(Value = "KUBERNETES")]
        KUBERNETES,
        
        /// <summary>
        /// EXTERNAL
        /// </summary>
        [EnumMember(Value = "EXTERNAL")]
        EXTERNAL,
        
        /// <summary>
        /// AUTO
        /// </summary>
        [EnumMember(Value = "AUTO")]
        AUTO
        
    }

}