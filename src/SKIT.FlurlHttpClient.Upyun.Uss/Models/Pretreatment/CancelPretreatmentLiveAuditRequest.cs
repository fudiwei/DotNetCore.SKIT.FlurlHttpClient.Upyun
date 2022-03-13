namespace SKIT.FlurlHttpClient.Upyun.Uss.Models
{
    /// <summary>
    /// <para>表示 [POST] /{service}/liveaudit/cancel 接口的请求。</para>
    /// </summary>
    public class CancelPretreatmentLiveAuditRequest : UpyunUssRequest
    {
        /// <summary>
        /// 获取或设置存储桶名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service")]
        [System.Text.Json.Serialization.JsonPropertyName("service")]
        public string BucketName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string TaskId { get; set; } = string.Empty;
    }
}
