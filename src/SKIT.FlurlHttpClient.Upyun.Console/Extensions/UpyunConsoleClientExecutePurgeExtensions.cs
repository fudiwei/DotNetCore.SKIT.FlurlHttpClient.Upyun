using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Upyun.Console
{
    public static class UpyunConsoleClientExecutePurgeExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /purge 接口。</para>
        /// <para>REF: https://api.upyun.com/doc#/api/operation/cache/GET%20%2Fpurge </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPurgeResponse> ExecuteGetPurgeAsync(this UpyunConsoleClient client, Models.GetPurgeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "purge")
                .SetQueryParam("task_ids", string.Join(",", request.TaskIdList));

            return await client.SendRequestWithJsonAsync<Models.GetPurgeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /purge 接口。</para>
        /// <para>REF: https://api.upyun.com/doc#/api/operation/cache/POST%20%2Fpurge </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePurgeResponse> ExecuteCreatePurgeAsync(this UpyunConsoleClient client, Models.CreatePurgeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "purge");

            return await client.SendRequestWithJsonAsync<Models.CreatePurgeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
