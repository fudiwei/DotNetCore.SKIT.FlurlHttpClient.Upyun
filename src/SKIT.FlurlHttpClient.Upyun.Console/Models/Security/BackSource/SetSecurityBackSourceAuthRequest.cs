using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Upyun.Console.Models
{
    /// <summary>
    /// <para>表示 [POST] /security/back_source/auth 接口的请求。</para>
    /// </summary>
    public class SetSecurityBackSourceAuthRequest : UpyunConsoleRequest
    {
        public static class Types
        {
            public class Options
            {
                /// <summary>
                /// 获取或设置鉴权地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_url")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_url")]
                public string AuthUrl { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置资源地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source_url")]
                [System.Text.Json.Serialization.JsonPropertyName("source_url")]
                public string SourceUrl { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置鉴权请求方法。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_method")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_method")]
                public string AuthMethod { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置鉴权请求参数列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_params")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_params")]
                public IList<string> AuthParameterList { get; set; } = new List<string>();

                /// <summary>
                /// 获取或设置鉴权请求标头列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("headers")]
                [System.Text.Json.Serialization.JsonPropertyName("headers")]
                public IList<string>? AuthHeaderList { get; set; }

                /// <summary>
                /// 获取或设置忽略的请求标头列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ignore_headers")]
                [System.Text.Json.Serialization.JsonPropertyName("ignore_headers")]
                public IList<string>? IgnoreHeaderList { get; set; }

                /// <summary>
                /// 获取或设置判断鉴权成功的方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_success_type")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_success_type")]
                public string AuthSuccessType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置鉴权成功的返回值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_success_value")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_success_value")]
                public string AuthSuccessValue { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置鉴权请求的超时时间（单位：毫秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("timeout")]
                [System.Text.Json.Serialization.JsonPropertyName("timeout")]
                public int Timeout { get; set; }

                /// <summary>
                /// 获取或设置服务器响应失败时的鉴权状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("when_failed")]
                [System.Text.Json.Serialization.JsonPropertyName("when_failed")]
                public bool IsAuthSuccessfulWhenResponseFailed { get; set; }

                /// <summary>
                /// 获取或设置指定回源鉴权请求的 Host 值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("host")]
                [System.Text.Json.Serialization.JsonPropertyName("host")]
                public string? Host { get; set; }

                /// <summary>
                /// 获取或设置用来存放需要客户配置指定的配置项。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external")]
                [System.Text.Json.Serialization.JsonPropertyName("external")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.DynamicObjectConverter))]
                public dynamic? ExternalConfig { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置存储桶名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bucket_name")]
        [System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        public string BucketName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否开启回源鉴权。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable")]
        [System.Text.Json.Serialization.JsonPropertyName("enable")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// 获取或设置回源鉴权参数列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("options")]
        [System.Text.Json.Serialization.JsonPropertyName("options")]
        public IList<Types.Options> OptionsList { get; set; } = new List<Types.Options>();
    }
}
