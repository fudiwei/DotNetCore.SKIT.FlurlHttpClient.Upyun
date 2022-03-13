namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [GET] /https/certificate/info 接口的请求。</para>
    /// </summary>
    public class GetHttpsCertificateInfoRequest : UpyunConsoleRequest
    {
        /// <summary>
        /// 获取或设置证书 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CertificateId { get; set; } = string.Empty;
    }
}
