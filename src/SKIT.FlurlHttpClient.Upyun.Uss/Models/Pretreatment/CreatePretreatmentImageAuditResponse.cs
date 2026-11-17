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
            internal class ResponseClassNewtonsoftJsonConverter : Uss.Converters.NewtonsoftJson.MaybeStringArrayLikeObjectConverterBase<CreatePretreatmentImageAuditResponse>
            {
                protected override string[]? GetStringArrayPropertyValue(CreatePretreatmentImageAuditResponse model)
                {
                    return model.TaskIdList;
                }

                protected override void SetStringArrayPropertyValue(CreatePretreatmentImageAuditResponse model, string[]? value)
                {
                    model.TaskIdList = value!;
                }
            }

            internal class ResponseClassSystemTextJsonConverter : Uss.Converters.SystemTextJson.MaybeStringArrayLikeObjectConverterBase<CreatePretreatmentImageAuditResponse>
            {
                protected override string[]? GetStringArrayPropertyValue(CreatePretreatmentImageAuditResponse model)
                {
                    return model.TaskIdList;
                }

                protected override void SetStringArrayPropertyValue(CreatePretreatmentImageAuditResponse model, string[]? value)
                {
                    model.TaskIdList = value!;
                }
            }
        }

        [Newtonsoft.Json.JsonProperty(Converters.ResponseClassNewtonsoftJsonConverter.STRARR_PROPERTY_JSON_NAME)]
        [System.Text.Json.Serialization.JsonPropertyName(Converters.ResponseClassSystemTextJsonConverter.STRARR_PROPERTY_JSON_NAME)]
        public string[] TaskIdList { get; set; } = default!;
    }
}
