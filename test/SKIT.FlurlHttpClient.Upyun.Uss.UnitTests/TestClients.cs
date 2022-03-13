namespace SKIT.FlurlHttpClient.Upyun.Uss.UnitTests
{
    internal class TestClients
    {
        static TestClients()
        {
            Instance = new UpyunUssClient(new UpyunUssClientOptions()
            {
                AuthType = Constants.AuthTypes.Upyun,
                OperatorName = TestConfigs.UpyunOperatorName,
                OperatorPassword = TestConfigs.UpyunOperatorPassword
            });
        }

        public static readonly UpyunUssClient Instance;
    }
}
