using System;

namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [GET] /buckets/domains 接口的响应。</para>
    /// </summary>
    public class QueryBucketDomainsResponse : UpyunConsoleResponse
    {
        public static class Types
        {
            public class Pagination
            {
                /// <summary>
                /// 获取或设置请求数据的页码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page")]
                [System.Text.Json.Serialization.JsonPropertyName("page")]
                public int Page { get; set; }

                /// <summary>
                /// 获取或设置总页数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pages")]
                [System.Text.Json.Serialization.JsonPropertyName("pages")]
                public int PageCount { get; set; }

                /// <summary>
                /// 获取或设置数据总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
            }

            public class Domain
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
                /// 获取或设置域名 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public long DomainId { get; set; }

                /// <summary>
                /// 获取或设置用户 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_id")]
                [System.Text.Json.Serialization.JsonPropertyName("account_id")]
                public long AccountId { get; set; }

                /// <summary>
                /// 获取或设置存储桶 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bucket_id")]
                [System.Text.Json.Serialization.JsonPropertyName("bucket_id")]
                public long BucketId { get; set; }

                /// <summary>
                /// 获取或设置域名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("domain")]
                [System.Text.Json.Serialization.JsonPropertyName("domain")]
                public string DomainName { get; set; } = default!;

                /// <summary>
                /// 获取或设置域名状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置域名类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string? Type { get; set; }

                /// <summary>
                /// 获取或设置更新时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("updated_at")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.UnixTimestampDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("updated_at")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.UnixTimestampDateTimeOffsetConverter))]
                public DateTimeOffset UpdateTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置分页信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pager")]
        [System.Text.Json.Serialization.JsonPropertyName("pager")]
        public Types.Pagination Pagination { get; set; } = default!;

        /// <summary>
        /// 获取或设置域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domains")]
        [System.Text.Json.Serialization.JsonPropertyName("domains")]
        public Types.Domain[] DomainList { get; set; } = default!;
    }
}
