using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Upyun.Console
{
    /// <summary>
    /// 一个又拍云服务管理后台开放 API HTTP 客户端。
    /// </summary>
    public class UpyunConsoleClient : CommonClientBase, ICommonClient
    {
        /// <summary>
        /// 获取当前客户端使用的又拍云服务管理后台凭证。
        /// </summary>
        public Settings.Credentials Credentials { get; }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="UpyunConsoleClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public UpyunConsoleClient(UpyunConsoleClientOptions options)
            : base()
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            Credentials = new Settings.Credentials(options);

            FlurlClient.BaseUrl = options.Endpoint ?? UpyunConsoleEndpoints.DEFAULT;
            FlurlClient.WithTimeout(TimeSpan.FromMilliseconds(options.Timeout));
        }

        /// <summary>
        /// 用指定的又拍云服务管理后台用户名和密码初始化 <see cref="UpyunConsoleClient"/> 类的新实例。
        /// </summary>
        /// <param name="username">又拍云服务管理后台用户名。</param>
        /// <param name="password">又拍云服务管理后台密码。</param>
        /// <param name="options">配置项。</param>
        public UpyunConsoleClient(string username, string password)
            : this(new UpyunConsoleClientOptions() { Username = username, Password = password })
        {
        }

        /// <summary>
        /// 使用当前客户端生成一个新的 <see cref="IFlurlRequest"/> 对象。
        /// </summary>
        /// <param name="request"></param>
        /// <param name="method"></param>
        /// <param name="urlSegments"></param>
        /// <returns></returns>
        public IFlurlRequest CreateRequest(UpyunConsoleRequest request, HttpMethod method, params object[] urlSegments)
        {
            IFlurlRequest flurlRequest = FlurlClient.Request(urlSegments).WithVerb(method);

            if (request.Timeout != null)
            {
                flurlRequest.WithTimeout(TimeSpan.FromMilliseconds(request.Timeout.Value));
            }

            if (request.AccessToken != null)
            {
                flurlRequest.WithHeader(Constants.HttpHeaders.Authorization, $"Bearer {request.AccessToken}");
            }

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
        public async Task<T> SendRequestAsync<T>(IFlurlRequest flurlRequest, HttpContent? httpContent = null, CancellationToken cancellationToken = default)
            where T : UpyunConsoleResponse, new()
        {
            if (flurlRequest == null) throw new ArgumentNullException(nameof(flurlRequest));

            try
            {
                using IFlurlResponse flurlResponse = await base.SendRequestAsync(flurlRequest, httpContent, cancellationToken);
                return await WrapResponseWithJsonAsync<T>(flurlResponse, cancellationToken);
            }
            catch (FlurlHttpException ex)
            {
                throw new UpyunConsoleException(ex.Message, ex);
            }
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="flurlRequest"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendRequestWithJsonAsync<T>(IFlurlRequest flurlRequest, object? data = null, CancellationToken cancellationToken = default)
            where T : UpyunConsoleResponse, new()
        {
            if (flurlRequest == null) throw new ArgumentNullException(nameof(flurlRequest));

            try
            {
                bool isConsolepleRequest = data == null ||
                    flurlRequest.Verb == HttpMethod.Get ||
                    flurlRequest.Verb == HttpMethod.Head ||
                    flurlRequest.Verb == HttpMethod.Options;
                using IFlurlResponse flurlResponse = isConsolepleRequest ?
                    await base.SendRequestAsync(flurlRequest, null, cancellationToken) :
                    await base.SendRequestWithJsonAsync(flurlRequest, data, cancellationToken);
                return await WrapResponseWithJsonAsync<T>(flurlResponse, cancellationToken);
            }
            catch (FlurlHttpException ex)
            {
                throw new UpyunConsoleException(ex.Message, ex);
            }
        }
    }
}
