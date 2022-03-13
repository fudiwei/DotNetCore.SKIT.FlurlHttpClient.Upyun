using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [GET] /buckets/operators 接口的响应。</para>
    /// </summary>
    public class QueryBucketOperatorsResponse : UpyunConsoleResponse
    {
        public static class Types
        {
            public class Operator
            {
                /// <summary>
                /// 获取或设置操作员名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("operator_name")]
                [System.Text.Json.Serialization.JsonPropertyName("operator_name")]
                public string OperatorName { get; set; } = default!;

                /// <summary>
                /// 获取或设置操作员姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("realname")]
                [System.Text.Json.Serialization.JsonPropertyName("realname")]
                public string RealName { get; set; } = default!;

                /// <summary>
                /// 获取或设置操作员状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("created_at")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.UnixTimestampDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("created_at")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.UnixTimestampDateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }

                /// <summary>
                /// 获取或设置授权时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bind_at")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.UnixTimestampDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("bind_at")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.UnixTimestampDateTimeOffsetConverter))]
                public DateTimeOffset BindTime { get; set; }

                /// <summary>
                /// 获取或设置权限字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("operator_auth")]
                [System.Text.Json.Serialization.JsonPropertyName("operator_auth")]
                public IDictionary<string, bool> AuthMap { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置操作员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operators")]
        [System.Text.Json.Serialization.JsonPropertyName("operators")]
        public Types.Operator[] OperatorList { get; set; } = default!;
    }
}
