using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Aliyun.OSS;


namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAliyunOssClient(this IServiceCollection services, Action<OssClientOptions> configureOptions)
        {
            var options = new OssClientOptions { };

            configureOptions?.Invoke(options);
            
            services.AddSingleton<IOss>(sp => new OssClient(options.Endpoint, options.AppKeyId, options.AppKeySecret));
            
            return services;
        }
    }
}
