using System;

namespace SKIT.FlurlHttpClient.Upyun.Sim
{
    /// <summary>
    /// 又拍云一键登录服务 API 出错时引发的异常。
    /// </summary>
    public class UpyunSimException : CommonException
    {
        /// <inheritdoc/>
        public UpyunSimException()
        {
        }

        /// <inheritdoc/>
        public UpyunSimException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        public UpyunSimException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
