namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [GET] /domains/buckets 接口的请求。</para>
    /// </summary>
    public class QueryDomainBucketsRequest : UpyunConsoleRequest
    {
        /// <summary>
        /// 获取或设置服务名。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string DomainName { get; set; } = string.Empty;
    }
}
