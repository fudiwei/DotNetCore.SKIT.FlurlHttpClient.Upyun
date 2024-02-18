using System;

namespace SKIT.FlurlHttpClient.Upyun.Sms
{
    /// <summary>
    /// 又拍云短信服务 API 出错时引发的异常。
    /// </summary>
    public class UpyunSmsException : CommonException
    {
        /// <inheritdoc/>
        public UpyunSmsException()
        {
        }

        /// <inheritdoc/>
        public UpyunSmsException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        public UpyunSmsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
