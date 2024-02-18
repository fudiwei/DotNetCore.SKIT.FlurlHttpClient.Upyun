using System;

namespace SKIT.FlurlHttpClient.Upyun.Sms.Models
{
    /// <summary>
    /// <para>表示 [POST] /messages/async 接口的请求。</para>
    /// </summary>
    public class SendMessageAsynchronouslyRequest : SendMessageRequest
    {
        /// <summary>
        /// 获取或设置指定发送时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
        public DateTimeOffset? DateTime { get; set; }

        /// <summary>
        /// 获取或设置自定义字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom")]
        [System.Text.Json.Serialization.JsonPropertyName("custom")]
        public string? CustomField { get; set; }
    }
}
