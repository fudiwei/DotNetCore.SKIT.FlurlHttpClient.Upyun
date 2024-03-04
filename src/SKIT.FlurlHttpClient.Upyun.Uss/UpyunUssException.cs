using System;

namespace SKIT.FlurlHttpClient.Upyun.Uss
{
    /// <summary>
    /// 当调用又拍云云存储服务 API 出错时引发的异常。
    /// </summary>
    public class UpyunUssException : CommonException
    {
        /// <inheritdoc/>
        public UpyunUssException()
        {
        }

        /// <inheritdoc/>
        public UpyunUssException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        public UpyunUssException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
