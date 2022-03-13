using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Upyun.Uss.Models
{
    /// <summary>
    /// <para>表示 [POST] /pretreatment/ 接口的请求。</para>
    /// </summary>
    public class CreatePretreatmentJigsawRequest : UpyunUssRequest
    {
        public static class Types
        {
            public class Task
            {
                /// <summary>
                /// 获取或设置要拼接的图片文件路径列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_matrix")]
                [System.Text.Json.Serialization.JsonPropertyName("image_matrix")]
                public IList<string[]> FileKeyList { get; set; } = new List<string[]>();

                /// <summary>
                /// 获取或设置保存路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("save_as")]
                [System.Text.Json.Serialization.JsonPropertyName("save_as")]
                public string SaveAs { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置图片预处理参数字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("x-gmkerl-thumb")]
                [System.Text.Json.Serialization.JsonPropertyName("x-gmkerl-thumb")]
                public string? ImagePretreatmentOptions { get; set; }
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
