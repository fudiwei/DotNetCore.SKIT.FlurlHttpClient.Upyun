namespace SKIT.FlurlHttpClient.Upyun.Sms.Models
{
    /// <summary>
    /// <para>表示 [POST] /templates 接口的请求。</para>
    /// </summary>
    public class CreateTemplateRequest : UpyunSmsRequest
    {
        /// <summary>
        /// 获取或设置模板标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置模板内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置模版签名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("temp_sign")]
        [System.Text.Json.Serialization.JsonPropertyName("temp_sign")]
        public string Signature { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置模版签名位置。
        /// <para>默认值：top</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_location")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_location")]
        public string SignLocation { get; set; } = "top";

        /// <summary>
        /// 获取或设置模板类型。
        /// <para>默认值：industry</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "industry";

        /// <summary>
        /// 获取或设置审核类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("report_type")]
        [System.Text.Json.Serialization.JsonPropertyName("report_type")]
        public string? ReportType { get; set; }
    }
}
