namespace SKIT.FlurlHttpClient.Upyun.Sms.Models
{
    /// <summary>
    /// <para>表示 [POST] /messages 接口的响应。</para>
    /// </summary>
    public class SendMessageResponse : UpyunSmsResponse
    {
        public static class Types
        {
            public class Message
            {
                /// <summary>
                /// 获取或设置二级返回码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("report_code")]
                [System.Text.Json.Serialization.JsonPropertyName("report_code")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int ReportCode { get; set; }

                /// <summary>
                /// 获取或设置错误情况。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("error_code")]
                [System.Text.Json.Serialization.JsonPropertyName("error_code")]
                public string? ErrorCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置消息编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msg_id")]
                [System.Text.Json.Serialization.JsonPropertyName("msg_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string? MessageId { get; set; }

                /// <summary>
                /// 获取或设置手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                public string MobileNumber { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置一级返回码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public int ReturnCode { get; set; }

        /// <summary>
        /// 获取或设置模板标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("message_ids")]
        public Types.Message[] MessageList { get; set; } = default!;

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ReturnCode == 0;
        }
    }
}
