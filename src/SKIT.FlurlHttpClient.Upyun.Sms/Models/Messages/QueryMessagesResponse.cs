using System;

namespace SKIT.FlurlHttpClient.Upyun.Sms.Models
{
    /// <summary>
    /// <para>表示 [GET] /messages 接口的响应。</para>
    /// </summary>
    public class QueryMessagesResponse : UpyunSmsResponse
    {
        public static class Types
        {
            public class Message
            {
                public static class Types
                {
                    public class Owner : QueryTemplatesResponse.Types.Template.Types.Owner
                    {
                    }
                }

                /// <summary>
                /// 获取或设置消息编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string? MessageId { get; set; }

                /// <summary>
                /// 获取或设置模板编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                public int TemplateIdId { get; set; }

                /// <summary>
                /// 获取或设置模板标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置模板内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = default!;

                /// <summary>
                /// 获取或设置模版签名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("temp_sign")]
                [System.Text.Json.Serialization.JsonPropertyName("temp_sign")]
                public string Signature { get; set; } = default!;

                /// <summary>
                /// 获取或设置模板类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置审核类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("report_type")]
                [System.Text.Json.Serialization.JsonPropertyName("report_type")]
                public string ReportType { get; set; } = default!;

                /// <summary>
                /// 获取或设置手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                public string MobileNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置发送状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置短信创建时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("created_at")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("created_at")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }

                /// <summary>
                /// 获取或设置短信发送时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sent_at")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("sent_at")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset? SendTime { get; set; }

                /// <summary>
                /// 获取或设置短信计费条数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quantity")]
                [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                public int Quantity { get; set; }

                /// <summary>
                /// 获取或设置创建者用户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("owner")]
                [System.Text.Json.Serialization.JsonPropertyName("owner")]
                public Types.Owner Owner { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置短信消息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("messages")]
        [System.Text.Json.Serialization.JsonPropertyName("messages")]
        public Types.Message[] MessageList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int TotalCount { get; set; }
    }
}
