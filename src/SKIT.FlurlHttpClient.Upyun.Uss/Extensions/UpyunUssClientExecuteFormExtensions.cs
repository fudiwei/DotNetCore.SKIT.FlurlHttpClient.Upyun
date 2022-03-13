using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Upyun.Uss
{
    public static class UpyunUssClientExecuteFormExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /{bucket} 接口。</para>
        /// <para>REF: https://help.upyun.com/knowledge-base/form_api/#e5b08fe69687e4bbb6e4b88ae4bca0 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UploadFileWithFormResponse> ExecuteUploadFileWithFormAsync(this UpyunUssClient client, Models.UploadFileWithFormRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ExpireTimestamp == null)
                request.ExpireTimestamp = DateTimeOffset.Now.AddMinutes(30).ToUnixTimeSeconds();

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, request.BucketName);

            using var formContent = new MultipartFormDataContent();
            using var fileContent = new ByteArrayContent(request.FileBytes ?? Array.Empty<byte>());
            fileContent.Headers.ContentLength = request.FileBytes?.Length;
            formContent.Add(fileContent, Constants.FormDataFields.FORMDATA_FILE, Path.GetFileName(request.FileKey));
            formContent.Add(new StringContent(request.BucketName, Encoding.UTF8), "bucket");
            formContent.Add(new StringContent(request.FileKey, Encoding.UTF8), "save-key");
            formContent.Add(new StringContent(request.ExpireTimestamp.Value.ToString(), Encoding.UTF8), "expiration");

            if (request.FileContentType != null)
            {
                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.FileContentType);
                formContent.Add(new StringContent(request.FileContentType, Encoding.UTF8), "content-type");
            }

            if (request.FileMd5 != null)
            {
                fileContent.Headers.ContentMD5 = Encoding.UTF8.GetBytes(request.FileMd5);
                formContent.Add(new StringContent(request.FileMd5, Encoding.UTF8), "content-md5");
            }

            if (request.FileSecret != null)
            {
                formContent.Add(new StringContent(request.FileSecret, Encoding.UTF8), "content-secret");
            }

            if (request.AllowedFileTypeList != null)
            {
                string value = string.Join(",", request.AllowedFileTypeList);
                formContent.Add(new StringContent(value, Encoding.UTF8), "allow-file-type");
            }

            if (request.AllowedFileSizeRange != null)
            {
                string value = $"{request.AllowedFileSizeRange.Mininum},{request.AllowedFileSizeRange.Maxinum}";
                formContent.Add(new StringContent(value, Encoding.UTF8), "content-length-range");
            }

            if (request.AllowedImageWidthRange != null)
            {
                string value = $"{request.AllowedImageWidthRange.Mininum},{request.AllowedImageWidthRange.Maxinum}";
                formContent.Add(new StringContent(value, Encoding.UTF8), "image-width-range");
            }

            if (request.AllowedHeightWidthRange != null)
            {
                string value = $"{request.AllowedHeightWidthRange.Mininum},{request.AllowedHeightWidthRange.Maxinum}";
                formContent.Add(new StringContent(value, Encoding.UTF8), "image-height-range");
            }

            if (request.Metadata != null)
            {
                foreach (KeyValuePair<string, string> item in request.Metadata)
                {
                    string key = $"x-upyun-meta-{Regex.Replace(item.Key, "^x-upyun-meta-", "", RegexOptions.IgnoreCase)}";
                    formContent.Add(new StringContent(item.Value, Encoding.UTF8), key);
                }
            }

            if (request.ImagePretreatmentOptions != null)
            {
                formContent.Add(new StringContent(request.ImagePretreatmentOptions, Encoding.UTF8), "x-gmkerl-thumb");
            }

            if (request.AsyncPretreatmentParameters != null && request.AsyncPretreatmentParameters.Any())
            {
                string value = client.JsonSerializer.Serialize(request.AsyncPretreatmentParameters);
                formContent.Add(new StringContent(value, Encoding.UTF8), "apps");
            }

            if (request.ReturnUrl != null)
            {
                formContent.Add(new StringContent(request.ReturnUrl, Encoding.UTF8), "return-url");
            }

            if (request.NotifyUrl != null)
            {
                formContent.Add(new StringContent(request.NotifyUrl, Encoding.UTF8), "notify-url");
            }

            if (request.ExtraParameter != null)
            {
                formContent.Add(new StringContent(request.ExtraParameter, Encoding.UTF8), "ext-param");
            }

            if (request.CallbackUrl != null)
            {
                formContent.Add(new StringContent(request.CallbackUrl, Encoding.UTF8), "callback-url");
            }

            return await client.SendRequestAsync<Models.UploadFileWithFormResponse>(flurlReq, httpContent: formContent, cancellationToken: cancellationToken);
        }
    }
}
