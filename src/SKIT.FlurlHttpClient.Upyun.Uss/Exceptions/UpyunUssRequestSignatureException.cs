using System;

namespace SKIT.FlurlHttpClient.Upyun.Uss.Exceptions
{
    public class UpyunUssRequestSignatureException : UpyunUssException
    {
        /// <inheritdoc/>
        internal UpyunUssRequestSignatureException()
        {
        }

        /// <inheritdoc/>
        internal UpyunUssRequestSignatureException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal UpyunUssRequestSignatureException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
