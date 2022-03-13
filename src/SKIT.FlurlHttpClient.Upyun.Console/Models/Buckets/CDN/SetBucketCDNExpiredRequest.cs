namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [POST] /buckets/cdn/expired 接口的请求。</para>
    /// </summary>
    public class SetBucketCDNExpiredRequest : UpyunConsoleRequest
    {
        /// <summary>
        /// 获取或设置存储桶名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bucket_name")]
        [System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        public string BucketName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 CDN 缓存时间（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expired")]
        [System.Text.Json.Serialization.JsonPropertyName("expired")]
        public int? ExpiresIn { get; set; }
    }
}
