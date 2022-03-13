using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Upyun.Uss.Interceptors
{
    internal class UpyunUssRequestSignatureInterceptor : FlurlHttpCallInterceptor
    {
        private readonly string _scheme;
        private readonly string _username;
        private readonly string _password;

        public UpyunUssRequestSignatureInterceptor(string scheme, string username, string password)
        {
            _scheme = scheme;
            _username = username;
            _password = password;
        }

        public override async Task BeforeCallAsync(FlurlCall flurlCall)
        {
            if (flurlCall == null) throw new ArgumentNullException(nameof(flurlCall));
            if (flurlCall.Completed) throw new Exceptions.UpyunUssRequestSignatureException("This interceptor must be called before request completed.");

            string date;
            if (flurlCall.Request.Headers.Contains(FlurlHttpClient.Constants.HttpHeaders.Date))
            {
                date = string.Join(",", flurlCall.Request.Headers.GetAll(FlurlHttpClient.Constants.HttpHeaders.Date));
            }
            else
            {
                date = DateTimeOffset.Now.ToString("R", CultureInfo.CreateSpecificCulture("en-US"));
                flurlCall.Request.WithHeader(FlurlHttpClient.Constants.HttpHeaders.Date, date);
            }

            if (flurlCall.Request.Headers.Contains(FlurlHttpClient.Constants.HttpHeaders.Authorization))
            {
                // noop!
            }
            else
            {
                switch (_scheme)
                {
                    case Constants.AuthTypes.Basic:
                        {
                            flurlCall.Request.WithBasicAuth(_username, _password);
                        }
                        break;

                    case Constants.AuthTypes.Upyun:
                        {
                            string method = flurlCall.HttpRequestMessage.Method.ToString().ToUpper();
                            string url = flurlCall.HttpRequestMessage.RequestUri?.PathAndQuery ?? string.Empty;
                            string md5 = string.Join(",", flurlCall.Request.Headers.GetAll("Content-MD5")) ?? string.Empty;

                            if (flurlCall.HttpRequestMessage.Content is MultipartFormDataContent formdataContent)
                            {
                                // FORM API 签名方式
                                try
                                {
                                    IDictionary<string, string> paramsMap = new Dictionary<string, string>()
                                    {
                                        {"date", date },
                                        {"content-md5", md5}
                                    };
                                    bool hasFieldDate = false,
                                         hasFieldMd5 = false,
                                         hasFieldPolicy = false;
                                    foreach (HttpContent httpContent in formdataContent)
                                    {
                                        string? key = httpContent.Headers.ContentDisposition?.Name?.Trim('\"');

                                        if (string.IsNullOrEmpty(key))
                                            continue;
                                        if (Constants.FormDataFields.FORMDATA_FILE.Equals(key, StringComparison.OrdinalIgnoreCase))
                                            continue;

                                        if ("date".Equals(key, StringComparison.OrdinalIgnoreCase))
                                            hasFieldDate = true;
                                        if ("content-md5".Equals(key, StringComparison.OrdinalIgnoreCase))
                                            hasFieldMd5 = true;
                                        if ("policy".Equals(key, StringComparison.OrdinalIgnoreCase))
                                            hasFieldPolicy = true;

                                        paramsMap[key!] = await httpContent.ReadAsStringAsync();
                                    }

                                    string policy = Convert.ToBase64String(Encoding.UTF8.GetBytes(JsonSerializer.Serialize(paramsMap, new JsonSerializerOptions() { WriteIndented = false })));
                                    string data = $"{method}&{url}&{date}&{policy}&{md5}".TrimEnd('&');
                                    string secret = Utilities.MD5Utility.Hash(_password).ToLower();
                                    string sign = Convert.ToBase64String(Utilities.HMACUtility.HashWithSHA1(Encoding.UTF8.GetBytes(secret), Encoding.UTF8.GetBytes(data)));

                                    if (!hasFieldDate)
                                        formdataContent.Add(new StringContent(date, Encoding.UTF8), "date");
                                    if (!hasFieldMd5)
                                        formdataContent.Add(new StringContent(md5, Encoding.UTF8), "content-md5");
                                    if (!hasFieldPolicy)
                                        formdataContent.Add(new StringContent(policy, Encoding.UTF8), "policy");

                                    string auth = $"UPYUN {_username}:{sign}";
                                    formdataContent.Add(new StringContent(auth, Encoding.UTF8), "authorization");
                                }
                                catch (Exception ex)
                                {
                                    throw new Exceptions.UpyunUssRequestSignatureException("Generate signature of request failed. Please see the `InnerException` for more details.", ex);
                                }
                            }
                            else
                            {
                                // REST API 签名方式
                                try
                                {
                                    string data = $"{method}&{url}&{date}&{md5}".TrimEnd('&');
                                    string secret = Utilities.MD5Utility.Hash(_password).ToLower();
                                    string sign = Convert.ToBase64String(Utilities.HMACUtility.HashWithSHA1(Encoding.UTF8.GetBytes(secret), Encoding.UTF8.GetBytes(data)));
                                    string auth = $"UPYUN {_username}:{sign}";
                                    flurlCall.Request.WithHeader(FlurlHttpClient.Constants.HttpHeaders.Authorization, auth);
                                }
                                catch (Exception ex)
                                {
                                    throw new Exceptions.UpyunUssRequestSignatureException("Generate signature of request failed. Please see the `InnerException` for more details.", ex);
                                }
                            }
                        }
                        break;

                    default:
                        throw new Exceptions.UpyunUssRequestSignatureException("Unsupported authorization scheme.");
                }
            }
        }
    }
}
