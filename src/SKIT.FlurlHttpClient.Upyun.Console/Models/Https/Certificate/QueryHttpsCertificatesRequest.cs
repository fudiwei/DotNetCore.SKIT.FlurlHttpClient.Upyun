namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [GET] /https/certificate/list 接口的请求。</para>
    /// </summary>
    public class QueryHttpsCertificatesRequest : UpyunConsoleRequest
    {
        /// <summary>
        /// 获取或设置上次请求接口返回的 `since` 值。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Since { get; set; }

        /// <summary>
        /// 获取或设置上次请求接口返回的 `max` 值。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Max { get; set; }

        /// <summary>
        /// 获取或设置每次最大的请求条数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Limit { get; set; }
    }
}
