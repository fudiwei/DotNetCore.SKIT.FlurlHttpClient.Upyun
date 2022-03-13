namespace SKIT.FlurlHttpClient.Upyun.Sms.Models
{
    /// <summary>
    /// <para>表示 [GET] /templates 接口的请求。</para>
    /// </summary>
    public class QueryTemplatesRequest : UpyunSmsRequest
    {
        /// <summary>
        /// 获取或设置模板类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Type { get; set; }

        /// <summary>
        /// 获取或设置审核类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ReportType { get; set; }
    }
}
