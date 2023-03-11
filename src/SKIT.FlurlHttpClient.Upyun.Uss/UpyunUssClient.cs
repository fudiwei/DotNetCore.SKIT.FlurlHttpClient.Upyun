using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Upyun.Uss
{
    /// <summary>
    /// 一个又拍云云存储服务 API HTTP 客户端。
    /// </summary>
    public class UpyunUssClient : CommonClientBase, ICommonClient
    {
        /// <summary>
        /// 获取当前客户端使用的又拍云云存储服务凭证。
        /// </summary>
        public Settings.Credentials Credentials { get; }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="UpyunUssClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public UpyunUssClient(UpyunUssClientOptions options)
            : base()
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            Credentials = new Settings.Credentials(options);

            FlurlClient.BaseUrl = options.Endpoint ?? UpyunUssEndpoints.DEFAULT;
            FlurlClient.WithTimeout(TimeSpan.FromMilliseconds(options.Timeout));

            Interceptors.Add(new Interceptors.UpyunUssRequestSignatureInterceptor(scheme: options.AuthType, username: options.OperatorName, password: options.OperatorPassword));
        }

        /// <summary>
        /// 用指定的又拍云云存储服务 API Token 初始化 <see cref="UpyunUssClient"/> 类的新实例。
        /// </summary>
        /// <param name="token">又拍云云存储服务 API Token。</param>
        public UpyunUssClient(string token)
            : this(new UpyunUssClientOptions() { OperatorName = token })
        {
        }

        /// <summary>
        /// 使用当前客户端生成一个新的 <see cref="IFlurlRequest"/> 对象。
        /// </summary>
        /// <param name="request"></param>
        /// <param name="method"></param>
        /// <param name="urlSegments"></param>
        /// <returns></returns>
        public IFlurlRequest CreateRequest(UpyunUssRequest request, HttpMethod method, params object[] urlSegments)
        {
            IFlurlRequest flurlRequest = FlurlClient.Request(urlSegments).WithVerb(method);

            if (request.Timeout != null)
            {
                flurlRequest.WithTimeout(TimeSpan.FromMilliseconds(request.Timeout.Value));
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
            where T : UpyunUssResponse, new()
        {
            if (flurlRequest == null) throw new ArgumentNullException(nameof(flurlRequest));

            try
            {
                using IFlurlResponse flurlResponse = await base.SendRequestAsync(flurlRequest, httpContent, cancellationToken);
                return await WrapResponseWithJsonAsync<T>(flurlResponse, cancellationToken);
            }
            catch (FlurlHttpException ex)
            {
                throw new UpyunUssException(ex.Message, ex);
            }
        }
    }
}
