namespace SKIT.FlurlHttpClient.Upyun.Uss.Models
{
    /// <summary>
    /// <para>表示 [POST] /{service}/liveaudit/cancel 接口的响应。</para>
    /// </summary>
    public class CancelPretreatmentLiveAuditResponse : UpyunUssResponse
    {
        /// <summary>
        /// 获取或设置状态码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && Status == 200;
        }
    }
}
