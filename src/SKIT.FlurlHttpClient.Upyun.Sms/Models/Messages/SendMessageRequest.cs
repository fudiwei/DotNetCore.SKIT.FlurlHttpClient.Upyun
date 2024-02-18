using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Upyun.Sms.Models
{
    /// <summary>
    /// <para>表示 [POST] /messages 接口的请求。</para>
    /// </summary>
    public class SendMessageRequest : UpyunSmsRequest
    {
        /// <summary>
        /// 获取或设置手机号码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("mobile")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedStringListWithCommaSplitConverter))]
        public IList<string> MobileNumberList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public int TemplateId { get; set; }

        /// <summary>
        /// 获取或设置自定义签名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign")]
        [System.Text.Json.Serialization.JsonPropertyName("sign")]
        public string? Signature { get; set; }

        /// <summary>
        /// 获取或设置短信参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("variables")]
        [System.Text.Json.Serialization.JsonPropertyName("variables")]
        public IList<string>? VariableList { get; set; }

        /// <summary>
        /// 获取或设置拓展码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extend_code")]
        [System.Text.Json.Serialization.JsonPropertyName("extend_code")]
        public string? ExtendCode { get; set; }
    }
}
