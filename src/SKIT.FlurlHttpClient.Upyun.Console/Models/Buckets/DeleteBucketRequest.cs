namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [POST] /buckets/delete 接口的请求。</para>
    /// </summary>
    public class DeleteBucketRequest : UpyunConsoleRequest
    {
        /// <summary>
        /// 获取或设置又拍云服务管理后台密码。如果不指定将使用构造 <see cref="UpyunConsoleClient"/> 时的 <see cref="UpyunConsoleClientOptions.Password"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("password")]
        [System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// 获取或设置存储桶名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bucket_name")]
        [System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        public string BucketName { get; set; } = string.Empty;
    }
}
