namespace SKIT.FlurlHttpClient.Upyun.Console
{
    /// <summary>
    /// 又拍云服务管理后台开放 API 请求的基类。
    /// </summary>
    public abstract class UpyunConsoleRequest : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置又拍云服务管理后台 API Token。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AccessToken { get; set; }
    }
}
