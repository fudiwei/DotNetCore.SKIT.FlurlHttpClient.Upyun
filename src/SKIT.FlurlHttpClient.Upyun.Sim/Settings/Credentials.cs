using System;

namespace SKIT.FlurlHttpClient.Upyun.Sim.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="UpyunSimClientOptions.AppKey"/> 的副本。
        /// </summary>
        public string AppKey { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="UpyunSimClientOptions.AppSecret"/> 的副本。
        /// </summary>
        public string AppSecret { get; }

        internal Credentials(UpyunSimClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            AppKey = options.AppKey;
            AppSecret = options.AppSecret;
        }
    }
}
