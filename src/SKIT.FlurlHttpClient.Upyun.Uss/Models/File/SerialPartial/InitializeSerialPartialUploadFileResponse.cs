using System;
using System.Linq;

namespace SKIT.FlurlHttpClient.Upyun.Uss.Models
{
    /// <summary>
    /// <para>表示 [PUT] /{bucket}/{path_to_file} 接口的响应。</para>
    /// </summary>
    public class InitializeSerialPartialUploadFileResponse : InitializeParallelPartialUploadFileResponse
    {
        /// <summary>
        /// 获取或设置分块序号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int NextChunkId
        {
            get { return int.TryParse(RawHeaders.SingleOrDefault(h => string.Equals(h.Key, "X-Upyun-Next-Part-Id", StringComparison.OrdinalIgnoreCase)).Value, out int i) ? i : 0; }
        }
    }
}
