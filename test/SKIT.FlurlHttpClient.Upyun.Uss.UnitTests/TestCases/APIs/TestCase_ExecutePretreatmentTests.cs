namespace SKIT.FlurlHttpClient.Upyun.Uss.UnitTests.TestCases.APIs
{
    public class TestCase_ExecutePretreatmentTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[POST] /pretreatment/）")]
        public async Task TestExecuteCreatePretreatmentSpiderman()
        {
            Assert.SkipWhen("" == ITConfigs.Fixtures_BucketName, "【已跳过】未配置 \"Fixtures.BucketName\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CreatePretreatmentSpidermanRequest()
            {
                BucketName = ITConfigs.Fixtures_BucketName,
                NotifyUrl = "https://example.com/",
                TaskList = new List<Models.CreatePretreatmentSpidermanRequest.Types.Task>()
                {
                    new Models.CreatePretreatmentSpidermanRequest.Types.Task()
                    {
                        Url = "https://www.baidu.com/img/PCtm_d9c8750bed0b3c7d089fa7d55720d6cf.png",
                        SaveAs = "test_folder/baidu_logo.png",
                        EnableOverwrite = true
                    }
                }
            };
            var response = await client.ExecuteCreatePretreatmentSpidermanAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
        }
    }
}
