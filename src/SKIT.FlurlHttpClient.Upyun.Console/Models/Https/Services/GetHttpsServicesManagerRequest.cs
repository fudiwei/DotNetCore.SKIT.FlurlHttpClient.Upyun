namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [GET] /https/services/manager 接口的请求。</para>
    /// </summary>
    public class GetHttpsServicesManagerRequest : UpyunConsoleRequest
    {
        /// <summary>
        /// 获取或设置域名。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string DomainName { get; set; } = string.Empty;
    }
}
