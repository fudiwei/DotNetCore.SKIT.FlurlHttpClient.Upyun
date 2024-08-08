using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Upyun.Console
{
    public static class UpyunConsoleClientExecuteAnalysisExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /analysis 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.upyun.com/doc#/api/operation/log/GET%20%2Fanalysis ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryAnalysisResponse> ExecuteQueryAnalysisAsync(this UpyunConsoleClient client, Models.QueryAnalysisRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "analysis")
                .SetQueryParam("bucket_name", request.BucketName)
                .SetQueryParam("domain", request.DomainName)
                .SetQueryParam("date", request.DateString)
                .SetQueryParam("type", request.Type)
                .SetQueryParam("order_by", request.OrderBy);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryAnalysisResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /analysis/archives 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.upyun.com/doc#/api/operation/log/GET%20%2Fanalysis%2Farchives ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryAnalysisArchivesResponse> ExecuteQueryAnalysisArchivesAsync(this UpyunConsoleClient client, Models.QueryAnalysisArchivesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "analysis", "archives")
                .SetQueryParam("bucket_name", request.BucketName)
                .SetQueryParam("domain", request.DomainName)
                .SetQueryParam("date", request.DateString)
                .SetQueryParam("start_date", request.StartDateString)
                .SetQueryParam("start_date", request.EndDateString)
                .SetQueryParam("useSsl", request.UseHttps)
                .SetQueryParam("pcdn", request.IsPCDN)
                .SetQueryParam("abroad", request.IsAbroad);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryAnalysisArchivesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
