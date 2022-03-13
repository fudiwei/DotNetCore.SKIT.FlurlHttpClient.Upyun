namespace SKIT.FlurlHttpClient.Upyun.Sim
{
    /// <summary>
    /// 又拍云一键登录服务 API 请求的基类。
    /// </summary>
    public abstract class UpyunSimRequest : ICommonRequest
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。如果不指定将使用构造 <see cref="UpyunSimClient"/> 时的 <see cref="UpyunSimClientOptions.Timeout"/> 参数，这在需要指定特定耗时请求（比如上传或下载文件）的超时时间时很有用。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual int? Timeout { get; set; }
    }
}
