namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [POST] /security/back_source/auth 接口的响应。</para>
    /// </summary>
    public class SetSecurityBackSourceAuthResponse : UpyunConsoleResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Options : SetSecurityBackSourceAuthRequest.Types.Options
                    {
                    }

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
                        public string? ErrorMessage { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置存储桶名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bucket_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
                public string? BucketName { get; set; }

                /// <summary>
                /// 获取或设置是否开启回源鉴权。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable")]
                [System.Text.Json.Serialization.JsonPropertyName("enable")]
                public bool? IsEnabled { get; set; }

                /// <summary>
                /// 获取或设置回源鉴权参数列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("options")]
                [System.Text.Json.Serialization.JsonPropertyName("options")]
                public List<Types.Options>? OptionsList { get; set; }

                /// <summary>
                /// 获取或设置错误信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_message")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_message")]
                public List<Types.Failure>? FailureList { get; set; }
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
        public Types.Data? Data { get; set; }
    }
}
