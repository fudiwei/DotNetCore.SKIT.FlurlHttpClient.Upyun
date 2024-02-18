using Xunit;

namespace SKIT.FlurlHttpClient.Upyun.Uss.UnitTests
{
    public class TestCase_JsonConverterOfMaybeStringArrayLikeObjectTest
    {
        private static void TestCustomJsonConverter(IJsonSerializer jsonSerializer)
        {
            Assert.Multiple(() =>
            {
                string expectedJson = "[\"abc\",\"def\",null,\"hij\"]";
                var actualObj = jsonSerializer.Deserialize<Models.CreatePretreatmentSpidermanResponse>(expectedJson);

                Assert.Equal(default(int), actualObj.ErrorCode);
                Assert.Equal(default(string), actualObj.ErrorMessage);
                Assert.Equal(new string[] { "abc", "def", default!, "hij" }, actualObj.TaskIdList);
            });

            Assert.Multiple(() =>
            {
                string expectedJson = "{\"code\":123,\"msg\":\"ERR_MSG\"}";
                var actualObj = jsonSerializer.Deserialize<Models.CreatePretreatmentSpidermanResponse>(expectedJson);

                Assert.Equal(123, actualObj.ErrorCode);
                Assert.Equal("ERR_MSG", actualObj.ErrorMessage);
                Assert.Equal(default(string[]), actualObj.TaskIdList);
            });

            Assert.Multiple(() =>
            {
                var expectedObj = new Models.CreatePretreatmentSpidermanResponse()
                {
                    ErrorCode = 123,
                    ErrorMessage = "ERR_MSG",
                    TaskIdList = new string[] { "abc", "def", default!, "hij" }
                };
                string actualJson = jsonSerializer.Serialize(expectedObj);

                Assert.Null(Record.Exception(() => jsonSerializer.Deserialize<dynamic>(actualJson)));

                Assert.DoesNotContain("#maybe-string-array-like", actualJson);
                Assert.DoesNotContain(nameof(Models.CreatePretreatmentSpidermanResponse.TaskIdList), actualJson);

                Assert.DoesNotContain("\"code\"", actualJson);
                Assert.DoesNotContain("\"msg\"", actualJson);

                Assert.Equal("[\"abc\",\"def\",null,\"hij\"]", actualJson);
            });

            Assert.Multiple(() =>
            {
                var expectedObj = new Models.CreatePretreatmentSpidermanResponse()
                {
                    ErrorCode = 123,
                    ErrorMessage = "ERR_MSG"
                };
                string actualJson = jsonSerializer.Serialize(expectedObj);

                Assert.Null(Record.Exception(() => jsonSerializer.Deserialize<dynamic>(actualJson)));

                Assert.DoesNotContain("#maybe-string-array-like", actualJson);
                Assert.DoesNotContain(nameof(Models.CreatePretreatmentSpidermanResponse.TaskIdList), actualJson);

                Assert.Contains("\"code\":123", actualJson);
                Assert.Contains("\"msg\":\"ERR_MSG\"", actualJson);
            });
        }

        [Fact(DisplayName = "测试用例：自定义 Newtosoft.Json.JsonConverter 之 MaybeStringArrayLikeObjectConverter")]
        public void TestNewtosoftJsonConverter()
        {
            var jsonSettings = NewtonsoftJsonSerializer.GetDefaultSerializerSettings();
            jsonSettings.Formatting = Newtonsoft.Json.Formatting.None;
            jsonSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;

            TestCustomJsonConverter(new NewtonsoftJsonSerializer(jsonSettings));
        }

        [Fact(DisplayName = "测试用例：自定义 System.Text.Json.Serialization.JsonConverter 之 MaybeStringArrayLikeObjectConverter")]
        public void TestSystemTextJsonConverter()
        {
            var jsonOptions = SystemTextJsonSerializer.GetDefaultSerializerOptions();
            jsonOptions.WriteIndented = false;
            jsonOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;

            TestCustomJsonConverter(new SystemTextJsonSerializer(jsonOptions));
        }
    }
}
