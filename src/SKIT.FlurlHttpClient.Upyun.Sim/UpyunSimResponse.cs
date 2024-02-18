namespace SKIT.FlurlHttpClient.Upyun.Sim
{
    /// <summary>
    /// 又拍云一键登录服务 API 响应的基类。
    /// </summary>
    public abstract class UpyunSimResponse : CommonResponseBase, ICommonResponse
    {
        /// <summary>
        /// 获取又拍云 API 返回的流水号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
        public virtual string? LogId { get; set; }

        /// <summary>
        /// 获取又拍云 API 返回的返回码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public virtual int ErrorCode { get; set; }

        /// <summary>
        /// 获取又拍云 API 返回的返回码说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public virtual string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取一个值，该值指示调用又拍云一键登录服务 API 是否成功。
        /// <para>
        ///（即 HTTP 状态码为 200）
        /// </para>
        /// </summary>
        /// <returns></returns>
        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200;
        }
    }
}
