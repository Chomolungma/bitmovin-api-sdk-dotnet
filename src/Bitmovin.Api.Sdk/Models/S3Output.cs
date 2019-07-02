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
    /// S3Output
    /// </summary>

    public class S3Output : Output
    {
        /// <summary>
        /// Amazon S3 bucket name (required)
        /// </summary>
        [JsonProperty(PropertyName = "bucketName")]
        public string BucketName { get; set; }
        
        /// <summary>
        /// Amazon S3 access key (required)
        /// </summary>
        [JsonProperty(PropertyName = "accessKey")]
        public string AccessKey { get; set; }
        
        /// <summary>
        /// Amazon S3 secret key (required)
        /// </summary>
        [JsonProperty(PropertyName = "secretKey")]
        public string SecretKey { get; set; }
        
        /// <summary>
        /// If set a user defined tag (x-amz-meta-) with that key will be used to store the MD5 hash of the file.
        /// </summary>
        [JsonProperty(PropertyName = "md5MetaTag")]
        public string Md5MetaTag { get; set; }
        
        /// <summary>
        /// CloudRegion
        /// </summary>
        [JsonProperty(PropertyName = "cloudRegion")]
        public AwsCloudRegion? CloudRegion { get; set; }
        
        /// <summary>
        /// SignatureVersion
        /// </summary>
        [JsonProperty(PropertyName = "signatureVersion")]
        public S3SignatureVersion? SignatureVersion { get; set; }
    }

}
