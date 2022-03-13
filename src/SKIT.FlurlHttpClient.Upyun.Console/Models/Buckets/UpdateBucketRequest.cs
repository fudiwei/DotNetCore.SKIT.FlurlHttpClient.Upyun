namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [PUT] /buckets 接口的请求。</para>
    /// </summary>
    public class UpdateBucketRequest : UpyunConsoleRequest
    {
        /// <summary>
        /// 获取或设置存储桶名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bucket_name")]
        [System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        public string BucketName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置存储桶类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}
