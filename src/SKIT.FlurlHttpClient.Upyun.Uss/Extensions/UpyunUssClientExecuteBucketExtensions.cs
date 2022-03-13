using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Upyun.Uss
{
    public static class UpyunUssClientExecuteBucketExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /{bucket}/?usage 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/rest_api/#e88eb7e58f96e69c8de58aa1e4bdbfe794a8e9878f </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBucketUsageResponse> ExecuteGetBucketUsageAsync(this UpyunUssClient client, Models.GetBucketUsageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, request.BucketName, "/")
                .SetQueryParam("usage", string.Empty, nullValueHandling: NullValueHandling.NameOnly);

            return await client.SendRequestAsync<Models.GetBucketUsageResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
