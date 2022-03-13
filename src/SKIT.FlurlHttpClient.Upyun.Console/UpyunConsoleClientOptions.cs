namespace SKIT.FlurlHttpClient.Upyun.Console
{
    /// <summary>
    /// 一个用于构造 <see cref="UpyunConsoleClient"/> 时使用的配置项。
    /// </summary>
    public class UpyunConsoleClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置又拍云服务管理后台开放 API 域名。
        /// <para>默认值：<see cref="UpyunConsoleEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoints { get; set; } = UpyunConsoleEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置又拍云服务管理后台用户名。
        /// </summary>
        public string Username { get; set; } = default!;

        /// <summary>
        /// 获取或设置又拍云服务管理后台密码。
        /// </summary>
        public string Password { get; set; } = default!;
    }
}
