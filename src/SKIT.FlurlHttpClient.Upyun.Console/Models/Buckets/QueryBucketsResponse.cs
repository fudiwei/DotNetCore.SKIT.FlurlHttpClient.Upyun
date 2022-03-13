using System;

namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [GET] /buckets 接口的响应。</para>
    /// </summary>
    public class QueryBucketsResponse : UpyunConsoleResponse
    {
        public static class Types
        {
            public class Pagination
            {
                /// <summary>
                /// 获取或设置分页 `since` 值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("since")]
                [System.Text.Json.Serialization.JsonPropertyName("since")]
                public int? Since { get; set; }

                /// <summary>
                /// 获取或设置分页 `max` 值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max")]
                [System.Text.Json.Serialization.JsonPropertyName("max")]
                public int? Max { get; set; }

                /// <summary>
                /// 获取或设置每次最大的请求条数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("limit")]
                [System.Text.Json.Serialization.JsonPropertyName("limit")]
                public int Limit { get; set; }
            }

            public class Bucket
            {
                public static class Types
                {
                    public class Domain
                    {
                        /// <summary>
                        /// 获取或设置域名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("domain")]
                        [System.Text.Json.Serialization.JsonPropertyName("domain")]
                        public string DomainName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置域名类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string? Type { get; set; }

                        /// <summary>
                        /// 获取或设置域名状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string Status { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置存储桶 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bucket_id")]
                [System.Text.Json.Serialization.JsonPropertyName("bucket_id")]
                public long BucketId { get; set; }

                /// <summary>
                /// 获取或设置业务类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_type")]
                [System.Text.Json.Serialization.JsonPropertyName("business_type")]
                public string? BusinessType { get; set; }

                /// <summary>
                /// 获取或设置存储桶名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bucket_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
                public string BucketName { get; set; } = default!;

                /// <summary>
                /// 获取或设置存储桶类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置存储桶状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否开启外链。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("visible")]
                [System.Text.Json.Serialization.JsonPropertyName("visible")]
                public bool IsVisible { get; set; }

                /// <summary>
                /// 获取或设置是否开启 Form API。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("form_api_status")]
                [System.Text.Json.Serialization.JsonPropertyName("form_api_status")]
                public bool IsFormApiEnabled { get; set; }

                /// <summary>
                /// 获取或设置是否开启 HTTPS。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("https")]
                [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponsePropertyBucketIsHttpsEnabledNewtonsoftJsonConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("https")]
                [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponsePropertyBucketIsHttpsEnabledSystemTextJsonConverter))]
                public bool IsHttpsEnabled { get; set; }

                /// <summary>
                /// 获取或设置是否配置过融合云存储。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_storage_configured")]
                [System.Text.Json.Serialization.JsonPropertyName("third_storage_configured")]
                public bool IsThirdStorageConfigured { get; set; }

                /// <summary>
                /// 获取或设置存储桶备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bucket_remark")]
                [System.Text.Json.Serialization.JsonPropertyName("bucket_remark")]
                public string? BucketRemark { get; set; }

                /// <summary>
                /// 获取或设置空间存储配额。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quota")]
                [System.Text.Json.Serialization.JsonPropertyName("quota")]
                public long Quota { get; set; }

                /// <summary>
                /// 获取或设置创建时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("created_at")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("created_at")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }

                /// <summary>
                /// 获取或设置默认域名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("default_domain")]
                [System.Text.Json.Serialization.JsonPropertyName("default_domain")]
                public string? DefaultDomainName { get; set; }

                /// <summary>
                /// 获取或设置绑定域名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("domains")]
                [System.Text.Json.Serialization.JsonPropertyName("domains")]
                public Types.Domain[]? DomainList { get; set; }

                /// <summary>
                /// 获取或设置直播服务的推流域名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("up_domains")]
                [System.Text.Json.Serialization.JsonPropertyName("up_domains")]
                public Types.Domain[]? UpstreamDomainList { get; set; }

                /// <summary>
                /// 获取或设置直播服务的拉流域名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("down_domains")]
                [System.Text.Json.Serialization.JsonPropertyName("down_domains")]
                public Types.Domain[]? DownstreamDomainList { get; set; }

                /// <summary>
                /// 获取或设置推拉流协议。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transport")]
                [System.Text.Json.Serialization.JsonPropertyName("transport")]
                public string? Transport { get; set; }

                /// <summary>
                /// 获取或设置直播回源配置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stream")]
                [System.Text.Json.Serialization.JsonPropertyName("stream")]
                public string? Stream { get; set; }

                /// <summary>
                /// 获取或设置是否是融合 CDN。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fusion_cdn")]
                [System.Text.Json.Serialization.JsonPropertyName("fusion_cdn")]
                public bool? IsFusionCDN { get; set; }

                /// <summary>
                /// 获取或设置是否是安全加速 CDN。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("security_cdn")]
                [System.Text.Json.Serialization.JsonPropertyName("security_cdn")]
                public bool? IsSecurityCDN { get; set; }

                /// <summary>
                /// 获取或设置是否是 Websocket 服务。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("websocket")]
                [System.Text.Json.Serialization.JsonPropertyName("websocket")]
                public bool? IsWebsocket { get; set; }

                /// <summary>
                /// 获取或设置是否为低频文件存储。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("infrequent_access")]
                [System.Text.Json.Serialization.JsonPropertyName("infrequent_access")]
                public bool? IsInfrequentAccess { get; set; }

                /// <summary>
                /// 获取或设置是否是海外加速服务。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("abroad")]
                [System.Text.Json.Serialization.JsonPropertyName("abroad")]
                public bool? IsAbroad { get; set; }

                /// <summary>
                /// 获取或设置海外加速服务状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("abroad_status")]
                [System.Text.Json.Serialization.JsonPropertyName("abroad_status")]
                public string? AbroadStatus { get; set; }
            }
        }

        internal static class Converters
        {
            internal class ResponsePropertyBucketIsHttpsEnabledNewtonsoftJsonConverter : Newtonsoft.Json.JsonConverter<bool>
            {
                public override bool CanRead
                {
                    get { return true; }
                }

                public override bool CanWrite
                {
                    get { return true; }
                }

                public override bool ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
                {
                    if (reader.TokenType == Newtonsoft.Json.JsonToken.Null)
                    {
                        return existingValue;
                    }
                    else if (reader.TokenType == Newtonsoft.Json.JsonToken.String)
                    {
                        string? value = serializer.Deserialize<string>(reader);
                        if (string.IsNullOrEmpty(value))
                            return existingValue;

                        if ("enabled".Equals(value))
                            return true;
                        else if ("disabled".Equals(value))
                            return false;
                    }

                    throw new Newtonsoft.Json.JsonException();
                }

                public override void WriteJson(Newtonsoft.Json.JsonWriter writer, bool value, Newtonsoft.Json.JsonSerializer serializer)
                {
                    writer.WriteValue(value ? "enabled" : "disabled");
                }
            }

            internal class ResponsePropertyBucketIsHttpsEnabledSystemTextJsonConverter : System.Text.Json.Serialization.JsonConverter<bool>
            {
                public override bool Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
                {
                    if (reader.TokenType == System.Text.Json.JsonTokenType.Null)
                    {
                        return default;
                    }
                    else if (reader.TokenType == System.Text.Json.JsonTokenType.String)
                    {
                        string? value = reader.GetString();
                        if (string.IsNullOrEmpty(value))
                            return default;

                        if ("enabled".Equals(value))
                            return true;
                        else if ("disabled".Equals(value))
                            return false;
                    }

                    throw new System.Text.Json.JsonException();
                }

                public override void Write(System.Text.Json.Utf8JsonWriter writer, bool value, System.Text.Json.JsonSerializerOptions options)
                {
                    writer.WriteStringValue(value ? "enabled" : "disabled");
                }
            }
        }

        /// <summary>
        /// 获取或设置分页信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pager")]
        [System.Text.Json.Serialization.JsonPropertyName("pager")]
        public Types.Pagination Pagination { get; set; } = default!;

        /// <summary>
        /// 获取或设置存储桶列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buckets")]
        [System.Text.Json.Serialization.JsonPropertyName("buckets")]
        public Types.Bucket[] BucketList { get; set; } = default!;
    }
}
