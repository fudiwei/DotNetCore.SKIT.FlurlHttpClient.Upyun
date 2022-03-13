using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Upyun.Uss.Models
{
    /// <summary>
    /// <para>表示 [POST] /pretreatment/ 接口的请求。</para>
    /// </summary>
    public class CreatePretreatmentSpidermanRequest : UpyunUssRequest
    {
        public static class Types
        {
            public class Task
            {
                /// <summary>
                /// 获取或设置文件链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string Url { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置保存路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("save_as")]
                [System.Text.Json.Serialization.JsonPropertyName("save_as")]
                public string SaveAs { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置是否追加随机数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("random")]
                [System.Text.Json.Serialization.JsonPropertyName("random")]
                public bool? EnableRandom { get; set; }

                /// <summary>
                /// 获取或设置是否允许覆盖。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("overwrite")]
                [System.Text.Json.Serialization.JsonPropertyName("overwrite")]
                public bool? EnableOverwrite { get; set; }
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
