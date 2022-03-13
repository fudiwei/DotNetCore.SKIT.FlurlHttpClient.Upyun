using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Upyun.Uss.UnitTests
{
    public class TestCase_ApiExecuteFolderTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /{bucket}/{path_to_folder}")]
        public async Task TestExecuteWriteFile()
        {
            var request = new Models.CreateFolderRequest()
            {
                BucketName = TestConfigs.UpyunBucketName,
                FolderPath = "test_folder"
            };
            var response = await TestClients.Instance.ExecuteCreateFolderAsync(request);

            Assert.True(response.IsSuccessful());
        }
    }
}
