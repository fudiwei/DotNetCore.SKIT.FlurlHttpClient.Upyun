namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [GET] /buckets/operators 接口的请求。</para>
    /// </summary>
    public class QueryBucketOperatorsRequest : UpyunConsoleRequest
    {
        /// <summary>
        /// 获取或设置存储桶名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bucket_name")]
        [System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        public string BucketName { get; set; } = string.Empty;
    }
}
