using System;

namespace SKIT.FlurlHttpClient.Upyun.Console.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="UpyunConsoleClientOptions.Username"/> 的副本。
        /// </summary>
        public string Username { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="UpyunConsoleClientOptions.Password"/> 的副本。
        /// </summary>
        public string Password { get; }

        internal Credentials(UpyunConsoleClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            Username = options.Username;
            Password = options.Password;
        }
    }
}
