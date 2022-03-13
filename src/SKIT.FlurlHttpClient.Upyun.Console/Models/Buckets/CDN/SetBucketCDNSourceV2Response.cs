namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/buckets/cdn/source 接口的响应。</para>
    /// </summary>
    public class SetBucketCDNSourceV2Response : UpyunConsoleResponse
    {
        public static class Types
        {
            public class Data : GetBucketCDNSourceV2Response.Types.Data
            {
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
