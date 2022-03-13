namespace SKIT.FlurlHttpClient.Upyun.Console.UnitTests
{
    internal class TestClients
    {
        static TestClients()
        {
            Instance = new UpyunConsoleClient(new UpyunConsoleClientOptions()
            {
                Username = TestConfigs.UpyunUsername,
                Password = TestConfigs.UpyunPassword
            });
        }

        public static readonly UpyunConsoleClient Instance;
    }
}
