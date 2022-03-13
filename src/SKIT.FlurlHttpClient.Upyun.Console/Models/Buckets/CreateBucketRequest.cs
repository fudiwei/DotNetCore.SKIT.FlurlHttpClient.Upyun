namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [POST] /buckets 接口的请求。</para>
    /// </summary>
    public class CreateBucketRequest : UpyunConsoleRequest
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
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置业务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_type")]
        [System.Text.Json.Serialization.JsonPropertyName("business_type")]
        public string? BusinessType { get; set; }

        /// <summary>
        /// 获取或设置存储桶备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bucket_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("bucket_remark")]
        public string? BucketRemark { get; set; }

        /// <summary>
        /// 获取或设置是否是 Websocket 服务。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("websocket")]
        [System.Text.Json.Serialization.JsonPropertyName("websocket")]
        public bool? IsWebsocket { get; set; }

        /// <summary>
        /// 获取或设置是否为低频文件存储。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("infrequent_access")]
        [System.Text.Json.Serialization.JsonPropertyName("infrequent_access")]
        public bool? IsInfrequentAccess { get; set; }
    }
}
