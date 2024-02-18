using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.Upyun.Sim
{
    /// <summary>
    /// 用于构造 <see cref="UpyunSimClient"/> 实例的构造器。
    /// </summary>
    public partial class UpyunSimClientBuilder : ICommonClientBuilder<UpyunSimClient>
    {
        private readonly UpyunSimClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private UpyunSimClientBuilder(UpyunSimClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<UpyunSimClient> ICommonClientBuilder<UpyunSimClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<UpyunSimClient> ICommonClientBuilder<UpyunSimClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<UpyunSimClient> ICommonClientBuilder<UpyunSimClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public UpyunSimClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public UpyunSimClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public UpyunSimClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public UpyunSimClient Build()
        {
            UpyunSimClient client = _disposeClient.HasValue
                ? new UpyunSimClient(_options, _httpClient, _disposeClient.Value)
                : new UpyunSimClient(_options, _httpClient);

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

    partial class UpyunSimClientBuilder
    {
        public static UpyunSimClientBuilder Create(UpyunSimClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new UpyunSimClientBuilder(options);
        }
    }
}
