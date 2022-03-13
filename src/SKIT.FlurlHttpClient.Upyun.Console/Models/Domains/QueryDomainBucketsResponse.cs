namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [GET] /domains/buckets 接口的响应。</para>
    /// </summary>
    public class QueryDomainBucketsResponse : UpyunConsoleResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置存储桶名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bucket_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
                public string BucketName { get; set; } = default!;

                /// <summary>
                /// 获取或设置域名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("domain")]
                [System.Text.Json.Serialization.JsonPropertyName("domain")]
                public string DomainName { get; set; } = default!;

                /// <summary>
                /// 获取或设置域名状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("domain_status")]
                [System.Text.Json.Serialization.JsonPropertyName("domain_status")]
                public string DomainStatus { get; set; } = default!;
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
        public Types.Data Data { get; set; } = default!;
    }
}
