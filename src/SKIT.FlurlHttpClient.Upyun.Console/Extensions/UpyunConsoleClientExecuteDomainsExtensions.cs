using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Upyun.Console
{
    public static class UpyunConsoleClientExecuteDomainsExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /domains/buckets 接口。</para>
        /// <para>REF: https://api.upyun.com/doc#/api/operation/domain/GET%20%2Fdomains%2Fbuckets </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryDomainBucketsResponse> ExecuteQueryDomainBucketsAsync(this UpyunConsoleClient client, Models.QueryDomainBucketsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "domains", "buckets")
                .SetQueryParam("domain", request.DomainName);

            return await client.SendRequestWithJsonAsync<Models.QueryDomainBucketsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
