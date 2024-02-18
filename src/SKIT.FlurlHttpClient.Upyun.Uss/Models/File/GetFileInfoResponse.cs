namespace SKIT.FlurlHttpClient.Upyun.Uss.Models
{
    /// <summary>
    /// <para>表示 [HEAD] /{bucket}/{path_to_file} 接口的响应。</para>
    /// </summary>
    public class GetFileInfoResponse : UpyunUssResponse
    {
        /// <summary>
        /// 获取或设置文件类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string FileType
        {
            get { return GetRawHeaders().TryGetFirstValue("x-upyun-file-type", out string? s) ? s! : string.Empty; }
        }

        /// <summary>
        /// 获取或设置文件大小（单位：字节）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int FileSize
        {
            get { return GetRawHeaders().TryGetFirstValue("x-upyun-file-size", out string? s) && int.TryParse(s, out int n) ? n : 0; }
        }

        /// <summary>
        /// 获取或设置文件 MD5 值。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? FileMd5
        {
            get { return GetRawHeaders().TryGetFirstValue("Content-MD5", out string? s) ? s! : string.Empty; }
        }

        /// <summary>
        /// 获取或设置创建时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long CreateTimestamp
        {
            get { return GetRawHeaders().TryGetFirstValue("x-upyun-file-date", out string? s) && long.TryParse(s, out long n) ? n : 0; }
        }
    }
}
