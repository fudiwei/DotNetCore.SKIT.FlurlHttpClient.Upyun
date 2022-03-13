using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/buckets/cdn/cache 接口的请求。</para>
    /// </summary>
    public class SetBucketCDNCacheV2Request : UpyunConsoleRequest
    {
        public static class Types
        {
            public class Rule
            {
                /// <summary>
                /// 获取或设置缓存规则 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public long? RuleId { get; set; }

                /// <summary>
                /// 获取或设置缓存名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置缓存规则。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("uri")]
                [System.Text.Json.Serialization.JsonPropertyName("uri")]
                public string? UrlPattern { get; set; }

                /// <summary>
                /// 获取或设置缓存时间（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expires")]
                [System.Text.Json.Serialization.JsonPropertyName("expires")]
                public int? ExpiresIn { get; set; }

                /// <summary>
                /// 获取或设置缓存类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string? Type { get; set; }

                /// <summary>
                /// 获取或设置优先级。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("priority")]
                [System.Text.Json.Serialization.JsonPropertyName("priority")]
                public int? Priority { get; set; }

                /// <summary>
                /// 获取或设置需要缓存的状态码列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status_codes")]
                [System.Text.Json.Serialization.JsonPropertyName("status_codes")]
                public IList<int>? StatusCodeList { get; set; }

                /// <summary>
                /// 获取或设置需要缓存的响应标头列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("resp_headers")]
                [System.Text.Json.Serialization.JsonPropertyName("resp_headers")]
                public IList<string>? ResponseHeaderList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置存储桶名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bucket_name")]
        [System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        public string BucketName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置缓存规则列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("specific_rules")]
        [System.Text.Json.Serialization.JsonPropertyName("specific_rules")]
        public IList<Types.Rule> SpecificRuleList { get; set; } = new List<Types.Rule>();

        /// <summary>
        /// 获取或设置不缓存规则列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nocache_list")]
        [System.Text.Json.Serialization.JsonPropertyName("nocache_list")]
        public IList<Types.Rule> NoCahceRuleList { get; set; } = new List<Types.Rule>();
    }
}
