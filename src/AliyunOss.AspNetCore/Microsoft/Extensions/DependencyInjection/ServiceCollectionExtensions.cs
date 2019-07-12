using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Aliyun.OSS;
using Aliyun.OSS.Common;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAliyunOssClient(this IServiceCollection services, Action<OssClientOptions> configureOptions)
        {
            services.AddAliyunOssClient(configureOptions, config => new ClientConfiguration { });

            return services;
        }

        public static IServiceCollection AddAliyunOssClient(this IServiceCollection services, Action<OssClientOptions> configureOptions, Action<ClientConfiguration> configreClientConfiguration)
        {
            var options = new OssClientOptions { };
            var config = new ClientConfiguration { };

            configureOptions?.Invoke(options);
            configreClientConfiguration?.Invoke(config);

            services.AddSingleton<IOss>(sp => new OssClient(options.Endpoint, options.AppKeyId, options.AppKeySecret, config));

            return services;
        }
    }
}
