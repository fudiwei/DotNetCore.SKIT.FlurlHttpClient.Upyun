namespace SKIT.FlurlHttpClient.Upyun.Uss.Models
{
    /// <summary>
    /// <para>表示 [PUT] /{bucket}/{path_to_file} 接口的响应。</para>
    /// </summary>
    public class CompleteParallelPartialUploadFileResponse : UpyunUssResponse
    {
        /// <summary>
        /// 获取或设置任务标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string PartialUUID
        {
            get { return GetRawHeaders().TryGetFirstValue("x-upyun-multi-uuid", out string? s) ? s! : string.Empty; }
        }

        /// <summary>
        /// 获取或设置文件类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string FileType
        {
            get { return GetRawHeaders().TryGetFirstValue("x-upyun-multi-type", out string? s) ? s! : string.Empty; }
        }

        /// <summary>
        /// 获取或设置文件大小（单位：字节）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int FileSize
        {
            get { return GetRawHeaders().TryGetFirstValue("x-upyun-multi-length", out string? s) && int.TryParse(s, out int i) ? i : 0; }
        }
    }
}
