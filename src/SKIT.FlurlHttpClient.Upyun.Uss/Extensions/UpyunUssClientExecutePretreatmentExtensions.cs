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
        /// <para>REF: https://help.upyun.com/knowledge-base/spider/#e68f90e4baa4e5a484e79086e4bbbbe58aa1 </para>
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
                .CreateRequest(request, HttpMethod.Post, "pretreatment/");
            flurlReq.Url = new Url("https://p0.api.upyun.com/pretreatment/");

#pragma warning disable CS8620
            using var httpContent = new FormUrlEncodedContent(new Dictionary<string, string>()
            {
                { "service", request.BucketName },
                { "notify_url", request.NotifyUrl },
                { "app_name", "spiderman" },
                { "tasks", Convert.ToBase64String(Encoding.UTF8.GetBytes(client.JsonSerializer.Serialize(request.TaskList))) }
            });
#pragma warning restore CS8620
            return await client.SendRequestAsync<Models.CreatePretreatmentSpidermanResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pretreatment/ 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/spider/#e68f90e4baa4e5a484e79086e4bbbbe58aa1 </para>
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
                .CreateRequest(request, HttpMethod.Post, "pretreatment/");
            flurlReq.Url = new Url("https://p0.api.upyun.com/pretreatment/");

#pragma warning disable CS8620
            using var httpContent = new FormUrlEncodedContent(new Dictionary<string, string>()
            {
                { "service", request.BucketName },
                { "notify_url", request.NotifyUrl },
                { "app_name", "thumb" },
                { "accept", "json" },
                { "tasks", Convert.ToBase64String(Encoding.UTF8.GetBytes(client.JsonSerializer.Serialize(request.TaskList))) }
            });
#pragma warning restore CS8620
            return await client.SendRequestAsync<Models.CreatePretreatmentThumbnailResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
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
                .CreateRequest(request, HttpMethod.Post, "pretreatment/");
            flurlReq.Url = new Url("https://p0.api.upyun.com/pretreatment/");

#pragma warning disable CS8620
            using var httpContent = new FormUrlEncodedContent(new Dictionary<string, string>()
            {
                { "service", request.BucketName },
                { "notify_url", request.NotifyUrl },
                { "app_name", "jigsaw" },
                { "tasks", Convert.ToBase64String(Encoding.UTF8.GetBytes(client.JsonSerializer.Serialize(request.TaskList))) }
            });
#pragma warning restore CS8620
            return await client.SendRequestAsync<Models.CreatePretreatmentJigsawResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
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
                .CreateRequest(request, HttpMethod.Post, "pretreatment/");
            flurlReq.Url = new Url("https://p0.api.upyun.com/pretreatment/");

#pragma warning disable CS8620
            using var httpContent = new FormUrlEncodedContent(new Dictionary<string, string>()
            {
                { "service", request.BucketName },
                { "notify_url", request.NotifyUrl },
                { "app_name", "compress" },
                { "tasks", Convert.ToBase64String(Encoding.UTF8.GetBytes(client.JsonSerializer.Serialize(request.TaskList))) }
            });
#pragma warning restore CS8620
            return await client.SendRequestAsync<Models.CreatePretreatmentCompressResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
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
                .CreateRequest(request, HttpMethod.Post, "pretreatment/");
            flurlReq.Url = new Url("https://p0.api.upyun.com/pretreatment/");

#pragma warning disable CS8620
            using var httpContent = new FormUrlEncodedContent(new Dictionary<string, string>()
            {
                { "service", request.BucketName },
                { "notify_url", request.NotifyUrl },
                { "app_name", "depress" },
                { "tasks", Convert.ToBase64String(Encoding.UTF8.GetBytes(client.JsonSerializer.Serialize(request.TaskList))) }
            });
#pragma warning restore CS8620
            return await client.SendRequestAsync<Models.CreatePretreatmentDepressResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
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
                .CreateRequest(request, HttpMethod.Post, "pretreatment/");
            flurlReq.Url = new Url("https://p0.api.upyun.com/pretreatment/");

#pragma warning disable CS8620
            using var httpContent = new FormUrlEncodedContent(new Dictionary<string, string>()
            {
                { "service", request.BucketName },
                { "notify_url", request.NotifyUrl },
                { "app_name", "uconvert" },
                { "tasks", Convert.ToBase64String(Encoding.UTF8.GetBytes(client.JsonSerializer.Serialize(request.TaskList))) }
            });
#pragma warning restore CS8620
            return await client.SendRequestAsync<Models.CreatePretreatmentUConvertResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /pretreatment/ 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/audit/#e4ba91e5ad98e582a8e4b8ade79a84e59bbee78987e5a484e79086 </para>
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
                .CreateRequest(request, HttpMethod.Post, "pretreatment/");
            flurlReq.Url = new Url("https://p0.api.upyun.com/pretreatment/");

#pragma warning disable CS8620
            using var httpContent = new FormUrlEncodedContent(new Dictionary<string, string>()
            {
                { "service", request.BucketName },
                { "notify_url", request.NotifyUrl },
                { "app_name", "imgaudit" },
                { "accept", "json" },
                { "tasks", Convert.ToBase64String(Encoding.UTF8.GetBytes(client.JsonSerializer.Serialize(request.TaskList))) }
            });
#pragma warning restore CS8620
            return await client.SendRequestAsync<Models.CreatePretreatmentImageAuditResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /{service}/liveaudit/create 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/audit/#e5889be5bbbae4bbbbe58aa1 </para>
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
                .CreateRequest(request, HttpMethod.Post, request.BucketName, "liveaudit", "create");
            flurlReq.Url = new Url($"http://p1.api.upyun.com/").AppendPathSegments(request.BucketName, "liveaudit", "create");

            using var httpContent = new StringContent(client.JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
            return await client.SendRequestAsync<Models.CreatePretreatmentLiveAuditResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /{service}/liveaudit/cancel 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/audit/#e58f96e6b688e4bbbbe58aa1 </para>
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
                .CreateRequest(request, HttpMethod.Post, request.BucketName, "liveaudit", "cancel");
            flurlReq.Url = new Url($"http://p1.api.upyun.com/").AppendPathSegments(request.BucketName, "liveaudit", "cancel");

            using var httpContent = new StringContent(client.JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
            return await client.SendRequestAsync<Models.CancelPretreatmentLiveAuditResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }
    }
}
