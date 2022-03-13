namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [POST] /preheat 接口的请求。</para>
    /// </summary>
    public class CreatePreheatRequest : UpyunConsoleRequest
    {
        /// <summary>
        /// 获取或设置存储桶名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bucket")]
        [System.Text.Json.Serialization.JsonPropertyName("bucket")]
        public string? BucketName { get; set; }

        /// <summary>
        /// 获取或设置预热 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置预热字节范围字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("range_bytes")]
        [System.Text.Json.Serialization.JsonPropertyName("range_bytes")]
        public string? RangeString { get; set; }
    }
}
