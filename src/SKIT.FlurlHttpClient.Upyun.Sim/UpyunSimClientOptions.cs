namespace SKIT.FlurlHttpClient.Upyun.Sim
{
    /// <summary>
    /// 一个用于构造 <see cref="UpyunSimClient"/> 时使用的配置项。
    /// </summary>
    public class UpyunSimClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置又拍云一键登录服务 API 入口点。
        /// <para>默认值：<see cref="UpyunSimEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoint { get; set; } = UpyunSimEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置又拍云 AppKey。
        /// </summary>
        public string AppKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置又拍云 AppSecret。
        /// </summary>
        public string AppSecret { get; set; } = default!;
    }
}
