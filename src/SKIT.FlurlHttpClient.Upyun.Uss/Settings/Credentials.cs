using System;

namespace SKIT.FlurlHttpClient.Upyun.Uss.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="UpyunUssClientOptions.OperatorName"/> 的副本。
        /// </summary>
        public string OperatorName { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="UpyunUssClientOptions.OperatorPassword"/> 的副本。
        /// </summary>
        public string OperatorPassword { get; }

        internal Credentials(UpyunUssClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            OperatorName = options.OperatorName;
            OperatorPassword = options.OperatorPassword;
        }
    }
}
