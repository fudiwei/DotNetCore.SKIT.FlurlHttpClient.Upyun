namespace SKIT.FlurlHttpClient.Upyun.Sms.UnitTests
{
    internal class TestClients
    {
        static TestClients()
        {
            Instance = new UpyunSmsClient(new UpyunSmsClientOptions()
            {
                Token = TestConfigs.UpyunToken
            });
        }

        public static readonly UpyunSmsClient Instance;
    }
}
