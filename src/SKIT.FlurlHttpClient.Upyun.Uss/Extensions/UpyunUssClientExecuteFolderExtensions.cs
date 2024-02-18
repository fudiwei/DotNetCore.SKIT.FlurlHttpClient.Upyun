using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Upyun.Uss
{
    public static class UpyunUssClientExecuteFolderExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /{bucket}/{path_to_folder} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://help.upyun.com/knowledge-base/rest_api/#e4b88ae4bca0e69687e4bbb6 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateFolderResponse> ExecuteCreateFolderAsync(this UpyunUssClient client, Models.CreateFolderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, request.BucketName, request.FolderPath)
                .WithHeader("folder", "true");

            return await client.SendFlurlRequestAsync<Models.CreateFolderResponse>(flurlReq, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [DELETE] /{bucket}/{path_to_folder} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://help.upyun.com/knowledge-base/rest_api/#e588a0e999a4e79baee5bd95 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DeleteFolderResponse> ExecuteDeleteFolderAsync(this UpyunUssClient client, Models.DeleteFolderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Delete, request.BucketName, request.FolderPath);

            return await client.SendFlurlRequestAsync<Models.DeleteFolderResponse>(flurlReq, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
