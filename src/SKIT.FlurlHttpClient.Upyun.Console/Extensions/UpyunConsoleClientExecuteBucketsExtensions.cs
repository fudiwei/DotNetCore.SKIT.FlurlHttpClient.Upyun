using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Upyun.Console
{
    public static class UpyunConsoleClientExecuteBucketsExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /buckets 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.upyun.com/doc#/api/operation/bucket/GET%20%2Fbuckets ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryBucketsResponse> ExecuteQueryBucketsAsync(this UpyunConsoleClient client, Models.QueryBucketsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "buckets")
                .SetQueryParam("since", request.Since)
                .SetQueryParam("max", request.Max)
                .SetQueryParam("limit", request.Limit)
                .SetQueryParam("name", request.Name)
                .SetQueryParam("business_type", request.BusinessType)
                .SetQueryParam("type", request.Type)
                .SetQueryParam("visible", request.IsVisible.HasValue ? request.IsVisible.Value ? "true" : "false" : null)
                .SetQueryParam("bucket_name", request.BucketName);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryBucketsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /buckets 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.upyun.com/doc#/api/operation/bucket/PUT%20%2Fbuckets ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateBucketResponse> ExecuteCreateBucketAsync(this UpyunConsoleClient client, Models.CreateBucketRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "buckets");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateBucketResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /buckets 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.upyun.com/doc#/api/operation/bucket/POST%20%2Fbuckets ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateBucketResponse> ExecuteUpdateBucketAsync(this UpyunConsoleClient client, Models.UpdateBucketRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Put, "buckets");

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateBucketResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /buckets/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.upyun.com/doc#/api/operation/bucket/POST%20%2Fbuckets%2Fdelete ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DeleteBucketResponse> ExecuteDeleteBucketAsync(this UpyunConsoleClient client, Models.DeleteBucketRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.Password is null)
                request.Password = client.Credentials.Password;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "buckets", "delete");

            return await client.SendFlurlRequestAsJsonAsync<Models.DeleteBucketResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /buckets/info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.upyun.com/doc#/api/operation/bucket/GET%20%2Fbuckets%2Finfo ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBucketInfoResponse> ExecuteGetBucketInfoAsync(this UpyunConsoleClient client, Models.GetBucketInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "buckets", "info")
                .SetQueryParam("bucket_name", request.BucketName);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBucketInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region Operators
        /// <summary>
        /// <para>异步调用 [GET] /buckets/operators 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.upyun.com/doc#/api/operation/bucket/GET%20%2Fbuckets%2Foperators ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryBucketOperatorsResponse> ExecuteQueryBucketOperatorsAsync(this UpyunConsoleClient client, Models.QueryBucketOperatorsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "buckets", "operators")
                .SetQueryParam("bucket_name", request.BucketName);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryBucketOperatorsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /buckets/operators 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.upyun.com/doc#/api/operation/bucket/PUT%20%2Fbuckets%2Foperators ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AddBucketOperatorResponse> ExecuteAddBucketOperatorAsync(this UpyunConsoleClient client, Models.AddBucketOperatorRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Put, "buckets", "operators");

            return await client.SendFlurlRequestAsJsonAsync<Models.AddBucketOperatorResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [DELETE] /buckets/operators 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.upyun.com/doc#/api/operation/bucket/DELETE%20%2Fbuckets%2Foperators ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RemoveBucketOperatorResponse> ExecuteRemoveBucketOperatorAsync(this UpyunConsoleClient client, Models.RemoveBucketOperatorRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Delete, "buckets", "operators")
                .SetQueryParam("bucket_name", request.BucketName)
                .SetQueryParam("operator_name", request.OperatorName);

            return await client.SendFlurlRequestAsJsonAsync<Models.RemoveBucketOperatorResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Domains
        /// <summary>
        /// <para>异步调用 [GET] /buckets/domains 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.upyun.com/doc#/api/operation/domain/GET%20%2Fbuckets%2Fdomains ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryBucketDomainsResponse> ExecuteQueryBucketDomainsAsync(this UpyunConsoleClient client, Models.QueryBucketDomainsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "buckets", "domains")
                .SetQueryParam("bucket_name", request.BucketName)
                .SetQueryParam("page", request.Page)
                .SetQueryParam("limit", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryBucketDomainsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /buckets/domains 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.upyun.com/doc#/api/operation/domain/PUT%20%2Fbuckets%2Fdomains ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AddBucketDomainResponse> ExecuteAddBucketDomainAsync(this UpyunConsoleClient client, Models.AddBucketDomainRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Put, "buckets", "domains");

            return await client.SendFlurlRequestAsJsonAsync<Models.AddBucketDomainResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [DELETE] /buckets/domains 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.upyun.com/doc#/api/operation/domain/DELETE%20%2Fbuckets%2Fdomains ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RemoveBucketDomainResponse> ExecuteRemoveBucketDomainAsync(this UpyunConsoleClient client, Models.RemoveBucketDomainRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Delete, "buckets", "domains")
                .SetQueryParam("bucket_name", request.BucketName)
                .SetQueryParam("domain", request.DomainName);

            return await client.SendFlurlRequestAsJsonAsync<Models.RemoveBucketDomainResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region CDN
        /// <summary>
        /// <para>异步调用 [POST] /buckets/cdn/expired 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.upyun.com/doc#/api/operation/cache/POST%20%2Fbuckets%2Fcdn%2Fexpired ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetBucketCDNExpiredResponse> ExecuteSetBucketCDNExpiredAsync(this UpyunConsoleClient client, Models.SetBucketCDNExpiredRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "buckets", "cdn", "expired");

            return await client.SendFlurlRequestAsJsonAsync<Models.SetBucketCDNExpiredResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/buckets/cdn/cache 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.upyun.com/doc#/api/operation/cdn/POST%20%2Fv2%2Fbuckets%2Fcdn%2Fcache ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetBucketCDNCacheV2Response> ExecuteSetBucketCDNCacheV2Async(this UpyunConsoleClient client, Models.SetBucketCDNCacheV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v2", "buckets", "cdn", "cache");

            return await client.SendFlurlRequestAsJsonAsync<Models.SetBucketCDNCacheV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /v2/buckets/cdn/cache 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.upyun.com/doc#/api/operation/cdn/GET%20%2Fv2%2Fbuckets%2Fcdn%2Fcache ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBucketCDNCacheV2Response> ExecuteGetBucketCDNCacheV2Async(this UpyunConsoleClient client, Models.GetBucketCDNCacheV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v2", "buckets", "cdn", "cache")
                .SetQueryParam("bucket_name", request.BucketName);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBucketCDNCacheV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/buckets/cdn/source 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.upyun.com/doc#/api/operation/cdn/POST%20%2Fv2%2Fbuckets%2Fcdn%2Fsource ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetBucketCDNSourceV2Response> ExecuteSetBucketCDNSourceV2Async(this UpyunConsoleClient client, Models.SetBucketCDNSourceV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v2", "buckets", "cdn", "source");

            return await client.SendFlurlRequestAsJsonAsync<Models.SetBucketCDNSourceV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /v2/buckets/cdn/source 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://api.upyun.com/doc#/api/operation/cdn/GET%20%2Fv2%2Fbuckets%2Fcdn%2Fsource ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBucketCDNSourceV2Response> ExecuteGetBucketCDNSourceV2Async(this UpyunConsoleClient client, Models.GetBucketCDNSourceV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "v2", "buckets", "cdn", "source")
                .SetQueryParam("bucket_name", request.BucketName);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBucketCDNSourceV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
