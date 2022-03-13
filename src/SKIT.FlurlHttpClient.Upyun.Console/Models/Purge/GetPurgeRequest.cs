using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [GET] /purge 接口的请求。</para>
    /// </summary>
    public class GetPurgeRequest : UpyunConsoleRequest
    {
        /// <summary>
        /// 获取或设置刷新任务 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string> TaskIdList { get; set; } = new List<string>();
    }
}
