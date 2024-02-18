using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Upyun.Uss.Interceptors
{
    using SKIT.FlurlHttpClient.Upyun.Uss.Constants;

    internal class UpyunUssRequestSigningInterceptor : HttpInterceptor
    {
        private readonly string _authType;
        private readonly string _username;
        private readonly string _password;

        public UpyunUssRequestSigningInterceptor(string authType, string username, string password)
        {
            _authType = authType;
            _username = username;
            _password = password;
        }

        public override async Task BeforeCallAsync(HttpInterceptorContext context, CancellationToken cancellationToken = default)
        {
            if (context is null) throw new ArgumentNullException(nameof(context));
            if (context.FlurlCall.Completed) throw new UpyunUssException("Failed to sign request. This interceptor must be called before request completed.");

            string date;
            if (context.FlurlCall.Request.Headers.Contains(HttpHeaders.Date))
            {
                date = string.Join(",", context.FlurlCall.Request.Headers.GetAll(HttpHeaders.Date));
            }
            else
            {
                date = DateTimeOffset.Now.ToString("R", CultureInfo.CreateSpecificCulture("en-US"));
                context.FlurlCall.Request.WithHeader(HttpHeaders.Date, date);
            }

            if (context.FlurlCall.Request.Headers.Contains(HttpHeaders.Authorization))
            {
                // noop!
            }
            else
            {
                switch (_authType)
                {
                    case AuthTypes.Basic:
                        {
                            context.FlurlCall.Request.WithBasicAuth(_username, _password);
                        }
                        break;

                    case AuthTypes.Upyun:
                        {
                            string method = context.FlurlCall.HttpRequestMessage.Method.ToString().ToUpper();
                            string url = context.FlurlCall.HttpRequestMessage.RequestUri?.PathAndQuery ?? string.Empty;
                            string md5 = string.Join(",", context.FlurlCall.Request.Headers.GetAll("Content-MD5")) ?? string.Empty;

                            if (context.FlurlCall.HttpRequestMessage.Content is MultipartFormDataContent multipartFormData)
                            {
                                // FORM API 签名方式
                                try
                                {
                                    IDictionary<string, string> paramsMap = new Dictionary<string, string>()
                                    {
                                        {"date", date },
                                        {"content-md5", md5 }
                                    };

                                    bool hasFieldDate = false,
                                         hasFieldMd5 = false,
                                         hasFieldPolicy = false;

                                    foreach (HttpContent httpContent in multipartFormData)
                                    {
                                        string? key = httpContent.Headers.ContentDisposition?.Name?.Trim('\"');

                                        if (string.IsNullOrEmpty(key))
                                            continue;
                                        if (FormDataFields.FORMDATA_FILE.Equals(key, StringComparison.OrdinalIgnoreCase))
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
                                    string signData = $"{method}&{url}&{date}&{policy}&{md5}".TrimEnd('&');
                                    string secret = Utilities.MD5Utility.Hash(_password).Value!.ToLower();
                                    string sign = Convert.ToBase64String(Utilities.HMACUtility.HashWithSHA1(Encoding.UTF8.GetBytes(secret), Encoding.UTF8.GetBytes(signData)));

                                    if (!hasFieldDate)
                                        multipartFormData.Add(new StringContent(date, Encoding.UTF8), "date");
                                    if (!hasFieldMd5)
                                        multipartFormData.Add(new StringContent(md5, Encoding.UTF8), "content-md5");
                                    if (!hasFieldPolicy)
                                        multipartFormData.Add(new StringContent(policy, Encoding.UTF8), "policy");

                                    multipartFormData.Add(new StringContent($"UPYUN {_username}:{sign}", Encoding.UTF8), "authorization");
                                }
                                catch (Exception ex)
                                {
                                    throw new UpyunUssException("Failed to sign request. Please see the `InnerException` for more details.", ex);
                                }
                            }
                            else
                            {
                                // REST API 签名方式
                                try
                                {
                                    string signData = $"{method}&{url}&{date}&{md5}".TrimEnd('&');
                                    string secret = Utilities.MD5Utility.Hash(_password).Value!.ToLower();
                                    string sign = Convert.ToBase64String(Utilities.HMACUtility.HashWithSHA1(Encoding.UTF8.GetBytes(secret), Encoding.UTF8.GetBytes(signData)));
                                    context.FlurlCall.Request.WithHeader(HttpHeaders.Authorization, $"UPYUN {_username}:{sign}");
                                }
                                catch (Exception ex)
                                {
                                    throw new UpyunUssException("Failed to sign request. Please see the `InnerException` for more details.", ex);
                                }
                            }
                        }
                        break;

                    default:
                        throw new UpyunUssException($"Failed to sign request. Unsupported authorization scheme: \"{_authType}\".");
                }
            }
        }
    }
}
