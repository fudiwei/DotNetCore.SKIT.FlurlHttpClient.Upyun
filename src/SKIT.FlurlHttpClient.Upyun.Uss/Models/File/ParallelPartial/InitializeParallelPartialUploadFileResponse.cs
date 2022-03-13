using System;
using System.Linq;

namespace SKIT.FlurlHttpClient.Upyun.Uss.Models
{
    /// <summary>
    /// <para>表示 [PUT] /{bucket}/{path_to_file} 接口的响应。</para>
    /// </summary>
    public class InitializeParallelPartialUploadFileResponse : UpyunUssResponse
    {
        /// <summary>
        /// 获取或设置任务标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string PartialUUID
        {
            get { return RawHeaders.SingleOrDefault(h => string.Equals(h.Key, "X-Upyun-Multi-Uuid", StringComparison.OrdinalIgnoreCase)).Value ?? default!; }
        }
    }
}
