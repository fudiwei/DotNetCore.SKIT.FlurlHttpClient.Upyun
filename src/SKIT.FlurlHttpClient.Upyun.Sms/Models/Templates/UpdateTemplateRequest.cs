namespace SKIT.FlurlHttpClient.Upyun.Sms.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /templates/{template_id} 接口的请求。</para>
    /// </summary>
    public class UpdateTemplateRequest : UpyunSmsRequest
    {
        /// <summary>
        /// 获取或设置模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int TemplateId { get; set; }

        /// <summary>
        /// 获取或设置模板标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 获取或设置模板内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 获取或设置模版签名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("temp_sign")]
        [System.Text.Json.Serialization.JsonPropertyName("temp_sign")]
        public string? Signature { get; set; }

        /// <summary>
        /// 获取或设置模版签名位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_location")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_location")]
        public string? SignLocation { get; set; }
    }
}
