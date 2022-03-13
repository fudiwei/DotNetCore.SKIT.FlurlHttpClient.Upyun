using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Upyun.Uss.Models
{
    /// <summary>
    /// <para>表示 [POST] /{bucket} 接口的请求。</para>
    /// </summary>
    public class UploadFileWithFormRequest : UpyunUssRequest
    {
        public static class Types
        {
            public class Range
            {
                /// <summary>
                /// 获取或设置最小值。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                public int Mininum { get; set; }

                /// <summary>
                /// 获取或设置最大值。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                public int Maxinum { get; set; }
            }

            public class AsyncPretreatmentParameter
            {
                /// <summary>
                /// 获取或设置任务名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置结果保存路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string? Type { get; set; }

                /// <summary>
                /// 获取或设置结果保存路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("save_as")]
                [System.Text.Json.Serialization.JsonPropertyName("save_as")]
                public string? SaveAs { get; set; }

                /// <summary>
                /// 获取或设置回调地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("notify_url")]
                [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
                public string? NotifyUrl { get; set; }

                /// <summary>
                /// 获取或设置图片预处理放缩参数字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("x-gmkerl-thumb")]
                [System.Text.Json.Serialization.JsonPropertyName("x-gmkerl-thumb")]
                public string? ImagePretreatmentThumbnailOptions { get; set; }

                /// <summary>
                /// 获取或设置图片预处理分块参数字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("x-gmkerl-split")]
                [System.Text.Json.Serialization.JsonPropertyName("x-gmkerl-split")]
                public string? ImagePretreatmentSplitOptions { get; set; }

                /// <summary>
                /// 获取或设置图片像素密度（范围：2～200）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("density")]
                [System.Text.Json.Serialization.JsonPropertyName("density")]
                public int? ImageDensity { get; set; }

                /// <summary>
                /// 获取或设置图片宽度（单位：像素）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("width")]
                [System.Text.Json.Serialization.JsonPropertyName("width")]
                public int? ImageWidth { get; set; }

                /// <summary>
                /// 获取或设置音视频处理参数字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("avopts")]
                [System.Text.Json.Serialization.JsonPropertyName("avopts")]
                public string? AudioOrVideoPretreatmentOptions { get; set; }

                /// <summary>
                /// 获取或设置是否返回元数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("return_info")]
                [System.Text.Json.Serialization.JsonPropertyName("return_info")]
                public bool? RequireReturnInfo { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置存储桶名。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BucketName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件路径。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string FileKey { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] FileBytes { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// 获取或设置文件 MIME 类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? FileContentType { get; set; }

        /// <summary>
        /// 获取或设置文件 MD5 值。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? FileMd5 { get; set; }

        /// <summary>
        /// 获取或设置文件密钥。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? FileSecret { get; set; }

        /// <summary>
        /// 获取或设置请求过期时间戳。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long? ExpireTimestamp { get; set; }

        /// <summary>
        /// 获取或设置允许的文件类型列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string>? AllowedFileTypeList { get; set; }

        /// <summary>
        /// 获取或设置允许的文件大小范围。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public Types.Range? AllowedFileSizeRange { get; set; }

        /// <summary>
        /// 获取或设置允许的图片宽度范围。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public Types.Range? AllowedImageWidthRange { get; set; }

        /// <summary>
        /// 获取或设置允许的图片高度范围。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public Types.Range? AllowedHeightWidthRange { get; set; }

        /// <summary>
        /// 获取或设置文件元信息。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IDictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// 获取或设置图片预处理参数字符串。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ImagePretreatmentOptions { get; set; }

        /// <summary>
        /// 获取或设置异步预处理参数信息。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<Types.AsyncPretreatmentParameter>? AsyncPretreatmentParameters { get; set; }

        /// <summary>
        /// 获取或设置同步通知 URL。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ReturnUrl { get; set; }

        /// <summary>
        /// 获取或设置异步通知 URL。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置通知额外参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ExtraParameter { get; set; }

        /// <summary>
        /// 获取或设置回调请求 URL。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? CallbackUrl { get; set; }
    }
}
