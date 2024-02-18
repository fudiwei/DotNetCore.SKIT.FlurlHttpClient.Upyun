using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.Upyun.Sms
{
    /// <summary>
    /// 用于构造 <see cref="UpyunSmsClient"/> 实例的构造器。
    /// </summary>
    public partial class UpyunSmsClientBuilder : ICommonClientBuilder<UpyunSmsClient>
    {
        private readonly UpyunSmsClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private UpyunSmsClientBuilder(UpyunSmsClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<UpyunSmsClient> ICommonClientBuilder<UpyunSmsClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<UpyunSmsClient> ICommonClientBuilder<UpyunSmsClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<UpyunSmsClient> ICommonClientBuilder<UpyunSmsClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public UpyunSmsClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public UpyunSmsClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public UpyunSmsClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public UpyunSmsClient Build()
        {
            UpyunSmsClient client = _disposeClient.HasValue
                ? new UpyunSmsClient(_options, _httpClient, _disposeClient.Value)
                : new UpyunSmsClient(_options, _httpClient);

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

    partial class UpyunSmsClientBuilder
    {
        public static UpyunSmsClientBuilder Create(UpyunSmsClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new UpyunSmsClientBuilder(options);
        }
    }
}
