using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Upyun.Sms
{
    public static class UpyunSmsClientExecuteMessagesExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /messages 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/sms-api </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SendMessageResponse> ExecuteSendMessageAsync(this UpyunSmsClient client, Models.SendMessageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "messages");

            return await client.SendRequestWithJsonAsync<Models.SendMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /messages/file 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/sms-api </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SendMessageWithFileResponse> ExecuteSendMessageWithFileAsync(this UpyunSmsClient client, Models.SendMessageWithFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName == null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".csv";

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "messages", "file");

            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            using var fileContent = new ByteArrayContent(request.FileBytes ?? Array.Empty<byte>());
            using var httpContent = new MultipartFormDataContent(boundary);
            httpContent.Add(fileContent, "\"file\"", $"\"{HttpUtility.UrlEncode(request.FileName)}\"");
            httpContent.Add(new StringContent(request.TemplateId.ToString()), "template_id");
            if (request.DateTime != null)
                httpContent.Add(new StringContent(request.DateTime.Value.ToString("yyyy-MM-dd HH:mm:ss")), "time");
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary);
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("text/csv");
            fileContent.Headers.ContentLength = request.FileBytes?.Length;

            return await client.SendRequestAsync<Models.SendMessageWithFileResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /messages/async 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/sms-api </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SendMessageAsynchronouslyResponse> ExecuteSendMessageAsynchronouslyAsync(this UpyunSmsClient client, Models.SendMessageAsynchronouslyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "messages", "async");

            return await client.SendRequestWithJsonAsync<Models.SendMessageAsynchronouslyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /messages/async 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/sms-api </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SendMessageAsynchronouslyV2Response> ExecuteSendMessageAsynchronouslyV2Async(this UpyunSmsClient client, Models.SendMessageAsynchronouslyV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "messages", "async");

            return await client.SendRequestWithJsonAsync<Models.SendMessageAsynchronouslyV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /messages 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/sms-api </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMessagesResponse> ExecuteQueryMessagesAsync(this UpyunSmsClient client, Models.QueryMessagesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "messages");

            if (request.DateString != null)
                flurlReq.SetQueryParam("date", request.DateString);

            if (request.MobileNumber != null)
                flurlReq.SetQueryParam("mobile", request.MobileNumber);

            if (request.Status != null)
                flurlReq.SetQueryParam("status", request.Status);

            if (request.Page != null)
                flurlReq.SetQueryParam("page", request.Page);

            if (request.Limit != null)
                flurlReq.SetQueryParam("per_page", request.Limit);

            return await client.SendRequestWithJsonAsync<Models.QueryMessagesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /messages/intl 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/sms-api </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryInternationalMessagesResponse> ExecuteQueryInternationalMessagesAsync(this UpyunSmsClient client, Models.QueryInternationalMessagesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "messages", "intl");

            if (request.DateString != null)
                flurlReq.SetQueryParam("date", request.DateString);

            if (request.MobileNumber != null)
                flurlReq.SetQueryParam("mobile", request.MobileNumber);

            if (request.Status != null)
                flurlReq.SetQueryParam("status", request.Status);

            if (request.Page != null)
                flurlReq.SetQueryParam("page", request.Page);

            if (request.Limit != null)
                flurlReq.SetQueryParam("per_page", request.Limit);

            return await client.SendRequestWithJsonAsync<Models.QueryInternationalMessagesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
