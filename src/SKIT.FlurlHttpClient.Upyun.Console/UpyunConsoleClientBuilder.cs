using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.Upyun.Console
{
    /// <summary>
    /// 用于构造 <see cref="UpyunConsoleClient"/> 实例的构造器。
    /// </summary>
    public partial class UpyunConsoleClientBuilder : ICommonClientBuilder<UpyunConsoleClient>
    {
        private readonly UpyunConsoleClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private UpyunConsoleClientBuilder(UpyunConsoleClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<UpyunConsoleClient> ICommonClientBuilder<UpyunConsoleClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<UpyunConsoleClient> ICommonClientBuilder<UpyunConsoleClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<UpyunConsoleClient> ICommonClientBuilder<UpyunConsoleClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public UpyunConsoleClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public UpyunConsoleClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public UpyunConsoleClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public UpyunConsoleClient Build()
        {
            UpyunConsoleClient client = _disposeClient.HasValue
                ? new UpyunConsoleClient(_options, _httpClient, _disposeClient.Value)
                : new UpyunConsoleClient(_options, _httpClient);

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

    partial class UpyunConsoleClientBuilder
    {
        public static UpyunConsoleClientBuilder Create(UpyunConsoleClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new UpyunConsoleClientBuilder(options);
        }
    }
}
