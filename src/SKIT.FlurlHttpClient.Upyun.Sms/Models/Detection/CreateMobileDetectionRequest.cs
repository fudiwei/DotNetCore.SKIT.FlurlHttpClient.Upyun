using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Upyun.Sms.Models
{
    /// <summary>
    /// <para>表示 [POST] /detection/mobile 接口的请求。</para>
    /// </summary>
    public class CreateMobileDetectionRequest : UpyunSmsRequest
    {
        /// <summary>
        /// 获取或设置手机号码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("mobile")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedStringListWithCommaSplitConverter))]
        public IList<string> MobileNumberList { get; set; } = new List<string>();
    }
}
