using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Upyun.Console
{
    public static class UpyunConsoleClientExecuteOAuthExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /oauth/tokens 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.upyun.com/doc#/api/operation/oauth/POST%20%2Foauth%2Ftokens ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateOAuthTokenResponse> ExecuteCreateOAuthTokenAsync(this UpyunConsoleClient client, Models.CreateOAuthTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Username is null)
                request.Username = client.Credentials.Username;

            if (request.Password is null)
                request.Password = client.Credentials.Password;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "oauth", "tokens");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateOAuthTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [DELETE] /oauth/tokens 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.upyun.com/doc#/api/operation/oauth/DELETE%20%2Foauth%2Ftokens ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DeleteOAuthTokenResponse> ExecuteDeleteOAuthTokenAsync(this UpyunConsoleClient client, Models.DeleteOAuthTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Delete, "oauth", "tokens")
                .SetQueryParam("name", request.Name);

            return await client.SendFlurlRequestAsJsonAsync<Models.DeleteOAuthTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
