using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Upyun.Uss.UnitTests
{
    public class TestCase_ApiExecutePretreatmentTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /pretreatment/")]
        public async Task TestExecuteCreatePretreatmentSpiderman()
        {
            var request = new Models.CreatePretreatmentSpidermanRequest()
            {
                BucketName = TestConfigs.UpyunBucketName,
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
            var response = await TestClients.Instance.ExecuteCreatePretreatmentSpidermanAsync(request);

            Assert.True(response.IsSuccessful());
        }
    }
}
