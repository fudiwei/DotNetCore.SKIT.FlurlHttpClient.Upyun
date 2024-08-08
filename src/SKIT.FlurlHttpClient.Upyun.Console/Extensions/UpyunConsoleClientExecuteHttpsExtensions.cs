using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Upyun.Console
{
    public static class UpyunConsoleClientExecuteHttpsExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /https/certificate/info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.upyun.com/doc#/api/operation/https/GET%20%2Fhttps%2Fcertificate%2Finfo ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetHttpsCertificateInfoResponse> ExecuteGetHttpsCertificateInfoAsync(this UpyunConsoleClient client, Models.GetHttpsCertificateInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "https", "certificate", "info")
                .SetQueryParam("crt_id", request.CertificateId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetHttpsCertificateInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /https/certificate/list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.upyun.com/doc#/api/operation/https/GET%20%2Fhttps%2Fcertificate%2Flist ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryHttpsCertificatesResponse> ExecuteQueryHttpsCertificatesAsync(this UpyunConsoleClient client, Models.QueryHttpsCertificatesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "https", "certificate", "list")
                .SetQueryParam("since", request.Since)
                .SetQueryParam("max", request.Max)
                .SetQueryParam("limit", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryHttpsCertificatesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /https/services/manager 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.upyun.com/doc#/api/operation/https/GET%20%2Fhttps%2Fservices%2Fmanager ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetHttpsServicesManagerResponse> ExecuteGetHttpsServicesManagerAsync(this UpyunConsoleClient client, Models.GetHttpsServicesManagerRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "https", "services", "manager")
                .SetQueryParam("domain", request.DomainName);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetHttpsServicesManagerResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
