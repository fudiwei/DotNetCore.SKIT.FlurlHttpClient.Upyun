namespace SKIT.FlurlHttpClient.Upyun.Sms.Models
{
    /// <summary>
    /// <para>表示 [POST] /detection/mobile 接口的请求。</para>
    /// </summary>
    public class CreateMobileDetectionRequest : UpyunSmsRequest
    {
        /// <summary>
        /// 获取或设置手机号码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("mobile")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedStringListWithCommaSplitConverter))]
        public List<string>? MobileNumberList { get; set; }
    }
}
