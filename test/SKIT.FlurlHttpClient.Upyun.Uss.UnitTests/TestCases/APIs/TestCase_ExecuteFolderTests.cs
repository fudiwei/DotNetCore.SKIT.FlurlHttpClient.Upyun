namespace SKIT.FlurlHttpClient.Upyun.Uss.UnitTests.TestCases.APIs
{
    public class TestCase_ExecuteFolderTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[POST] /{bucket}/{path_to_folder}）")]
        public async Task TestExecuteWriteFile()
        {
            Assert.SkipWhen("" == ITConfigs.Fixtures_BucketName, "【已跳过】未配置 \"Fixtures.BucketName\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.CreateFolderRequest()
            {
                BucketName = ITConfigs.Fixtures_BucketName,
                FolderPath = "test_folder"
            };
            var response = await client.ExecuteCreateFolderAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
        }
    }
}
