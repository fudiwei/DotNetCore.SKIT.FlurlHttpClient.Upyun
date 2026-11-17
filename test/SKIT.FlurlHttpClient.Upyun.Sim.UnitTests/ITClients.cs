namespace SKIT.FlurlHttpClient.Upyun.Sim.UnitTests
{
    internal class ITClients
    {
        public static UpyunSimClient CreateInstance()
        {
            return new UpyunSimClient(new UpyunSimClientOptions()
            {
                AppKey = ITConfigs.Credentials_AppKey,
                AppSecret = ITConfigs.Credentials_AppSecret
            });
        }
    }
}
