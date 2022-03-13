namespace SKIT.FlurlHttpClient.Upyun.Uss.Models
{
    /// <summary>
    /// <para>表示 [GET] /{bucket}/{path_to_folder} 接口的响应。</para>
    /// </summary>
    public class QueryFilesResponse : UpyunUssResponse
    {
        public static class Types
        {
            public class File
            {
                /// <summary>
                /// 获取或设置文件路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string FileKey { get; set; } = default!;

                /// <summary>
                /// 获取或设置文件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string FileType { get; set; } = default!;

                /// <summary>
                /// 获取或设置文件大小（单位：字节）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("length")]
                [System.Text.Json.Serialization.JsonPropertyName("length")]
                public int FileSize { get; set; }

                /// <summary>
                /// 获取或设置最近修改时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("last_modified")]
                [System.Text.Json.Serialization.JsonPropertyName("last_modified")]
                public long LastModifyTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置文件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("files")]
        [System.Text.Json.Serialization.JsonPropertyName("files")]
        public Types.File[] FileList { get; set; } = default!;

        /// <summary>
        /// 获取或设置下一页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("iter")]
        [System.Text.Json.Serialization.JsonPropertyName("iter")]
        public string Offset { get; set; } = default!;
    }
}
