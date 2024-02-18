using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.Upyun.Uss
{
    /// <summary>
    /// 用于构造 <see cref="UpyunUssClient"/> 实例的构造器。
    /// </summary>
    public partial class UpyunUssClientBuilder : ICommonClientBuilder<UpyunUssClient>
    {
        private readonly UpyunUssClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private UpyunUssClientBuilder(UpyunUssClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<UpyunUssClient> ICommonClientBuilder<UpyunUssClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<UpyunUssClient> ICommonClientBuilder<UpyunUssClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<UpyunUssClient> ICommonClientBuilder<UpyunUssClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public UpyunUssClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public UpyunUssClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public UpyunUssClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public UpyunUssClient Build()
        {
            UpyunUssClient client = _disposeClient.HasValue
                ? new UpyunUssClient(_options, _httpClient, _disposeClient.Value)
                : new UpyunUssClient(_options, _httpClient);

            foreach (Action<CommonClientSettings> configure in _configures)
            {
                client.Configure(configure);
            }

            foreach (HttpInterceptor interceptor in _interceptors)
            {
                client.Interceptors.Add(interceptor);
            }

            return client;
        }
    }

    partial class UpyunUssClientBuilder
    {
        public static UpyunUssClientBuilder Create(UpyunUssClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new UpyunUssClientBuilder(options);
        }
    }
}
