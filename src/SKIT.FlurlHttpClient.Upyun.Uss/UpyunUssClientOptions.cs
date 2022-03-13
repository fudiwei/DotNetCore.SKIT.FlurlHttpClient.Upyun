namespace SKIT.FlurlHttpClient.Upyun.Uss
{
    /// <summary>
    /// 一个用于构造 <see cref="UpyunUssClient"/> 时使用的配置项。
    /// </summary>
    public class UpyunUssClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置又拍云云存储服务 API 域名。
        /// <para>默认值：<see cref="UpyunUssEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoints { get; set; } = UpyunUssEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置又拍云云存储服务 API 认证方式。
        /// <para>默认值：<see cref="Constants.AuthTypes.Basic"/></para>
        /// </summary>
        public string AuthType { get; set; } = Constants.AuthTypes.Basic;

        /// <summary>
        /// 获取或设置又拍云操作员名称。
        /// </summary>
        public string OperatorName { get; set; } = default!;

        /// <summary>
        /// 获取或设置又拍云操作员密码。
        /// </summary>
        public string OperatorPassword { get; set; } = default!;
    }
}
