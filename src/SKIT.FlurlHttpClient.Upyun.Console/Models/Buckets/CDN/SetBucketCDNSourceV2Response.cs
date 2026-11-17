namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/buckets/cdn/source 接口的响应。</para>
    /// </summary>
    public class SetBucketCDNSourceV2Response : UpyunConsoleResponse
    {
        public static class Types
        {
            public class Data : GetBucketCDNSourceV2Response.Types.__zz__Data
            {
                public static class Types
                {
                    public class CDN : SetBucketCDNSourceV2Request.Types.__zz__CDN
                    {
                        public static class Types
                        {
                            public class Server : SetBucketCDNSourceV2Request.Types.CDN.Types.Server
                            {
                            }

                            public class ISP
                            {
                                /// <summary>
                                /// 获取或设置源站列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("servers")]
                                [System.Text.Json.Serialization.JsonPropertyName("servers")]
                                public List<Server>? ServerList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置源站列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("servers")]
                        [System.Text.Json.Serialization.JsonPropertyName("servers")]
                        public List<Types.Server>? ServerList { get; set; }

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
                    }
                }

                /// <summary>
                /// 获取或设置 CDN 信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cdn")]
                [System.Text.Json.Serialization.JsonPropertyName("cdn")]
                public Types.CDN? CDN { get; set; }
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
        public Types.Data? Data { get; set; }
    }
}
