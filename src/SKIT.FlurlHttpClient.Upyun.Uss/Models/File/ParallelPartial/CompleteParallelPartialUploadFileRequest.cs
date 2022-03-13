namespace SKIT.FlurlHttpClient.Upyun.Uss.Models
{
    /// <summary>
    /// <para>表示 [PUT] /{bucket}/{path_to_file} 接口的请求。</para>
    /// </summary>
    public class CompleteParallelPartialUploadFileRequest : UpyunUssRequest
    {
        /// <summary>
        /// 获取或设置存储桶名。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BucketName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件路径。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string FileKey { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置任务标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string PartialUUID { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件 MD5 值。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? FileMd5 { get; set; }
    }
}
