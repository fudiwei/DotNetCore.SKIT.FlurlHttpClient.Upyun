using System;

namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [GET] /https/certificate/info 接口的响应。</para>
    /// </summary>
    public class GetHttpsCertificateInfoResponse : UpyunConsoleResponse
    {
        /// <summary>
        /// 获取或设置主域名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("main_domain")]
        [System.Text.Json.Serialization.JsonPropertyName("main_domain")]
        public string? MainDomainName { get; set; }

        /// <summary>
        /// 获取或设置附加域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("other_domains")]
        [System.Text.Json.Serialization.JsonPropertyName("other_domains")]
        public string[]? OtherDomainNameList { get; set; }

        /// <summary>
        /// 获取或设置证书类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_type")]
        [System.Text.Json.Serialization.JsonPropertyName("cert_type")]
        public string CertificateType { get; set; } = default!;

        /// <summary>
        /// 获取或设置域名类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_domain_type")]
        [System.Text.Json.Serialization.JsonPropertyName("cert_domain_type")]
        public string? DomainType { get; set; }

        /// <summary>
        /// 获取或设置证书品牌。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_name")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_name")]
        public string? BrandName { get; set; }

        /// <summary>
        /// 获取或设置有效期结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_date")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("end_date")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
        public DateTimeOffset EndTime { get; set; }

        /// <summary>
        /// 获取或设置是否免费。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("free")]
        [System.Text.Json.Serialization.JsonPropertyName("free")]
        public bool IsFree { get; set; }
    }
}
