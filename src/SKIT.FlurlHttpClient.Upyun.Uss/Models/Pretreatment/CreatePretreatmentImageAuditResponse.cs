namespace SKIT.FlurlHttpClient.Upyun.Uss.Models
{
    /// <summary>
    /// <para>表示 [POST] /pretreatment/ 接口的响应。</para>
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponseClassNewtonsoftJsonConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponseClassSystemTextJsonConverter))]
    public class CreatePretreatmentImageAuditResponse : UpyunUssResponse
    {
        internal static class Converters
        {
            internal class ResponseClassNewtonsoftJsonConverter : Uss.Converters.NewtonsoftJson.MaybeStringListLikeObjectConverterBase<CreatePretreatmentImageAuditResponse>
            {
                protected override List<string>? GetStringListLikePropertyValue(CreatePretreatmentImageAuditResponse model)
                {
                    return model.TaskIdList;
                }

                protected override void SetStringListLikePropertyValue(CreatePretreatmentImageAuditResponse model, List<string>? value)
                {
                    model.TaskIdList = value!;
                }
            }

            internal class ResponseClassSystemTextJsonConverter : Uss.Converters.SystemTextJson.MaybeStringListLikeObjectConverterBase<CreatePretreatmentImageAuditResponse>
            {
                protected override List<string>? GetStringListLikePropertyValue(CreatePretreatmentImageAuditResponse model)
                {
                    return model.TaskIdList;
                }

                protected override void SetStringListLikePropertyValue(CreatePretreatmentImageAuditResponse model, List<string>? value)
                {
                    model.TaskIdList = value!;
                }
            }
        }

        [Newtonsoft.Json.JsonProperty(Converters.ResponseClassNewtonsoftJsonConverter.STRINGLISTLIKE_PROPERTY_JSON_NAME)]
        [System.Text.Json.Serialization.JsonPropertyName(Converters.ResponseClassSystemTextJsonConverter.STRINGLISTLIKE_PROPERTY_JSON_NAME)]
        public List<string>? TaskIdList { get; set; }
    }
}
