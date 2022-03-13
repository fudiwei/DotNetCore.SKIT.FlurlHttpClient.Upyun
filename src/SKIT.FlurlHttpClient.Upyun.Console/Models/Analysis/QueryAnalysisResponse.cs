namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [GET] /analysis 接口的响应。</para>
    /// </summary>
    public class QueryAnalysisResponse : UpyunConsoleResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置请求内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = default!;

                /// <summary>
                /// 获取或设置流量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("flow")]
                [System.Text.Json.Serialization.JsonPropertyName("flow")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long Flow { get; set; }

                /// <summary>
                /// 获取或设置请求次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reqs")]
                [System.Text.Json.Serialization.JsonPropertyName("reqs")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long RequestCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data[] Data { get; set; } = default!;
    }
}
