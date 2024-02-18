namespace SKIT.FlurlHttpClient.Upyun.Uss.Models
{
    /// <summary>
    /// <para>表示 [POST] /{service}/liveaudit/create 接口的响应。</para>
    /// </summary>
    public class CreatePretreatmentLiveAuditResponse : UpyunUssResponse
    {
        public static class Types
        {
            public class Result
            {
                public static class Types
                {
                    public class Porn
                    {
                        /// <summary>
                        /// 获取或设置分类。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("label")]
                        [System.Text.Json.Serialization.JsonPropertyName("label")]
                        public int Label { get; set; }

                        /// <summary>
                        /// 获取或设置概率（范围：0～1）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("rate")]
                        public decimal Rate { get; set; }

                        /// <summary>
                        /// 获取或设置是否需要人工复审。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("review")]
                        [System.Text.Json.Serialization.JsonPropertyName("review")]
                        public bool RequireReview { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置色情识别信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("porn")]
                [System.Text.Json.Serialization.JsonPropertyName("porn")]
                public Types.Porn? Porn { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置状态码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status_code")]
        [System.Text.Json.Serialization.JsonPropertyName("status_code")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string TaskId { get; set; } = default!;

        /// <summary>
        /// 获取或设置识别结果信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public Types.Result? Result { get; set; }

        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && Status == 200;
        }
    }
}
