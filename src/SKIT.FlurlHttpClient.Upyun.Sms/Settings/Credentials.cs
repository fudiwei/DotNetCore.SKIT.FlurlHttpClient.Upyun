using System;

namespace SKIT.FlurlHttpClient.Upyun.Sms.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="UpyunSmsClientOptions.Token"/> 的副本。
        /// </summary>
        public string Token { get; }

        internal Credentials(UpyunSmsClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            Token = options.Token;
        }
    }
}
