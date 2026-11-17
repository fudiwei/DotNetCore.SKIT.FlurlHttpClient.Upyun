namespace SKIT.FlurlHttpClient.Upyun.Uss.UnitTests.TestCases.APIs
{
    public class TestCase_ExecuteBucketTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[GET] /{bucket}/?usage）")]
        public async Task TestExecuteGetBucketUsage()
        {
            Assert.SkipWhen("" == ITConfigs.Fixtures_BucketName, "【已跳过】未配置 \"Fixtures.BucketName\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.GetBucketUsageRequest()
            {
                BucketName = ITConfigs.Fixtures_BucketName
            };
            var response = await client.ExecuteGetBucketUsageAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
        }
    }
}
