using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Upyun.Console
{
    /// <summary>
    /// 又拍云服务管理后台开放 API 响应的基类。
    /// </summary>
    public abstract class UpyunConsoleResponse : ICommonResponse
    {
        /// <summary>
        ///
        /// </summary>
        int ICommonResponse.RawStatus { get; set; }

        /// <summary>
        ///
        /// </summary>
        IDictionary<string, string> ICommonResponse.RawHeaders { get; set; } = default!;

        /// <summary>
        ///
        /// </summary>
        byte[] ICommonResponse.RawBytes { get; set; } = default!;

        /// <summary>
        /// 获取原始的 HTTP 响应状态码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int RawStatus
        {
            get { return ((ICommonResponse)this).RawStatus; }
            internal set { ((ICommonResponse)this).RawStatus = value; }
        }

        /// <summary>
        /// 获取原始的 HTTP 响应表头集合。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IDictionary<string, string> RawHeaders
        {
            get { return ((ICommonResponse)this).RawHeaders; }
            internal set { ((ICommonResponse)this).RawHeaders = value; }
        }

        /// <summary>
        /// 获取原始的 HTTP 响应正文。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] RawBytes
        {
            get { return ((ICommonResponse)this).RawBytes; }
            internal set { ((ICommonResponse)this).RawBytes = value; }
        }

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
        /// 获取一个值，该值指示调用又拍云一键登录服务 API 是否成功（即 HTTP 状态码为 200、且 error_code 值为 0）。
        /// </summary>
        /// <returns></returns>
        public virtual bool IsSuccessful()
        {
            return RawStatus == 200 && ErrorCode == 0;
        }
    }
}
