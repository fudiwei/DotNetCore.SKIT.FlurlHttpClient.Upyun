namespace SKIT.FlurlHttpClient.Upyun.Uss.UnitTests
{
    internal class ITClients
    {
        public static UpyunUssClient CreateInstance()
        {
            return new UpyunUssClient(new UpyunUssClientOptions()
            {
                AuthType = Constants.AuthTypes.Upyun,
                OperatorName = ITConfigs.Credentials_OperatorName,
                OperatorPassword = ITConfigs.Credentials_OperatorPassword
            });
        }
    }
}
