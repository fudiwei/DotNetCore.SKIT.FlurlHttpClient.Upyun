using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Upyun.Sms
{
    public static class UpyunSmsClientExecuteDetectionExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /detection/mobile 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://help.upyun.com/knowledge-base/sms-api ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMobileDetectionResponse> ExecuteCreateMobileDetectionAsync(this UpyunSmsClient client, Models.CreateMobileDetectionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "detection", "mobile");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMobileDetectionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
