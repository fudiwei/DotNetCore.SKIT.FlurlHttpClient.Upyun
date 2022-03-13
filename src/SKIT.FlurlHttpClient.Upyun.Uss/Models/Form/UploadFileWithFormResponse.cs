namespace SKIT.FlurlHttpClient.Upyun.Uss.Models
{
    /// <summary>
    /// <para>表示 [POST] /{bucket} 接口的响应。</para>
    /// </summary>
    public class UploadFileWithFormResponse : UpyunUssResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message")]
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置文件 MIME 类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mimetype")]
        [System.Text.Json.Serialization.JsonPropertyName("mimetype")]
        public string? FileContentType { get; set; }

        /// <summary>
        /// 获取或设置文件大小（单位：字节）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_size")]
        [System.Text.Json.Serialization.JsonPropertyName("file_size")]
        public int? FileSize { get; set; }

        /// <summary>
        /// 获取或设置图片类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image-type")]
        [System.Text.Json.Serialization.JsonPropertyName("image-type")]
        public string? ImageType { get; set; }

        /// <summary>
        /// 获取或设置图片帧数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image-frames")]
        [System.Text.Json.Serialization.JsonPropertyName("image-frames")]
        public int? ImageFrames { get; set; }

        /// <summary>
        /// 获取或设置图片宽度（单位：像素）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image-width")]
        [System.Text.Json.Serialization.JsonPropertyName("image-width")]
        public int? ImageWidth { get; set; }

        /// <summary>
        /// 获取或设置图片高度（单位：像素）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image-height")]
        [System.Text.Json.Serialization.JsonPropertyName("image-height")]
        public int? ImageHeight { get; set; }

        public override bool IsSuccessful()
        {
            return RawStatus == 200 && (ErrorCode == 0 || ErrorCode == 200);
        }
    }
}
