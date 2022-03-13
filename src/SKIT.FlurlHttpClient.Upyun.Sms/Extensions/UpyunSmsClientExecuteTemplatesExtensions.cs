using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Upyun.Sms
{
    public static class UpyunSmsClientExecuteTemplatesExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /templates 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/sms-api </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateTemplateResponse> ExecuteCreateTemplateAsync(this UpyunSmsClient client, Models.CreateTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "templates");

            return await client.SendRequestWithJsonAsync<Models.CreateTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [DELETE] /templates/{template_id} 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/sms-api </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DeleteTemplateResponse> ExecuteDeleteTemplateAsync(this UpyunSmsClient client, Models.DeleteTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Delete, "templates", request.TemplateId);

            return await client.SendRequestWithJsonAsync<Models.DeleteTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /templates/{template_id} 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/sms-api </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateTemplateResponse> ExecuteUpdateTemplateAsync(this UpyunSmsClient client, Models.UpdateTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, new HttpMethod("PATCH"), "templates", request.TemplateId);

            return await client.SendRequestWithJsonAsync<Models.UpdateTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /templates 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/sms-api </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryTemplatesResponse> ExecuteQueryTemplatesAsync(this UpyunSmsClient client, Models.QueryTemplatesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "templates");

            if (request.Type != null)
                flurlReq.SetQueryParam("type", request.Type);

            if (request.ReportType != null)
                flurlReq.SetQueryParam("report_type", request.ReportType);

            return await client.SendRequestWithJsonAsync<Models.QueryTemplatesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
