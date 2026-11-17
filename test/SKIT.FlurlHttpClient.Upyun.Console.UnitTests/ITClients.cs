namespace SKIT.FlurlHttpClient.Upyun.Console.UnitTests
{
    internal class ITClients
    {
        public static UpyunConsoleClient CreateInstance()
        {
            return new UpyunConsoleClient(new UpyunConsoleClientOptions()
            {
                Username = ITConfigs.Credentials_Username,
                Password = ITConfigs.Credentials_Password
            });
        }
    }
}
