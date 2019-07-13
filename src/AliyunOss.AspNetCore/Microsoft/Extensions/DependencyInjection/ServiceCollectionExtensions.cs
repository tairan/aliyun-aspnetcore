using System;
using System.Collections.Generic;
using System.Text;
using Aliyun.OSS;
using Aliyun.OSS.Common;
using Microsoft.Extensions.DependencyInjection.Extensions;

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

            services.TryAddSingleton<IOss>(sp => new OssClient(options.Endpoint, options.AppKeyId, options.AppKeySecret, config));

            return services;
        }
    }
}
