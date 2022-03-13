namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [GET] /v2/buckets/cdn/source 接口的响应。</para>
    /// </summary>
    public class GetBucketCDNSourceV2Response : UpyunConsoleResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class CDN
                    {
                        public static class Types
                        {
                            public class Server
                            {
                                /// <summary>
                                /// 获取或设置源站地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("host")]
                                [System.Text.Json.Serialization.JsonPropertyName("host")]
                                public string Host { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置源站端口号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("port")]
                                [System.Text.Json.Serialization.JsonPropertyName("port")]
                                public int Port { get; set; }

                                /// <summary>
                                /// 获取或设置配置权重。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("weight")]
                                [System.Text.Json.Serialization.JsonPropertyName("weight")]
                                public int Weight { get; set; }

                                /// <summary>
                                /// 获取或设置失败重试次数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("max_fails")]
                                [System.Text.Json.Serialization.JsonPropertyName("max_fails")]
                                public int MaxAttempts { get; set; }

                                /// <summary>
                                /// 获取或设置链接超时时间（单位：秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fail_timeout")]
                                [System.Text.Json.Serialization.JsonPropertyName("fail_timeout")]
                                public int Timeout { get; set; }

                                /// <summary>
                                /// 获取或设置是否为备用地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("backup")]
                                [System.Text.Json.Serialization.JsonPropertyName("backup")]
                                public bool? IsBackup { get; set; }

                                /// <summary>
                                /// 获取或设置强制指定运营商。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("force_isp")]
                                [System.Text.Json.Serialization.JsonPropertyName("force_isp")]
                                public string? ForceISP { get; set; }
                            }

                            public class ISP
                            {
                                /// <summary>
                                /// 获取或设置源站列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("servers")]
                                [System.Text.Json.Serialization.JsonPropertyName("servers")]
                                public Server[]? ServerList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置源站列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("servers")]
                        [System.Text.Json.Serialization.JsonPropertyName("servers")]
                        public Types.Server[]? ServerList { get; set; }

                        /// <summary>
                        /// 获取或设置电信线路回源配置信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ctn")]
                        [System.Text.Json.Serialization.JsonPropertyName("ctn")]
                        public Types.ISP? CTN { get; set; }

                        /// <summary>
                        /// 获取或设置联通线路回源配置信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cun")]
                        [System.Text.Json.Serialization.JsonPropertyName("cun")]
                        public Types.ISP? CUN { get; set; }

                        /// <summary>
                        /// 获取或设置移动线路回源配置信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cmn")]
                        [System.Text.Json.Serialization.JsonPropertyName("cmn")]
                        public Types.ISP? CMN { get; set; }

                        /// <summary>
                        /// 获取或设置多线线路回源配置信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bgp")]
                        [System.Text.Json.Serialization.JsonPropertyName("bgp")]
                        public Types.ISP? BGP { get; set; }

                        /// <summary>
                        /// 获取或设置其他线路回源配置信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("other")]
                        [System.Text.Json.Serialization.JsonPropertyName("other")]
                        public Types.ISP? Other { get; set; }

                        /// <summary>
                        /// 获取或设置海外线路回源配置信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("abroad")]
                        [System.Text.Json.Serialization.JsonPropertyName("abroad")]
                        public Types.ISP? Abroad { get; set; }

                        /// <summary>
                        /// 获取或设置是否支持 Range 请求。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("accept_ranges")]
                        [System.Text.Json.Serialization.JsonPropertyName("accept_ranges")]
                        public bool? IsAcceptRanges { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置存储桶名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bucket_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
                public string BucketName { get; set; } = default!;

                /// <summary>
                /// 获取或设置域名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("domain")]
                [System.Text.Json.Serialization.JsonPropertyName("domain")]
                public string DomainName { get; set; } = default!;

                /// <summary>
                /// 获取或设置域名跟随状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("domain_follow")]
                [System.Text.Json.Serialization.JsonPropertyName("domain_follow")]
                public string DomainFollowStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置源站类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source_type")]
                [System.Text.Json.Serialization.JsonPropertyName("source_type")]
                public string SourceType { get; set; } = default!;

                /// <summary>
                /// 获取或设置重定向跟随状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("redirect_follow")]
                [System.Text.Json.Serialization.JsonPropertyName("redirect_follow")]
                public string RedirectFollowStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置重定向跟随最大次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("redirect_follow_num")]
                [System.Text.Json.Serialization.JsonPropertyName("redirect_follow_num")]
                public int RedirectFollowMax { get; set; }

                /// <summary>
                /// 获取或设置校验证书合法性状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ssl_verify")]
                [System.Text.Json.Serialization.JsonPropertyName("ssl_verify")]
                public string? SSLVerifyStatus { get; set; }

                /// <summary>
                /// 获取或设置源站分片状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("disable_slice")]
                [System.Text.Json.Serialization.JsonPropertyName("disable_slice")]
                public string? SliceStatus { get; set; }

                /// <summary>
                /// 获取或设置是否支持 Range 请求。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("accept_ranges")]
                [System.Text.Json.Serialization.JsonPropertyName("accept_ranges")]
                public bool? IsAcceptRanges { get; set; }

                /// <summary>
                /// 获取或设置备源域名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("backup_domain")]
                [System.Text.Json.Serialization.JsonPropertyName("backup_domain")]
                public string? BackupDomainName { get; set; }

                /// <summary>
                /// 获取或设置 CDN 信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cdn")]
                [System.Text.Json.Serialization.JsonPropertyName("cdn")]
                public Types.CDN CDN { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置操作结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public bool Result { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
