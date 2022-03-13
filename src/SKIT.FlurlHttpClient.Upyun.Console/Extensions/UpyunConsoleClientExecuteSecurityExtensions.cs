using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Upyun.Console
{
    public static class UpyunConsoleClientExecuteSecurityExtensions
    {
        #region BackSource
        /// <summary>
        /// <para>异步调用 [POST] /security/back_source/auth 接口。</para>
        /// <para>REF: https://api.upyun.com/doc#/api/operation/security/POST%20%2Fsecurity%2Fback_source%2Fauth </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetSecurityBackSourceAuthResponse> ExecuteSetSecurityBackSourceAuthAsync(this UpyunConsoleClient client, Models.SetSecurityBackSourceAuthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "security", "back_source", "auth");

            return await client.SendRequestWithJsonAsync<Models.SetSecurityBackSourceAuthResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /security/back_source/auth 接口。</para>
        /// <para>REF: https://api.upyun.com/doc#/api/operation/security/POST%20%2Fsecurity%2Fback_source%2Fauth </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetSecurityBackSourceAuthResponse> ExecuteGetSecurityBackSourceAuthAsync(this UpyunConsoleClient client, Models.GetSecurityBackSourceAuthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "security", "back_source", "auth")
                .SetQueryParam("bucket_name", request.BucketName);

            return await client.SendRequestWithJsonAsync<Models.GetSecurityBackSourceAuthResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region QueryString
        /// <summary>
        /// <para>异步调用 [POST] /security/qs 接口。</para>
        /// <para>REF: https://api.upyun.com/doc#/api/operation/cdn/POST%20%2Fsecurity%2Fqs </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetSecurityQueryStringResponse> ExecuteSetSecurityQueryStringAsync(this UpyunConsoleClient client, Models.SetSecurityQueryStringRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "security", "qs");

            return await client.SendRequestWithJsonAsync<Models.SetSecurityQueryStringResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /security/qs 接口。</para>
        /// <para>REF: https://api.upyun.com/doc#/api/operation/cdn/GET%20%2Fsecurity%2Fqs </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetSecurityQueryStringResponse> ExecuteGetSecurityQueryStringAsync(this UpyunConsoleClient client, Models.GetSecurityQueryStringRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "security", "qs")
                .SetQueryParam("bucket_name", request.BucketName);

            return await client.SendRequestWithJsonAsync<Models.GetSecurityQueryStringResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
