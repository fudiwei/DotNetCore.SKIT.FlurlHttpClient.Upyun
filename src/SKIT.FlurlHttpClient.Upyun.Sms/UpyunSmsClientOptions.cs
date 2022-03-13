namespace SKIT.FlurlHttpClient.Upyun.Sms
{
    /// <summary>
    /// 一个用于构造 <see cref="UpyunSmsClient"/> 时使用的配置项。
    /// </summary>
    public class UpyunSmsClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置又拍云短信服务 API 域名。
        /// <para>默认值：<see cref="UpyunSmsEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoints { get; set; } = UpyunSmsEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置又拍云短信服务 API Token。
        /// </summary>
        public string Token { get; set; } = default!;
    }
}
