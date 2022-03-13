namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [PUT] /buckets/domains 接口的请求。</para>
    /// </summary>
    public class AddBucketDomainRequest : UpyunConsoleRequest
    {
        /// <summary>
        /// 获取或设置存储桶名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bucket_name")]
        [System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        public string BucketName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置域名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain")]
        [System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string DomainName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置域名类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 获取或设置审核结果回调地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("callback")]
        [System.Text.Json.Serialization.JsonPropertyName("callback")]
        public string? CallbackUrl { get; set; }
    }
}
