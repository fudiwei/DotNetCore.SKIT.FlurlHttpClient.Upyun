namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [POST] /security/back_source/auth 接口的响应。</para>
    /// </summary>
    public class SetSecurityBackSourceAuthResponse : UpyunConsoleResponse
    {
        public static class Types
        {
            public class Data : GetSecurityBackSourceAuthResponse.Types.Data
            {
                public static new class Types
                {
                    public class Failure
                    {
                        /// <summary>
                        /// 获取或设置配置参数索引。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("index")]
                        [System.Text.Json.Serialization.JsonPropertyName("index")]
                        public int OptionsIndex { get; set; }

                        /// <summary>
                        /// 获取或设置错误信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("err_message")]
                        [System.Text.Json.Serialization.JsonPropertyName("err_message")]
                        public string ErrorMessage { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置错误信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_message")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_message")]
                public Types.Failure[]? FailureList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置操作结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public bool Result { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
