namespace SKIT.FlurlHttpClient.Upyun.Sms.Models
{
    /// <summary>
    /// <para>表示 [DELETE] /templates/{template_id} 接口的请求。</para>
    /// </summary>
    public class DeleteTemplateRequest : UpyunSmsRequest
    {
        /// <summary>
        /// 获取或设置模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int TemplateId { get; set; }
    }
}
