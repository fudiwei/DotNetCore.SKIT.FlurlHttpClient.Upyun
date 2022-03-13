namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [POST] /buckets/cdn/expired 接口的响应。</para>
    /// </summary>
    public class SetBucketCDNExpiredResponse : UpyunConsoleResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置 CDN 缓存时间（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expired")]
                [System.Text.Json.Serialization.JsonPropertyName("expired")]
                public int? ExpiresIn { get; set; }
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
