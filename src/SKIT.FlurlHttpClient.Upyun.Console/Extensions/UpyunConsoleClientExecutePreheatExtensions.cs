using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Upyun.Console
{
    public static class UpyunConsoleClientExecutePreheatExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /preheat 接口。</para>
        /// <para>REF: https://api.upyun.com/doc#/api/operation/cache/GET%20%2Fpreheat </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPreheatResponse> ExecuteGetPreheatAsync(this UpyunConsoleClient client, Models.GetPreheatRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "preheat")
                .SetQueryParam("task_ids", string.Join(",", request.TaskIdList));

            return await client.SendRequestWithJsonAsync<Models.GetPreheatResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /preheat 接口。</para>
        /// <para>REF: https://api.upyun.com/doc#/api/operation/cache/POST%20%2Fpreheat </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePreheatResponse> ExecuteCreatePreheatAsync(this UpyunConsoleClient client, Models.CreatePreheatRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "preheat");

            return await client.SendRequestWithJsonAsync<Models.CreatePreheatResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
