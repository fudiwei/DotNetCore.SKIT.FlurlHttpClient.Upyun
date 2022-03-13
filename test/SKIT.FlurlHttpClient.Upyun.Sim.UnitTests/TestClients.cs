namespace SKIT.FlurlHttpClient.Upyun.Sim.UnitTests
{
    internal class TestClients
    {
        static TestClients()
        {
            Instance = new UpyunSimClient(new UpyunSimClientOptions()
            {
                AppKey = TestConfigs.UpyunAppKey,
                AppSecret = TestConfigs.UpyunAppSecret
            });
        }

        public static readonly UpyunSimClient Instance;
    }
}
