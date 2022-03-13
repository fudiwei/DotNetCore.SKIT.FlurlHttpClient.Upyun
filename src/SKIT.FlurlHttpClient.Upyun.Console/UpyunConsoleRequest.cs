namespace SKIT.FlurlHttpClient.Upyun.Console
{
    /// <summary>
    /// 又拍云服务管理后台开放 API 请求的基类。
    /// </summary>
    public abstract class UpyunConsoleRequest : ICommonRequest
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。如果不指定将使用构造 <see cref="UpyunConsoleClient"/> 时的 <see cref="UpyunConsoleClientOptions.Timeout"/> 参数，这在需要指定特定耗时请求（比如上传或下载文件）的超时时间时很有用。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual int? Timeout { get; set; }

        /// <summary>
        /// 获取或设置又拍云服务管理后台 API Token。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AccessToken { get; set; }
    }
}
