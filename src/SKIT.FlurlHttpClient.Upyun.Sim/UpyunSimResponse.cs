﻿using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Upyun.Sim
{
    /// <summary>
    /// 又拍云一键登录服务 API 响应的基类。
    /// </summary>
    public abstract class UpyunSimResponse : ICommonResponse
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
        /// 获取又拍云 API 返回的流水号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public virtual string? LogId { get; set; }

        /// <summary>
        /// 获取又拍云 API 返回的返回码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public virtual int ErrorCode { get; set; }

        /// <summary>
        /// 获取又拍云 API 返回的返回码说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public virtual string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取一个值，该值指示调用又拍云一键登录服务 API 是否成功（即 HTTP 状态码为 200）。
        /// </summary>
        /// <returns></returns>
        public virtual bool IsSuccessful()
        {
            return RawStatus == 200;
        }
    }
}
