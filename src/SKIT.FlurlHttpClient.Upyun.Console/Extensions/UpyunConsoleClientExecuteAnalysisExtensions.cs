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
        /// <para>REF: https://api.upyun.com/doc#/api/operation/log/GET%20%2Fanalysis </para>
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
                .CreateRequest(request, HttpMethod.Get, "analysis");

            if (request.BucketName != null)
                flurlReq.SetQueryParam("bucket_name", request.BucketName);

            if (request.DomainName != null)
                flurlReq.SetQueryParam("domain", request.DomainName);

            if (request.DateString != null)
                flurlReq.SetQueryParam("date", request.DateString);

            if (request.Type != null)
                flurlReq.SetQueryParam("type", request.Type);

            if (request.OrderBy != null)
                flurlReq.SetQueryParam("order_by", request.OrderBy);

            return await client.SendRequestWithJsonAsync<Models.QueryAnalysisResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /analysis/archives 接口。</para>
        /// <para>REF: https://api.upyun.com/doc#/api/operation/log/GET%20%2Fanalysis%2Farchives </para>
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
                .CreateRequest(request, HttpMethod.Get, "analysis", "archives");

            if (request.BucketName != null)
                flurlReq.SetQueryParam("bucket_name", request.BucketName);

            if (request.DomainName != null)
                flurlReq.SetQueryParam("domain", request.DomainName);

            if (request.DateString != null)
                flurlReq.SetQueryParam("date", request.DateString);

            if (request.StartDateString != null)
                flurlReq.SetQueryParam("start_date", request.StartDateString);

            if (request.EndDateString != null)
                flurlReq.SetQueryParam("start_date", request.EndDateString);

            if (request.UseHttps != null)
                flurlReq.SetQueryParam("useSsl", request.UseHttps.Value);

            if (request.IsPCDN != null)
                flurlReq.SetQueryParam("pcdn", request.IsPCDN.Value);

            if (request.IsAbroad != null)
                flurlReq.SetQueryParam("abroad", request.IsAbroad.Value);

            return await client.SendRequestWithJsonAsync<Models.QueryAnalysisArchivesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
