namespace SKIT.FlurlHttpClient.Upyun.Sms.Models
{
    /// <summary>
    /// <para>表示 [POST] /messages/async 接口的响应。</para>
    /// </summary>
    public class SendMessageAsynchronouslyResponse : UpyunSmsResponse
    {
        /// <summary>
        /// 获取或设置返回码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public int ReturnCode { get; set; }

        /// <summary>
        /// 获取或设置返回信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message")]
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? ReturnMessage { get; set; } = default!;

        /// <summary>
        /// 获取或设置消息编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
        public string? MessageId { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ReturnCode == 0;
        }
    }
}
