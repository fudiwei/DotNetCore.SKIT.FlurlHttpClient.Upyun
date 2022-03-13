using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Upyun.Uss.UnitTests
{
    public class TestCase_ApiExecuteBucketTests
    {
        [Fact(DisplayName = "测试用例：调用 API [GET] /{bucket}/?usage")]
        public async Task TestExecuteGetBucketUsage()
        {
            var request = new Models.GetBucketUsageRequest()
            {
                BucketName = TestConfigs.UpyunBucketName
            };
            var response = await TestClients.Instance.ExecuteGetBucketUsageAsync(request);

            Assert.True(response.IsSuccessful());
        }
    }
}
