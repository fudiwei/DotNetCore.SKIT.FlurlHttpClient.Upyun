namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/tokens 接口的请求。</para>
    /// </summary>
    public class CreateOAuthTokenRequest : UpyunConsoleRequest
    {
        /// <summary>
        /// 获取或设置又拍云服务管理后台用户名。如果不指定将使用构造 <see cref="UpyunConsoleClient"/> 时的 <see cref="UpyunConsoleClientOptions.Username"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("username")]
        [System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 获取或设置又拍云服务管理后台密码。如果不指定将使用构造 <see cref="UpyunConsoleClient"/> 时的 <see cref="UpyunConsoleClientOptions.Password"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("password")]
        [System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// 获取或设置随机字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置备注名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置权限范围。
        /// <para>默认值：global</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scope")]
        [System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string Scope { get; set; } = "global";

        /// <summary>
        /// 获取或设置过期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expired_at")]
        [System.Text.Json.Serialization.JsonPropertyName("expired_at")]
        public long? ExpireTimestamp { get; set; }
    }
}
