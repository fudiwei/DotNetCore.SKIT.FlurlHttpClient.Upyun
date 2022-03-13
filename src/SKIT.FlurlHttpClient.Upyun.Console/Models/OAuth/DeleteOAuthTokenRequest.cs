namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [DELETE] /oauth/tokens 接口的请求。</para>
    /// </summary>
    public class DeleteOAuthTokenRequest : UpyunConsoleRequest
    {
        /// <summary>
        /// 获取或设置备注名。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Name { get; set; } = string.Empty;
    }
}
