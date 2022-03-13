namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [POST] /security/qs 接口的请求。</para>
    /// </summary>
    public class SetSecurityQueryStringRequest : UpyunConsoleRequest
    {
        /// <summary>
        /// 获取或设置存储桶名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bucket_name")]
        [System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        public string BucketName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置全程跟随状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("args_follow")]
        [System.Text.Json.Serialization.JsonPropertyName("args_follow")]
        public string? ArgumentsFollowStatus { get; set; }

        /// <summary>
        /// 获取或设置回源跟随状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("args_restore")]
        [System.Text.Json.Serialization.JsonPropertyName("args_restore")]
        public string? ArgumentsRestoreStatus { get; set; }
    }
}
