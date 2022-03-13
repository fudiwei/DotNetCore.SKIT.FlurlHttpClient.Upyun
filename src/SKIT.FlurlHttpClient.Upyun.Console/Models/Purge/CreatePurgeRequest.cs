namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [POST] /purge 接口的请求。</para>
    /// </summary>
    public class CreatePurgeRequest : UpyunConsoleRequest
    {
        /// <summary>
        /// 获取或设置存储桶名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bucket")]
        [System.Text.Json.Serialization.JsonPropertyName("bucket")]
        public string? BucketName { get; set; }

        /// <summary>
        /// 获取或设置刷新 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("urls")]
        [System.Text.Json.Serialization.JsonPropertyName("urls")]
        public string Url { get; set; } = string.Empty;
    }
}
