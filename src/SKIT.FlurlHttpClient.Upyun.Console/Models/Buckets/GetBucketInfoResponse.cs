using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [GET] /buckets/info 接口的响应。</para>
    /// </summary>
    public class GetBucketInfoResponse : UpyunConsoleResponse
    {
        public static class Types
        {
            public class DefaultDomain
            {
                /// <summary>
                /// 获取或设置域名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("domain")]
                [System.Text.Json.Serialization.JsonPropertyName("domain")]
                public string DomainName { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否是 HTTPS。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("https")]
                [System.Text.Json.Serialization.JsonPropertyName("https")]
                public bool IsHttps { get; set; }

                /// <summary>
                /// 获取或设置是否强制 HTTPS。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("force_https")]
                [System.Text.Json.Serialization.JsonPropertyName("force_https")]
                public bool IsForceHttps { get; set; }
            }
        }

        internal static class Converters
        {
            internal class ResponsePropertyBucketIsHttpsEnabledNewtonsoftJsonConverter : QueryBucketsResponse.Converters.ResponsePropertyBucketIsHttpsEnabledNewtonsoftJsonConverter
            {
            }

            internal class ResponsePropertyBucketIsHttpsEnabledSystemTextJsonConverter : QueryBucketsResponse.Converters.ResponsePropertyBucketIsHttpsEnabledSystemTextJsonConverter
            {
            }
        }

        /// <summary>
        /// 获取或设置业务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_type")]
        [System.Text.Json.Serialization.JsonPropertyName("business_type")]
        public string? BusinessType { get; set; }

        /// <summary>
        /// 获取或设置存储桶名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bucket_name")]
        [System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        public string BucketName { get; set; } = default!;

        /// <summary>
        /// 获取或设置存储桶类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
#pragma warning disable CS8765
        public override string Type { get; set; } = default!;
#pragma warning restore CS8765

        /// <summary>
        /// 获取或设置存储桶状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否开启外链。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("visible")]
        [System.Text.Json.Serialization.JsonPropertyName("visible")]
        public bool IsVisible { get; set; }

        /// <summary>
        /// 获取或设置是否开启 HTTPS。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("https")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponsePropertyBucketIsHttpsEnabledNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("https")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponsePropertyBucketIsHttpsEnabledSystemTextJsonConverter))]
        public bool IsHttpsEnabled { get; set; }

        /// <summary>
        /// 获取或设置存储桶备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bucket_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("bucket_remark")]
        public string? BucketRemark { get; set; }

        /// <summary>
        /// 获取或设置创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("created_at")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }

        /// <summary>
        /// 获取或设置默认域名信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("default_domain")]
        [System.Text.Json.Serialization.JsonPropertyName("default_domain")]
        public Types.DefaultDomain? DefaultDomain { get; set; }

        /// <summary>
        /// 获取或设置审核通过的域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("approval_domains")]
        [System.Text.Json.Serialization.JsonPropertyName("approval_domains")]
        public string[] ApprovedDomainNameList { get; set; } = default!;

        /// <summary>
        /// 获取或设置审核未通过的域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("disapproval_domains")]
        [System.Text.Json.Serialization.JsonPropertyName("disapproval_domains")]
        public string[] DisapprovedDomainNameList { get; set; } = default!;

        /// <summary>
        /// 获取或设置等待审核的域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("approvaling_domains")]
        [System.Text.Json.Serialization.JsonPropertyName("approvaling_domains")]
        public string[]? ApprovingDomainNameList { get; set; }

        /// <summary>
        /// 获取或设置审核通过的域名 HTTPS 状态字典。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("approval_domains_https")]
        [System.Text.Json.Serialization.JsonPropertyName("approval_domains_https")]
        public IDictionary<string, bool>? ApprovedDomainHttpsStatusMap { get; set; }

        /// <summary>
        /// 获取或设置 Form API 密钥。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("form_api_secret")]
        [System.Text.Json.Serialization.JsonPropertyName("form_api_secret")]
        public string? FormApiSecret { get; set; }

        /// <summary>
        /// 获取或设置缩略图版本分隔符。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("separator")]
        [System.Text.Json.Serialization.JsonPropertyName("separator")]
        public string? Separator { get; set; }

        /// <summary>
        /// 获取或设置是否是融合 CDN。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fusion_cdn")]
        [System.Text.Json.Serialization.JsonPropertyName("fusion_cdn")]
        public bool? IsFusionCDN { get; set; }

        /// <summary>
        /// 获取或设置是否是安全加速 CDN。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("security_cdn")]
        [System.Text.Json.Serialization.JsonPropertyName("security_cdn")]
        public bool? IsSecurityCDN { get; set; }

        /// <summary>
        /// 获取或设置是否是 Websocket 服务。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("websocket")]
        [System.Text.Json.Serialization.JsonPropertyName("websocket")]
        public bool? IsWebsocket { get; set; }

        /// <summary>
        /// 获取或设置是否为低频文件存储。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("infrequent_access")]
        [System.Text.Json.Serialization.JsonPropertyName("infrequent_access")]
        public bool? IsInfrequentAccess { get; set; }

        /// <summary>
        /// 获取或设置是否是海外加速服务。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("abroad")]
        [System.Text.Json.Serialization.JsonPropertyName("abroad")]
        public bool? IsAbroad { get; set; }

        /// <summary>
        /// 获取或设置服务操作员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operators")]
        [System.Text.Json.Serialization.JsonPropertyName("operators")]
        public string[] OperatorNameList { get; set; } = default!;
    }
}
