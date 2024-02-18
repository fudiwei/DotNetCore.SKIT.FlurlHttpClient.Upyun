using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Upyun.Sim
{
    /// <summary>
    /// 一个又拍云一键登录服务 API HTTP 客户端。
    /// </summary>
    public class UpyunSimClient : CommonClientBase, ICommonClient
    {
        /// <summary>
        /// 获取当前客户端使用的又拍云一键登录服务凭证。
        /// </summary>
        public Settings.Credentials Credentials { get; }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="UpyunSimClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public UpyunSimClient(UpyunSimClientOptions options)
            : this(options, null)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <param name="httpClient"></param>
        /// <param name="disposeClient"></param>
        internal protected UpyunSimClient(UpyunSimClientOptions options, HttpClient? httpClient, bool disposeClient = true)
            : base(httpClient, disposeClient)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            Credentials = new Settings.Credentials(options);

            FlurlClient.BaseUrl = options.Endpoint ?? UpyunSimEndpoints.DEFAULT;
            FlurlClient.WithTimeout(options.Timeout <= 0 ? Timeout.InfiniteTimeSpan : TimeSpan.FromMilliseconds(options.Timeout));
            FlurlClient.WithBasicAuth(options.AppKey, options.AppSecret);
        }

        /// <summary>
        /// 使用当前客户端生成一个新的 <see cref="IFlurlRequest"/> 对象。
        /// </summary>
        /// <param name="request"></param>
        /// <param name="httpMethod"></param>
        /// <param name="urlSegments"></param>
        /// <returns></returns>
        public IFlurlRequest CreateFlurlRequest(UpyunSimRequest request, HttpMethod httpMethod, params object[] urlSegments)
        {
            IFlurlRequest flurlRequest = base.CreateFlurlRequest(request, httpMethod, urlSegments);

            return flurlRequest;
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="flurlRequest"></param>
        /// <param name="httpContent"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendFlurlRequestAsync<T>(IFlurlRequest flurlRequest, HttpContent? httpContent = null, CancellationToken cancellationToken = default)
            where T : UpyunSimResponse, new()
        {
            if (flurlRequest is null) throw new ArgumentNullException(nameof(flurlRequest));

            using IFlurlResponse flurlResponse = await base.SendFlurlRequestAsync(flurlRequest, httpContent, cancellationToken).ConfigureAwait(false);
            return await WrapFlurlResponseAsJsonAsync<T>(flurlResponse, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="flurlRequest"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendFlurlRequestAsJsonAsync<T>(IFlurlRequest flurlRequest, object? data = null, CancellationToken cancellationToken = default)
            where T : UpyunSimResponse, new()
        {
            if (flurlRequest is null) throw new ArgumentNullException(nameof(flurlRequest));

            bool isSimpleRequest = data is null ||
                flurlRequest.Verb == HttpMethod.Get ||
                flurlRequest.Verb == HttpMethod.Head ||
                flurlRequest.Verb == HttpMethod.Options;
            using IFlurlResponse flurlResponse = isSimpleRequest ?
                await base.SendFlurlRequestAsync(flurlRequest, null, cancellationToken).ConfigureAwait(false) :
                await base.SendFlurlRequestAsJsonAsync(flurlRequest, data, cancellationToken).ConfigureAwait(false);
            return await WrapFlurlResponseAsJsonAsync<T>(flurlResponse, cancellationToken).ConfigureAwait(false);
        }
    }
}
