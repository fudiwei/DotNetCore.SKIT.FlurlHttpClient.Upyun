namespace SKIT.FlurlHttpClient.Upyun.Console
{
    /// <summary>
    /// 又拍云服务管理后台开放 API 响应的基类。
    /// </summary>
    public abstract class UpyunConsoleResponse : CommonResponseBase, ICommonResponse
    {
        /// <summary>
        /// 获取又拍云 API 返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_code")]
        [System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public virtual int ErrorCode { get; set; }

        /// <summary>
        /// 获取又拍云 API 返回的错误说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message")]
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public virtual string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取又拍云 API 返回的错误请求接口。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request")]
        [System.Text.Json.Serialization.JsonPropertyName("request")]
        public virtual string? Request { get; set; }

        /// <summary>
        /// 获取又拍云 API 返回的错误类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public virtual string? Type { get; set; }

        /// <summary>
        /// 获取又拍云 API 返回的错误字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("field")]
        [System.Text.Json.Serialization.JsonPropertyName("field")]
        public virtual string? Field { get; set; }

        /// <summary>
        /// 获取一个值，该值指示调用又拍云管理后台开放 API 是否成功。
        /// <para>
        ///（即 HTTP 状态码为 200，且 <see cref="ErrorCode"/> 值为 0）
        /// </para>
        /// </summary>
        /// <returns></returns>
        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && ErrorCode == 0;
        }
    }
}
