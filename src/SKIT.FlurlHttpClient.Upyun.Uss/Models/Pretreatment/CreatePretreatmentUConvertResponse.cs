namespace SKIT.FlurlHttpClient.Upyun.Uss.Models
{
    /// <summary>
    /// <para>表示 [POST] /pretreatment/ 接口的响应。</para>
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponseClassNewtonsoftJsonConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponseClassSystemTextJsonConverter))]
    public class CreatePretreatmentUConvertResponse : UpyunUssResponse
    {
        internal static class Converters
        {
            internal class ResponseClassNewtonsoftJsonConverter : Newtonsoft.Json.Converters.Internal.MaybeStringArrayLikeObjectConverterBase<CreatePretreatmentUConvertResponse>
            {
                protected override string[]? GetStringArrayPropertyValue(CreatePretreatmentUConvertResponse model)
                {
                    return model.TaskIdList;
                }

                protected override void SetStringArrayPropertyValue(CreatePretreatmentUConvertResponse model, string[]? value)
                {
                    model.TaskIdList = value!;
                }
            }

            internal class ResponseClassSystemTextJsonConverter : System.Text.Json.Serialization.Internal.MaybeStringArrayLikeObjectConverterBase<CreatePretreatmentUConvertResponse>
            {
                protected override string[]? GetStringArrayPropertyValue(CreatePretreatmentUConvertResponse model)
                {
                    return model.TaskIdList;
                }

                protected override void SetStringArrayPropertyValue(CreatePretreatmentUConvertResponse model, string[]? value)
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
