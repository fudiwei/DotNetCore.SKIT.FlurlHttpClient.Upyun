using System;

namespace SKIT.FlurlHttpClient.Upyun.Sms.Models
{
    /// <summary>
    /// <para>表示 [POST] /detection/mobile 接口的响应。</para>
    /// </summary>
    public class CreateMobileDetectionResponse : UpyunSmsResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置运营商标识号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("carrier")]
                [System.Text.Json.Serialization.JsonPropertyName("carrier")]
                public int Carrier { get; set; }

                /// <summary>
                /// 获取或设置运营商标识描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("carrierStr")]
                [System.Text.Json.Serialization.JsonPropertyName("carrierStr")]
                public string CarrierDescription { get; set; } = default!;

                /// <summary>
                /// 获取或设置手机号码状态标识号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phoneStatus")]
                [System.Text.Json.Serialization.JsonPropertyName("phoneStatus")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置手机号码状态标识描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phoneStatusStr")]
                [System.Text.Json.Serialization.JsonPropertyName("phoneStatusStr")]
                public string StatusDescription { get; set; } = default!;

                /// <summary>
                /// 获取或设置手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone")]
                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                public string MobileNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置号码归属地省份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province")]
                [System.Text.Json.Serialization.JsonPropertyName("province")]
                public string? Province { get; set; }

                /// <summary>
                /// 获取或设置号码归属地城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                public string? City { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置任务编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public long TaskId { get; set; }

        /// <summary>
        /// 获取或设置用户编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("owner_id")]
        [System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// 获取或设置日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date")]
        [System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? DateString { get; set; }

        /// <summary>
        /// 获取或设置手机号码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobiles")]
        [System.Text.Json.Serialization.JsonPropertyName("mobiles")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringArrayReadOnlyConverter))]
        public string[] MobileNumberList { get; set; } = default!;

        /// <summary>
        /// 获取或设置手机号码数目。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sum")]
        [System.Text.Json.Serialization.JsonPropertyName("sum")]
        public int MobileNumberCount { get; set; }

        /// <summary>
        /// 获取或设置创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("created_at")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.UnixTimestampDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.UnixTimestampDateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Result[]? ResultList { get; set; }

        /// <summary>
        /// 获取或设置已完成的任务数目。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public int ResultCount { get; set; }

        /// <summary>
        /// 获取或设置完成时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("done_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.UnixTimestampNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("done_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.UnixTimestampNullableDateTimeOffsetConverter))]
        public DateTimeOffset? DoneTime { get; set; }
    }
}
