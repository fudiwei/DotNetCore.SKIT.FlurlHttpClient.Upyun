using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Upyun.Sim
{
    public static class UpyunSimClientExecuteLoginExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /login/token/verify 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://help.upyun.com/knowledge-base/sim-api/#rest-api ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.LoginTokenVerifyResponse> ExecuteLoginTokenVerifyAsync(this UpyunSimClient client, Models.LoginTokenVerifyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "login", "token", "verify");

            return await client.SendFlurlRequestAsJsonAsync<Models.LoginTokenVerifyResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
