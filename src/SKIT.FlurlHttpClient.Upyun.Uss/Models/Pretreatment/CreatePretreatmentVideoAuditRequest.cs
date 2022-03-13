using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Upyun.Uss.Models
{
    /// <summary>
    /// <para>表示 [POST] /pretreatment/ 接口的请求。</para>
    /// </summary>
    public class CreatePretreatmentVideoAuditRequest : UpyunUssRequest
    {
        public static class Types
        {
            public class Task
            {
                /// <summary>
                /// 获取或设置文件路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source")]
                [System.Text.Json.Serialization.JsonPropertyName("source")]
                public string FileKey { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置截图间隔时间（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("interval")]
                [System.Text.Json.Serialization.JsonPropertyName("interval")]
                public int? Interval { get; set; }

                /// <summary>
                /// 获取或设置截图保存路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("save_as")]
                [System.Text.Json.Serialization.JsonPropertyName("save_as")]
                public string? SaveAs { get; set; }

                /// <summary>
                /// 获取或设置截图保存尺寸字符串（格式：宽x高）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("resize")]
                [System.Text.Json.Serialization.JsonPropertyName("resize")]
                public string? ResizeString { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置存储桶名。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BucketName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置任务列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<Types.Task> TaskList { get; set; } = new List<Types.Task>();

        /// <summary>
        /// 获取或设置异步通知 URL。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string NotifyUrl { get; set; } = string.Empty;
    }
}
