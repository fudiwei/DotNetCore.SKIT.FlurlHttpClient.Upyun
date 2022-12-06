using System;
using System.Linq;

namespace SKIT.FlurlHttpClient.Upyun.Uss.Models
{
    /// <summary>
    /// <para>表示 [PUT] /{bucket}/{path_to_file} 接口的响应。</para>
    /// </summary>
    public class TransferSerialPartialUploadFileResponse : TransferParallelPartialUploadFileResponse
    {
        /// <summary>
        /// 获取或设置分块序号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int NextChunkId
        {
            get { return int.TryParse(RawHeaders.TryGetValue("x-upyun-next-part-id", out string value) ? value : string.Empty, out int i) ? i : 0; }
        }
    }
}
