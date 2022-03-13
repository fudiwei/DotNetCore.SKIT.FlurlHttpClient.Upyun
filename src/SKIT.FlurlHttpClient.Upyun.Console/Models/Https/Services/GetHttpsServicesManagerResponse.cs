namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [GET] /https/services/manager 接口的响应。</para>
    /// </summary>
    public class GetHttpsServicesManagerResponse : UpyunConsoleResponse
    {
        public static class Types
        {
            public class Certificate
            {
                public static class Types
                {
                    public class ValidityPeriod : QueryHttpsCertificatesResponse.Types.Result.Types.Certificate.Types.ValidityPeriod
                    {
                    }
                }

                /// <summary>
                /// 获取或设置证书 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificate_id")]
                [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
                public string CertificaiteId { get; set; } = default!;

                /// <summary>
                /// 获取或设置证书颁发对象。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commonName")]
                [System.Text.Json.Serialization.JsonPropertyName("commonName")]
                public string? CommonName { get; set; }

                /// <summary>
                /// 获取或设置证书颁布组织。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("organization")]
                [System.Text.Json.Serialization.JsonPropertyName("organization")]
                public string Organization { get; set; } = default!;

                /// <summary>
                /// 获取或设置证书类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("crt_type")]
                [System.Text.Json.Serialization.JsonPropertyName("crt_type")]
                public string CertificateType { get; set; } = default!;

                /// <summary>
                /// 获取或设置有效期信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("validity")]
                [System.Text.Json.Serialization.JsonPropertyName("validity")]
                public Types.ValidityPeriod ValidityPeriod { get; set; } = default!;

                /// <summary>
                /// 获取或设置域名类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("domain_type")]
                [System.Text.Json.Serialization.JsonPropertyName("domain_type")]
                public string DomainType { get; set; } = default!;

                /// <summary>
                /// 获取或设置付费类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payment_type")]
                [System.Text.Json.Serialization.JsonPropertyName("payment_type")]
                public string? PaymentType { get; set; }

                /// <summary>
                /// 获取或设置证书品牌。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand")]
                [System.Text.Json.Serialization.JsonPropertyName("brand")]
                public string? BrandName { get; set; }

                /// <summary>
                /// 获取或设置证书品牌类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("crt_type_pay")]
                [System.Text.Json.Serialization.JsonPropertyName("crt_type_pay")]
                public string? BrandType { get; set; }

                /// <summary>
                /// 获取或设置是否是专业版。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pro")]
                [System.Text.Json.Serialization.JsonPropertyName("pro")]
                public bool? IsProfessional { get; set; }

                /// <summary>
                /// 获取或设置是否使用了当前的证书来绑定当前的域名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("https")]
                [System.Text.Json.Serialization.JsonPropertyName("https")]
                public bool IsHttps { get; set; }

                /// <summary>
                /// 获取或设置是否强制使用 HTTPS。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("force_https")]
                [System.Text.Json.Serialization.JsonPropertyName("force_https")]
                public bool IsForceHttps { get; set; }

                /// <summary>
                /// 获取或设置是否使用 HTTPS 回源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source_https")]
                [System.Text.Json.Serialization.JsonPropertyName("source_https")]
                public bool IsSourceHttps { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置查询状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置证书列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public Types.Certificate[] CertificateList { get; set; } = default!;

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && Status == 0;
        }
    }
}
