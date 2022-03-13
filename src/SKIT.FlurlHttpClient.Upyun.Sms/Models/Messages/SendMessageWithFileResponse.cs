namespace SKIT.FlurlHttpClient.Upyun.Sms.Models
{
    /// <summary>
    /// <para>表示 [POST] /messages/file 接口的响应。</para>
    /// </summary>
    public class SendMessageWithFileResponse : UpyunSmsResponse
    {
        /// <summary>
        /// 获取或设置一级返回码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public int ReturnCode { get; set; }

        /// <summary>
        /// 获取或设置错误情况。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message")]
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? ReturnMessage { get; set; } = default!;

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ReturnCode == 0;
        }
    }
}
