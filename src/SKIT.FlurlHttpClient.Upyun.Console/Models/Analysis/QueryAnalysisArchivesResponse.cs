namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [GET] /analysis/archives 接口的响应。</para>
    /// </summary>
    public class QueryAnalysisArchivesResponse : UpyunConsoleResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置文件名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file")]
                [System.Text.Json.Serialization.JsonPropertyName("file")]
                public string FileName { get; set; } = default!;

                /// <summary>
                /// 获取或设置文件大小（单位：字节）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("size")]
                [System.Text.Json.Serialization.JsonPropertyName("size")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int FileSize { get; set; }

                /// <summary>
                /// 获取或设置下载链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string Url { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置存储桶名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bucket_name")]
        [System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        public string BucketName { get; set; } = default!;

        /// <summary>
        /// 获取或设置域名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain")]
        [System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string DomainName { get; set; } = default!;

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data[] Data { get; set; } = default!;
    }
}
