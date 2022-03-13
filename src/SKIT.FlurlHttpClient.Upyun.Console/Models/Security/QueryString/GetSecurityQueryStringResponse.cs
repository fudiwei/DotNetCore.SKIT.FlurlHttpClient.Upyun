namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [GET] /security/qs 接口的响应。</para>
    /// </summary>
    public class GetSecurityQueryStringResponse : UpyunConsoleResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置存储桶名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bucket_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
                public string BucketName { get; set; } = default!;

                /// <summary>
                /// 获取或设置全程跟随状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("args_follow")]
                [System.Text.Json.Serialization.JsonPropertyName("args_follow")]
                public string ArgumentsFollowStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置回源跟随状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("args_restore")]
                [System.Text.Json.Serialization.JsonPropertyName("args_restore")]
                public string ArgumentsRestoreStatus { get; set; } = default!;
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
