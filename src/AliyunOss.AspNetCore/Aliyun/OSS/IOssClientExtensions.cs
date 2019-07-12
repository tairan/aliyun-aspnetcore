using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Aliyun.OSS
{
    public static class IOssClientExtensions
    {
        public static Task<OssObject> GetObjectAsync(this IOss client, string bucketName, string key)
        {
            return Task.Factory.FromAsync(client.BeginGetObject, client.EndGetObject, bucketName, key, null);
        }

        public static Task<AppendObjectResult> AppendObjectAsync(this IOss client, AppendObjectRequest request)
        {
            return Task.Factory.FromAsync(client.BeginAppendObject, client.EndAppendObject, request, null);
        }
    }
}
