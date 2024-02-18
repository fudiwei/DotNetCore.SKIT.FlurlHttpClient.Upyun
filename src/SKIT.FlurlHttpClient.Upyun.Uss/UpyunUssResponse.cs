namespace SKIT.FlurlHttpClient.Upyun.Uss
{
    /// <summary>
    /// 又拍云云存储服务 API 响应的基类。
    /// </summary>
    public abstract class UpyunUssResponse : CommonResponseBase, ICommonResponse
    {
        /// <summary>
        /// 获取又拍云 API 返回的请求流水号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
        public virtual string? LogId { get; set; }

        /// <summary>
        /// 获取又拍云 API 返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public virtual int ErrorCode { get; set; }

        /// <summary>
        /// 获取又拍云 API 返回的错误说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public virtual string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取一个值，该值指示调用又拍云云存储服务 API 是否成功。
        /// <para>
        ///（即 HTTP 状态码为 200/201/204，且 <see cref="ErrorCode"/> 值为 0）
        /// </para>
        /// </summary>
        /// <returns></returns>
        public override bool IsSuccessful()
        {
            return GetRawStatus() >= 200 && GetRawStatus() <= 204 && ErrorCode == 0;
        }
    }
}
