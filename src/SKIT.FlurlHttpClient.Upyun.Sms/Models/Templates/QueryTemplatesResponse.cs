using System;

namespace SKIT.FlurlHttpClient.Upyun.Sms.Models
{
    /// <summary>
    /// <para>表示 [GET] /templates 接口的响应。</para>
    /// </summary>
    public class QueryTemplatesResponse : UpyunSmsResponse
    {
        public static class Types
        {
            public class Template
            {
                public static class Types
                {
                    public class Owner
                    {
                        /// <summary>
                        /// 获取或设置用户编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public int Id { get; set; }

                        /// <summary>
                        /// 获取或设置用户昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置行业短信剩余量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("industry")]
                        [System.Text.Json.Serialization.JsonPropertyName("industry")]
                        public int IndustryQuota { get; set; }

                        /// <summary>
                        /// 获取或设置营销短信剩余量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("marketing")]
                        [System.Text.Json.Serialization.JsonPropertyName("marketing")]
                        public int MarketingQuota { get; set; }

                        /// <summary>
                        /// 获取或设置国际短信剩余量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("intl")]
                        [System.Text.Json.Serialization.JsonPropertyName("intl")]
                        public int InternationalQuota { get; set; }

                        /// <summary>
                        /// 获取或设置印尼短信剩余量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("idn")]
                        [System.Text.Json.Serialization.JsonPropertyName("idn")]
                        public int IndonesianQuota { get; set; }

                        /// <summary>
                        /// 获取或设置印尼短信剩余量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("jpn")]
                        [System.Text.Json.Serialization.JsonPropertyName("jpn")]
                        public int JapaneseQuota { get; set; }

                        /// <summary>
                        /// 获取或设置新加坡短信剩余量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sgp")]
                        [System.Text.Json.Serialization.JsonPropertyName("sgp")]
                        public int SingaporeanQuota { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置模板编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public int Id { get; set; }

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
                /// 获取或设置模版签名位置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sign_location")]
                [System.Text.Json.Serialization.JsonPropertyName("sign_location")]
                public string SignLocation { get; set; } = default!;

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
                /// 获取或设置模板状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置更新时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("updated_at")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("updated_at")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset UpdateTime { get; set; }

                /// <summary>
                /// 获取或设置创建者用户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("owner")]
                [System.Text.Json.Serialization.JsonPropertyName("owner")]
                public Types.Owner Owner { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置短信模板列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("templates")]
        [System.Text.Json.Serialization.JsonPropertyName("templates")]
        public Types.Template[] TemplateList { get; set; } = default!;
    }
}
