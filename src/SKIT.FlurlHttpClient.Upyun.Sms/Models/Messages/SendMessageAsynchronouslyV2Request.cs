using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Upyun.Sms.Models
{
    /// <summary>
    /// <para>表示 [POST] /messages/async 接口的请求。</para>
    /// </summary>
    public class SendMessageAsynchronouslyV2Request : UpyunSmsRequest
    {
        public static class Types
        {
            public class Mobile
            {
                /// <summary>
                /// 获取或设置手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone")]
                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                public string MobileNumber { get; set; } = string.Empty;

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
            }
        }

        /// <summary>
        /// 获取或设置手机号码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        [System.Text.Json.Serialization.JsonPropertyName("mobile")]
        public IList<Types.Mobile> MobileNumberList { get; set; } = new List<Types.Mobile>();

        /// <summary>
        /// 获取或设置模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public int TemplateId { get; set; }

        /// <summary>
        /// 获取或设置拓展码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extend_code")]
        [System.Text.Json.Serialization.JsonPropertyName("extend_code")]
        public string? ExtendCode { get; set; }

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
