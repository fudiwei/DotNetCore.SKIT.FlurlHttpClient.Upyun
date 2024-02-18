using System;

namespace SKIT.FlurlHttpClient.Upyun.Console
{
    /// <summary>
    /// 又拍云服务管理后台开放 API 出错时引发的异常。
    /// </summary>
    public class UpyunConsoleException : CommonException
    {
        /// <inheritdoc/>
        public UpyunConsoleException()
        {
        }

        /// <inheritdoc/>
        public UpyunConsoleException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        public UpyunConsoleException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
