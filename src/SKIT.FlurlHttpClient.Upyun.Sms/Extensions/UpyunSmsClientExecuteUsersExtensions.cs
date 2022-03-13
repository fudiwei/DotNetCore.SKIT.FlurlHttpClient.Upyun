using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Upyun.Sms
{
    public static class UpyunSmsClientExecuteUsersExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /users/remain 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/sms-api </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetUserRemainResponse> ExecuteGetUserRemainAsync(this UpyunSmsClient client, Models.GetUserRemainRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "users", "remain");

            return await client.SendRequestWithJsonAsync<Models.GetUserRemainResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
