using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Upyun.Uss
{
    public static class UpyunUssClientExecutePretreatmentExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /pretreatment/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://help.upyun.com/knowledge-base/spider/#e68f90e4baa4e5a484e79086e4bbbbe58aa1 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePretreatmentSpidermanResponse> ExecuteCreatePretreatmentSpidermanAsync(this UpyunUssClient client, Models.CreatePretreatmentSpidermanRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pretreatment", "")
                .WithUrl("https://p0.api.upyun.com/pretreatment/");

            var formdata = new Dictionary<string, string>()
            {
                { "service", request.BucketName },
                { "notify_url", request.NotifyUrl },
                { "app_name", "spiderman" },
                { "tasks", Convert.ToBase64String(Encoding.UTF8.GetBytes(client.JsonSerializer.Serialize(request.TaskList))) }
            };
            return await client.SendFlurlRequestAsFormUrlEncodedAsync<Models.CreatePretreatmentSpidermanResponse>(flurlReq, data: formdata, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pretreatment/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://help.upyun.com/knowledge-base/spider/#e68f90e4baa4e5a484e79086e4bbbbe58aa1 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePretreatmentThumbnailResponse> ExecuteCreatePretreatmentThumbnailAsync(this UpyunUssClient client, Models.CreatePretreatmentThumbnailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pretreatment", "")
                .WithUrl("https://p0.api.upyun.com/pretreatment/");

            var formdata = new Dictionary<string, string>()
            {
                { "service", request.BucketName },
                { "notify_url", request.NotifyUrl },
                { "app_name", "thumb" },
                { "accept", "json" },
                { "tasks", Convert.ToBase64String(Encoding.UTF8.GetBytes(client.JsonSerializer.Serialize(request.TaskList))) }
            };
            return await client.SendFlurlRequestAsFormUrlEncodedAsync<Models.CreatePretreatmentThumbnailResponse>(flurlReq, data: formdata, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pretreatment/ 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePretreatmentJigsawResponse> ExecuteCreatePretreatmentJigsawAsync(this UpyunUssClient client, Models.CreatePretreatmentJigsawRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pretreatment", "")
                .WithUrl("https://p0.api.upyun.com/pretreatment/");

            var formdata = new Dictionary<string, string>()
            {
                { "service", request.BucketName },
                { "notify_url", request.NotifyUrl },
                { "app_name", "jigsaw" },
                { "tasks", Convert.ToBase64String(Encoding.UTF8.GetBytes(client.JsonSerializer.Serialize(request.TaskList))) }
            };
            return await client.SendFlurlRequestAsFormUrlEncodedAsync<Models.CreatePretreatmentJigsawResponse>(flurlReq, data: formdata, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pretreatment/ 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePretreatmentCompressResponse> ExecuteCreatePretreatmentCompressAsync(this UpyunUssClient client, Models.CreatePretreatmentCompressRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pretreatment", "")
                .WithUrl("https://p0.api.upyun.com/pretreatment/");

            var formdata = new Dictionary<string, string>()
            {
                { "service", request.BucketName },
                { "notify_url", request.NotifyUrl },
                { "app_name", "compress" },
                { "tasks", Convert.ToBase64String(Encoding.UTF8.GetBytes(client.JsonSerializer.Serialize(request.TaskList))) }
            };
            return await client.SendFlurlRequestAsFormUrlEncodedAsync<Models.CreatePretreatmentCompressResponse>(flurlReq, data: formdata, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pretreatment/ 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePretreatmentDepressResponse> ExecuteCreatePretreatmentDepressAsync(this UpyunUssClient client, Models.CreatePretreatmentDepressRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pretreatment", "")
                .WithUrl("https://p0.api.upyun.com/pretreatment/");

            var formdata = new Dictionary<string, string>()
            {
                { "service", request.BucketName },
                { "notify_url", request.NotifyUrl },
                { "app_name", "depress" },
                { "tasks", Convert.ToBase64String(Encoding.UTF8.GetBytes(client.JsonSerializer.Serialize(request.TaskList))) }
            };
            return await client.SendFlurlRequestAsFormUrlEncodedAsync<Models.CreatePretreatmentDepressResponse>(flurlReq, data: formdata, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pretreatment/ 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePretreatmentUConvertResponse> ExecuteCreatePretreatmentUConvertAsync(this UpyunUssClient client, Models.CreatePretreatmentUConvertRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pretreatment", "")
                .WithUrl("https://p0.api.upyun.com/pretreatment/");

            var formdata = new Dictionary<string, string>()
            {
                { "service", request.BucketName },
                { "notify_url", request.NotifyUrl },
                { "app_name", "uconvert" },
                { "tasks", Convert.ToBase64String(Encoding.UTF8.GetBytes(client.JsonSerializer.Serialize(request.TaskList))) }
            };
            return await client.SendFlurlRequestAsFormUrlEncodedAsync<Models.CreatePretreatmentUConvertResponse>(flurlReq, data: formdata, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pretreatment/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://help.upyun.com/knowledge-base/audit/#e4b88ae4bca0e9a284e5a484e79086 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePretreatmentImageAuditResponse> ExecuteCreatePretreatmentImageAuditAsync(this UpyunUssClient client, Models.CreatePretreatmentImageAuditRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pretreatment", "")
                .WithUrl("https://p0.api.upyun.com/pretreatment/");

            var formdata = new Dictionary<string, string>()
            {
                { "service", request.BucketName },
                { "notify_url", request.NotifyUrl },
                { "app_name", "imgaudit" },
                { "accept", "json" },
                { "tasks", Convert.ToBase64String(Encoding.UTF8.GetBytes(client.JsonSerializer.Serialize(request.TaskList))) }
            };
            return await client.SendFlurlRequestAsFormUrlEncodedAsync<Models.CreatePretreatmentImageAuditResponse>(flurlReq, data: formdata, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pretreatment/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://help.upyun.com/knowledge-base/audit/#e4b88ae4bca0e9a284e5a484e79086-2 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePretreatmentVideoAuditResponse> ExecuteCreatePretreatmentVideoAuditAsync(this UpyunUssClient client, Models.CreatePretreatmentVideoAuditRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "pretreatment", "")
                .WithUrl("https://p0.api.upyun.com/pretreatment/");

            var formdata = new Dictionary<string, string>()
            {
                { "service", request.BucketName },
                { "notify_url", request.NotifyUrl },
                { "app_name", "videoaudit" },
                { "accept", "json" },
                { "tasks", Convert.ToBase64String(Encoding.UTF8.GetBytes(client.JsonSerializer.Serialize(request.TaskList))) }
            };
            return await client.SendFlurlRequestAsFormUrlEncodedAsync<Models.CreatePretreatmentVideoAuditResponse>(flurlReq, data: formdata, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /{service}/liveaudit/create 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://help.upyun.com/knowledge-base/audit/#e5889be5bbbae4bbbbe58aa1 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePretreatmentLiveAuditResponse> ExecuteCreatePretreatmentLiveAuditAsync(this UpyunUssClient client, Models.CreatePretreatmentLiveAuditRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, request.BucketName, "liveaudit", "create")
                .WithUrl(new Url($"http://p1.api.upyun.com/").AppendPathSegments(request.BucketName, "liveaudit", "create"));

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePretreatmentLiveAuditResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /{service}/liveaudit/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://help.upyun.com/knowledge-base/audit/#e58f96e6b688e4bbbbe58aa1 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CancelPretreatmentLiveAuditResponse> ExecuteCancelPretreatmentLiveAuditAsync(this UpyunUssClient client, Models.CancelPretreatmentLiveAuditRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, request.BucketName, "liveaudit", "cancel")
                .WithUrl(new Url($"http://p1.api.upyun.com/").AppendPathSegments(request.BucketName, "liveaudit", "cancel"));

            return await client.SendFlurlRequestAsJsonAsync<Models.CancelPretreatmentLiveAuditResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
