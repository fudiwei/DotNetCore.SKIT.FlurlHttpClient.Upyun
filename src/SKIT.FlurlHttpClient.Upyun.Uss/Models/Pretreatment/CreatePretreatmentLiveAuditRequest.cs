namespace SKIT.FlurlHttpClient.Upyun.Uss.Models
{
    /// <summary>
    /// <para>表示 [POST] /{service}/liveaudit/create 接口的请求。</para>
    /// </summary>
    public class CreatePretreatmentLiveAuditRequest : UpyunUssRequest
    {
        /// <summary>
        /// 获取或设置存储桶名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service")]
        [System.Text.Json.Serialization.JsonPropertyName("service")]
        public string BucketName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 RTMP 流地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source")]
        [System.Text.Json.Serialization.JsonPropertyName("source")]
        public string Source { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置异步通知 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string NotifyUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置截图保存路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("save_as")]
        [System.Text.Json.Serialization.JsonPropertyName("save_as")]
        public string? SaveAs { get; set; }

        /// <summary>
        /// 获取或设置截图间隔时间（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("interval")]
        [System.Text.Json.Serialization.JsonPropertyName("interval")]
        public int? Interval { get; set; }

        /// <summary>
        /// 获取或设置截图保存尺寸字符串（格式：宽x高）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resize")]
        [System.Text.Json.Serialization.JsonPropertyName("resize")]
        public string? ResizeString { get; set; }
    }
}
