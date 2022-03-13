using System;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Upyun.Uss
{
    public static class UpyunUssClientExecuteFileExtensions
    {
        /// <summary>
        /// <para>异步调用 [PUT] /{bucket}/{path_to_file} 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/rest_api/#e4b88ae4bca0e69687e4bbb6 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UploadFileResponse> ExecuteUploadFileAsync(this UpyunUssClient client, Models.UploadFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Put, request.BucketName, request.FileKey);

            if (request.FileMd5 != null)
            {
                flurlReq.WithHeader("Content-MD5", request.FileMd5);
            }

            if (request.FileContentType != null)
            {
                flurlReq.WithHeader("Content-Type", request.FileContentType);
            }

            if (request.FileSecret != null)
            {
                flurlReq.WithHeader("Content-Secret", request.FileSecret);
            }

            if (request.Metadata != null)
            {
                flurlReq.WithHeaders(
                    request.Metadata.ToDictionary(
                        k => $"X-Upyun-Meta-{Regex.Replace(k.Key, "^X-Upyun-Meta-", "", RegexOptions.IgnoreCase)}",
                        v => v.Value
                    ),
                    replaceUnderscoreWithHyphen: false
                );
            }

            if (request.ImagePretreatmentOptions != null)
            {
                flurlReq.WithHeader("x-gmkerl-thumb", request.ImagePretreatmentOptions);
            }

            using var httpContent = new ByteArrayContent(request.FileBytes ?? Array.Empty<byte>());
            httpContent.Headers.ContentLength = request.FileBytes?.Length;
            return await client.SendRequestAsync<Models.UploadFileResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /{bucket}/{save_as_file} 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/rest_api/#e5a48de588b6e69687e4bbb6 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CopyFileResponse> ExecuteCopyFileAsync(this UpyunUssClient client, Models.CopyFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Put, request.BucketName, request.TargetFileKey)
                .WithHeader("X-Upyun-Copy-Source", $"{request.BucketName}/{request.SourceFileKey}");

            if (request.FileMd5 != null)
                flurlReq.WithHeader("Content-MD5", request.FileMd5);

            return await client.SendRequestAsync<Models.CopyFileResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /{bucket}/{save_as_file} 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/rest_api/#e7a7bbe58aa8e69687e4bbb6 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MoveFileResponse> ExecuteMoveFileAsync(this UpyunUssClient client, Models.MoveFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Put, request.BucketName, request.TargetFileKey)
                .WithHeader("X-Upyun-Move-Source", $"{request.BucketName}/{request.SourceFileKey}");

            if (request.FileMd5 != null)
                flurlReq.WithHeader("Content-MD5", request.FileMd5);

            return await client.SendRequestAsync<Models.MoveFileResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /{bucket}/{path_to_file} 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/rest_api/#e4b88be8bdbde69687e4bbb6 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DownloadFileResponse> ExecuteDownloadFileAsync(this UpyunUssClient client, Models.DownloadFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, request.BucketName, request.FileKey);

            return await client.SendRequestAsync<Models.DownloadFileResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [HEAD] /{bucket}/{path_to_file} 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/rest_api/#e88eb7e58f96e69687e4bbb6e4bfa1e681af </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetFileInfoResponse> ExecuteGetFileInfoAsync(this UpyunUssClient client, Models.GetFileInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Head, request.BucketName, request.FileKey);

            return await client.SendRequestAsync<Models.GetFileInfoResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /{bucket}/{path_to_folder} 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/rest_api/#e88eb7e58f96e79baee5bd95e69687e4bbb6e58897e8a1a8 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryFilesResponse> ExecuteQueryFilesAsync(this UpyunUssClient client, Models.QueryFilesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, request.BucketName, request.FolderName ?? "/")
                .WithHeader(FlurlHttpClient.Constants.HttpHeaders.Accept, "application/json");

            if (request.Offset != null)
                flurlReq.WithHeader("x-list-iter", request.Offset);

            if (request.Limit != null)
                flurlReq.WithHeader("x-list-limit", request.Limit.Value);

            if (request.OrderType != null)
                flurlReq.WithHeader("x-list-order", request.OrderType);

            return await client.SendRequestAsync<Models.QueryFilesResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [DELETE] /{bucket}/{path_to_file} 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/rest_api/#e588a0e999a4e69687e4bbb6 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DeleteFileResponse> ExecuteDeleteFileAsync(this UpyunUssClient client, Models.DeleteFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Delete, request.BucketName, request.FileKey);

            return await client.SendRequestAsync<Models.DeleteFileResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        #region Metadata
        /// <summary>
        /// <para>异步调用 [PATCH] /{bucket}/{path_to_file}?metadata={action} 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/rest_api/#metadata </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetFileMetadataResponse> ExecuteSetFileMetadataAsync(this UpyunUssClient client, Models.SetFileMetadataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, new HttpMethod("PATCH"), request.BucketName, request.FileKey)
                .SetQueryParam("metadata", request.Action);

            if (request.Metadata != null)
            {
                flurlReq.WithHeaders(
                    request.Metadata.ToDictionary(
                        k => $"X-Upyun-Meta-{Regex.Replace(k.Key, "^X-Upyun-Meta-", "", RegexOptions.IgnoreCase)}",
                        v => v.Value
                    ),
                    replaceUnderscoreWithHyphen: false
                );
            }

            return await client.SendRequestAsync<Models.SetFileMetadataResponse>(flurlReq, cancellationToken: cancellationToken);
        }
        #endregion

        #region Partial
        /// <summary>
        /// <para>异步调用 [PUT] /{bucket}/{path_to_file} 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/rest_api/#e695b0e68daee4bca0e8be93 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.InitializeParallelPartialUploadFileResponse> ExecuteInitializeParallelPartialUploadFileAsync(this UpyunUssClient client, Models.InitializeParallelPartialUploadFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Put, request.BucketName, request.FileKey)
                .WithHeader("X-Upyun-Multi-Disorder", "true")
                .WithHeader("X-Upyun-Multi-Stage", "initiate")
                .WithHeader("X-Upyun-Multi-Length", request.FileSize)
                .WithHeader("X-Upyun-Multi-Part-Size", request.ChunkSize);

            if (request.FileMd5 != null)
            {
                flurlReq.WithHeader("Content-MD5", request.FileMd5);
            }

            if (request.FileContentType != null)
            {
                flurlReq.WithHeader("X-Upyun-Multi-Type", request.FileContentType);
            }

            if (request.Metadata != null)
            {
                flurlReq.WithHeaders(
                    request.Metadata.ToDictionary(
                        k => $"X-Upyun-Meta-{Regex.Replace(k.Key, "^X-Upyun-Meta-", "", RegexOptions.IgnoreCase)}",
                        v => v.Value
                    ),
                    replaceUnderscoreWithHyphen: false
                );
            }

            return await client.SendRequestAsync<Models.InitializeParallelPartialUploadFileResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /{bucket}/{path_to_file} 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/rest_api/#e7bb93e69d9f </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TransferParallelPartialUploadFileResponse> ExecuteTransferParallelPartialUploadFileAsync(this UpyunUssClient client, Models.TransferParallelPartialUploadFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Put, request.BucketName, request.FileKey)
                .WithHeader("X-Upyun-Multi-Stage", "upload")
                .WithHeader("X-Upyun-Multi-Uuid", request.PartialUUID)
                .WithHeader("X-Upyun-Part-Id", request.ChunkId);

            if (request.FileMd5 != null)
            {
                flurlReq.WithHeader("Content-MD5", request.FileMd5);
            }

            using var httpContent = new ByteArrayContent(request.FileBytes ?? Array.Empty<byte>());
            httpContent.Headers.ContentLength = request.FileBytes?.Length;
            return await client.SendRequestAsync<Models.TransferParallelPartialUploadFileResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /{bucket}/{path_to_file} 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/rest_api/#e695b0e68daee4bca0e8be93 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CompleteParallelPartialUploadFileResponse> ExecuteCompleteParallelPartialUploadFileAsync(this UpyunUssClient client, Models.CompleteParallelPartialUploadFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Put, request.BucketName, request.FileKey)
                .WithHeader("X-Upyun-Multi-Stage", "complete")
                .WithHeader("X-Upyun-Multi-Uuid", request.PartialUUID);

            if (request.FileMd5 != null)
            {
                flurlReq.WithHeader("Content-MD5", request.FileMd5);
            }

            return await client.SendRequestAsync<Models.CompleteParallelPartialUploadFileResponse>(flurlReq, cancellationToken: cancellationToken);
        }
        #endregion

        #region SerialPartial
        /// <summary>
        /// <para>异步调用 [PUT] /{bucket}/{path_to_file} 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/rest_api/#e5889de5a78be58c96-2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.InitializeSerialPartialUploadFileResponse> ExecuteInitializeSerialPartialUploadFileAsync(this UpyunUssClient client, Models.InitializeSerialPartialUploadFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Put, request.BucketName, request.FileKey)
                .WithHeader("X-Upyun-Multi-Stage", "initiate")
                .WithHeader("X-Upyun-Multi-Length", request.FileSize)
                .WithHeader("X-Upyun-Multi-Part-Size", request.ChunkSize);

            if (request.FileMd5 != null)
            {
                flurlReq.WithHeader("Content-MD5", request.FileMd5);
            }

            if (request.FileContentType != null)
            {
                flurlReq.WithHeader("X-Upyun-Multi-Type", request.FileContentType);
            }

            if (request.Metadata != null)
            {
                flurlReq.WithHeaders(
                    request.Metadata.ToDictionary(
                        k => $"X-Upyun-Meta-{Regex.Replace(k.Key, "^X-Upyun-Meta-", "", RegexOptions.IgnoreCase)}",
                        v => v.Value
                    ),
                    replaceUnderscoreWithHyphen: false
                );
            }

            return await client.SendRequestAsync<Models.InitializeSerialPartialUploadFileResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /{bucket}/{path_to_file} 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/rest_api/#e5889de5a78be58c96-2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TransferSerialPartialUploadFileResponse> ExecuteTransferSerialPartialUploadFileAsync(this UpyunUssClient client, Models.TransferSerialPartialUploadFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Put, request.BucketName, request.FileKey)
                .WithHeader("X-Upyun-Multi-Stage", "upload")
                .WithHeader("X-Upyun-Multi-Uuid", request.PartialUUID)
                .WithHeader("X-Upyun-Part-Id", request.ChunkId);

            if (request.FileMd5 != null)
            {
                flurlReq.WithHeader("Content-MD5", request.FileMd5);
            }

            using var httpContent = new ByteArrayContent(request.FileBytes ?? Array.Empty<byte>());
            httpContent.Headers.ContentLength = request.FileBytes?.Length;
            return await client.SendRequestAsync<Models.TransferSerialPartialUploadFileResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PUT] /{bucket}/{path_to_file} 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/rest_api/#e7bb93e69d9f-2 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CompleteSerialPartialUploadFileResponse> ExecuteCompleteSerialPartialUploadFileAsync(this UpyunUssClient client, Models.CompleteSerialPartialUploadFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Put, request.BucketName, request.FileKey)
                .WithHeader("X-Upyun-Multi-Stage", "complete")
                .WithHeader("X-Upyun-Multi-Uuid", request.PartialUUID);

            if (request.FileMd5 != null)
            {
                flurlReq.WithHeader("Content-MD5", request.FileMd5);
            }

            return await client.SendRequestAsync<Models.CompleteSerialPartialUploadFileResponse>(flurlReq, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
