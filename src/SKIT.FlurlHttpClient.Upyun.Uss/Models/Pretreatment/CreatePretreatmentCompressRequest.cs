using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Upyun.Uss.Models
{
    /// <summary>
    /// <para>表示 [POST] /pretreatment/ 接口的请求。</para>
    /// </summary>
    public class CreatePretreatmentCompressRequest : UpyunUssRequest
    {
        public static class Types
        {
            public class Task
            {
                /// <summary>
                /// 获取或设置要压缩的文件路径列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sources")]
                [System.Text.Json.Serialization.JsonPropertyName("sources")]
                public IList<string>? FileKeyList { get; set; }

                /// <summary>
                /// 获取或设置要压缩的文件源路径列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sources_list")]
                [System.Text.Json.Serialization.JsonPropertyName("sources_list")]
                public IList<string>? SourceFileList { get; set; }

                /// <summary>
                /// 获取或设置保存路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("save_as")]
                [System.Text.Json.Serialization.JsonPropertyName("save_as")]
                public string SaveAs { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置不包含的父目录。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("home_dir")]
                [System.Text.Json.Serialization.JsonPropertyName("home_dir")]
                public string? HomeDirectory { get; set; }

                /// <summary>
                /// 获取或设置新增的父目录。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parent_dir")]
                [System.Text.Json.Serialization.JsonPropertyName("parent_dir")]
                public string? ParentDirectory { get; set; }
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
