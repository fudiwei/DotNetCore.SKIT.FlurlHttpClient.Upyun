namespace SKIT.FlurlHttpClient.Upyun.Sms
{
    /// <summary>
    /// 又拍云短信服务 API 响应的基类。
    /// </summary>
    public abstract class UpyunSmsResponse : CommonResponseBase, ICommonResponse
    {
        /// <summary>
        /// 获取一个值，该值指示调用又拍云短信服务 API 是否成功
        /// <para>
        /// （即 HTTP 状态码为 200/201/202/204）。
        /// </para>
        /// </summary>
        /// <returns></returns>
        public override bool IsSuccessful()
        {
            return GetRawStatus() >= 200 && GetRawStatus() <= 204;
        }
    }
}
