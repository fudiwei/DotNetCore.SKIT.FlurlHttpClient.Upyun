namespace SKIT.FlurlHttpClient.Upyun.Sms.Models
{
    /// <summary>
    /// <para>表示 [GET] /users/remain 接口的响应。</para>
    /// </summary>
    public class GetUserRemainResponse : UpyunSmsResponse
    {
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
