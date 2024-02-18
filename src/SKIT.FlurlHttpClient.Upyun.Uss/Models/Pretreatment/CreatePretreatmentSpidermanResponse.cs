namespace SKIT.FlurlHttpClient.Upyun.Uss.Models
{
    /// <summary>
    /// <para>表示 [POST] /pretreatment/ 接口的响应。</para>
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponseClassNewtonsoftJsonConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponseClassSystemTextJsonConverter))]
    public class CreatePretreatmentSpidermanResponse : UpyunUssResponse
    {
        internal static class Converters
        {
            internal class ResponseClassNewtonsoftJsonConverter : Newtonsoft.Json.Converters.Internal.ArrayLikeObjectReadOnlyConverterBase<CreatePretreatmentSpidermanResponse>
            {
            }

            internal class ResponseClassSystemTextJsonConverter : System.Text.Json.Serialization.Internal.ArrayLikeObjectReadOnlyConverterBase<CreatePretreatmentSpidermanResponse>
            {
            }
        }

        [Newtonsoft.Json.JsonProperty(Newtonsoft.Json.Converters.Internal.ArrayLikeObjectReadOnlyConverterBase.PROPERTY_NAME_LARRAY)]
        [System.Text.Json.Serialization.JsonPropertyName(System.Text.Json.Serialization.Internal.ArrayLikeObjectReadOnlyConverterBase.PROPERTY_NAME_LARRAY)]
        public string[] TaskIdList { get; set; } = default!;
    }
}
