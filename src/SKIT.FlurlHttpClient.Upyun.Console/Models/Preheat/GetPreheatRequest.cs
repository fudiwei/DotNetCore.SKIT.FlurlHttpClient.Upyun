using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [GET] /preheat 接口的请求。</para>
    /// </summary>
    public class GetPreheatRequest : UpyunConsoleRequest
    {
        /// <summary>
        /// 获取或设置预热任务 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string> TaskIdList { get; set; } = new List<string>();
    }
}
