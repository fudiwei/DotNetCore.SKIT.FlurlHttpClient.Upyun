namespace SKIT.FlurlHttpClient.Upyun.Uss
{
    /// <summary>
    /// 又拍云云存储服务 API 接口域名。
    /// </summary>
    public static class UpyunUssEndpoints
    {
        /// <summary>
        /// 默认域名。
        /// </summary>
        public const string DEFAULT = "https://v0.api.upyun.com";

        /// <summary>
        /// 电信域名。
        /// </summary>
        public const string REGION_ISP_TELECOM = "https://v1.api.upyun.com";

        /// <summary>
        /// 联通/网通域名。
        /// </summary>
        public const string REGION_ISP_CNC = "https://v2.api.upyun.com";

        /// <summary>
        /// 移动/铁通域名。
        /// </summary>
        public const string REGION_ISP_CTT = "https://v3.api.upyun.com";
    }
}
