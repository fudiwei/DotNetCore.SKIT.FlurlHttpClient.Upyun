namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [PUT] /buckets/operators 接口的请求。</para>
    /// </summary>
    public class AddBucketOperatorRequest : UpyunConsoleRequest
    {
        /// <summary>
        /// 获取或设置存储桶名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bucket_name")]
        [System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        public string BucketName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置操作员。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator_name")]
        [System.Text.Json.Serialization.JsonPropertyName("operator_name")]
        public string OperatorName { get; set; } = string.Empty;
    }
}
