namespace SKIT.FlurlHttpClient.Upyun.Sim.Models
{
    /// <summary>
    /// <para>表示 [POST] /login/token/verify 接口的响应。</para>
    /// </summary>
    public class LoginTokenVerifyResponse : UpyunSimResponse
    {
        /// <summary>
        /// 获取或设置开发者自定义 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exID")]
        [System.Text.Json.Serialization.JsonPropertyName("exID")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// 获取或设置经过加密的手机号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone")]
        [System.Text.Json.Serialization.JsonPropertyName("phone")]
        public string EncryptedPhoneNumber { get; set; } = default!;

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ErrorCode == 8000;
        }
    }
}
