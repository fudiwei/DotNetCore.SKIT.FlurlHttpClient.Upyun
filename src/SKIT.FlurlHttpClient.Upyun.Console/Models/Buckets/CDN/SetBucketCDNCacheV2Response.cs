namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/buckets/cdn/cache 接口的响应。</para>
    /// </summary>
    public class SetBucketCDNCacheV2Response : UpyunConsoleResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Rule : SetBucketCDNCacheV2Request.Types.Rule
                    {
                    }
                }

                /// <summary>
                /// 获取或设置存储桶名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bucket_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
                public string? BucketName { get; set; }

                /// <summary>
                /// 获取或设置缓存规则列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("specific_rules")]
                [System.Text.Json.Serialization.JsonPropertyName("specific_rules")]
                public List<Types.Rule>? SpecificRuleList { get; set; }

                /// <summary>
                /// 获取或设置不缓存规则列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nocache_list")]
                [System.Text.Json.Serialization.JsonPropertyName("nocache_list")]
                public List<Types.Rule>? NoCahceRuleList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置操作结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public bool Result { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data? Data { get; set; }
    }
}
