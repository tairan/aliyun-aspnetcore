using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Aliyun.OSS
{
    public static class IOssClientExtensions
    {
        public static Task<AppendObjectResult> AppendObjectAsync(this IOss client, AppendObjectRequest request)
        {
            return Task.Factory.FromAsync(client.BeginAppendObject, client.EndAppendObject, request, null);
        }

        public static Task<CopyObjectResult> CopyObjectAsync(this IOss client, CopyObjectRequest request)
        {
            return Task.Factory.FromAsync(client.BeginCopyObject, client.EndCopyResult, request, null);
        }

        public static Task<OssObject> GetObjectAsync(this IOss client, string bucketName, string key)
        {
            return Task.Factory.FromAsync(client.BeginGetObject, client.EndGetObject, bucketName, key, null);
        }

        public static Task<ObjectListing> ListObjectsAsync(this IOss client, string bucketName)
        {
            return Task.Factory.FromAsync(client.BeginListObjects, client.EndListObjects, bucketName, null);
        }

        public static Task<PutObjectResult> PutObjectAsync(this IOss client, string bucketName, string key, Stream stream)
        {
            return Task.Factory.FromAsync(client.BeginPutObject, client.EndPutObject, bucketName, key, stream, null);
        }

        public static Task<UploadPartResult> UploadPartAsync(this IOss client, UploadPartRequest request)
        {
            return Task.Factory.FromAsync(client.BeginUploadPart, client.EndUploadPart, request, null);
        }

        public static Task<UploadPartCopyResult> UploadPartCopyAsync(this IOss client, UploadPartCopyRequest request)
        {
            return Task.Factory.FromAsync(client.BeginUploadPartCopy, client.EndUploadPartCopy, request, null);
        }
    }
}
