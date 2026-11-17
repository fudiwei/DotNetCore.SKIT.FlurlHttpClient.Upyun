namespace SKIT.FlurlHttpClient.Upyun.Uss.Models
{
    /// <summary>
    /// <para>表示 [POST] /pretreatment/ 接口的请求。</para>
    /// </summary>
    public class CreatePretreatmentImageAuditRequest : UpyunUssRequest
    {
        public static class Types
        {
            public class Task
            {
                /// <summary>
                /// 获取或设置文件路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source")]
                [System.Text.Json.Serialization.JsonPropertyName("source")]
                public string? FileKey { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置存储桶名。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? BucketName { get; set; }

        /// <summary>
        /// 获取或设置任务列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public List<Types.Task>? TaskList { get; set; }

        /// <summary>
        /// 获取或设置异步通知 URL。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? NotifyUrl { get; set; }
    }
}
