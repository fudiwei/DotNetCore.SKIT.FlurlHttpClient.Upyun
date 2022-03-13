namespace SKIT.FlurlHttpClient.Upyun.Sim.Models
{
    /// <summary>
    /// <para>表示 [POST] /login/token/verify 接口的请求。</para>
    /// </summary>
    public class LoginTokenVerifyRequest : UpyunSimRequest
    {
        /// <summary>
        /// 获取或设置认证 SDK 获取到的 LoginToken。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("loginToken")]
        [System.Text.Json.Serialization.JsonPropertyName("loginToken")]
        public string LoginToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开发者自定义 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exID")]
        [System.Text.Json.Serialization.JsonPropertyName("exID")]
        public string? ExternalId { get; set; }
    }
}
