namespace SKIT.FlurlHttpClient.Upyun.Sms.UnitTests
{
    internal class ITClients
    {
        public static UpyunSmsClient CreateInstance()
        {
            return new UpyunSmsClient(new UpyunSmsClientOptions()
            {
                Token = ITConfigs.Credentials_Token
            });
        }
    }
}
