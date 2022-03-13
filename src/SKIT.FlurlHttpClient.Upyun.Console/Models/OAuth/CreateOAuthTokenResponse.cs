namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/tokens 接口的响应。</para>
    /// </summary>
    public class CreateOAuthTokenResponse : UpyunConsoleResponse
    {
        /// <summary>
        /// 获取或设置接口访问令牌。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public string AccessToken { get; set; } = default!;

        /// <summary>
        /// 获取或设置备注名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 获取或设置权限范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scope")]
        [System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string Scope { get; set; } = default!;

        /// <summary>
        /// 获取或设置服务列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("services")]
        [System.Text.Json.Serialization.JsonPropertyName("services")]
        public string[] ServiceList { get; set; } = default!;

        /// <summary>
        /// 获取或设置创建时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("created_at")]
        [System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public long CreateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置过期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expired_at")]
        [System.Text.Json.Serialization.JsonPropertyName("expired_at")]
        public long? ExpireTimestamp { get; set; }
    }
}
