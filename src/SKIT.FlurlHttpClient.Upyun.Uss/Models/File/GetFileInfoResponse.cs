using System;
using System.Linq;

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
            get { return RawHeaders.SingleOrDefault(h => string.Equals(h.Key, "x-upyun-file-type", StringComparison.OrdinalIgnoreCase)).Value ?? default!; }
        }

        /// <summary>
        /// 获取或设置文件大小（单位：字节）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int FileSize
        {
            get { return int.TryParse(RawHeaders.SingleOrDefault(h => string.Equals(h.Key, "x-upyun-file-size", StringComparison.OrdinalIgnoreCase)).Value, out int i) ? i : 0; }
        }

        /// <summary>
        /// 获取或设置文件 MD5 值。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? FileMd5
        {
            get { return RawHeaders.SingleOrDefault(h => string.Equals(h.Key, "Content-MD5", StringComparison.OrdinalIgnoreCase)).Value; }
        }

        /// <summary>
        /// 获取或设置创建时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long CreateTimestamp
        {
            get { return long.TryParse(RawHeaders.SingleOrDefault(h => string.Equals(h.Key, "x-upyun-file-date", StringComparison.OrdinalIgnoreCase)).Value, out long i) ? i : 0; }
        }
    }
}
