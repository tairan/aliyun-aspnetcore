using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Aliyun.OSS.Model;

namespace Aliyun.OSS
{
    public static class IOssClientExtensions
    {
        public static Task<Bucket> CreateBucketAsync(this IOss client, string bucketName, StorageClass storageClass)
        {
            return Task.Factory.StartNew(() => client.CreateBucket(bucketName, storageClass));
        }

        public static Task<Bucket> CreateBucketAsync(this IOss client, string bucketName)
        {
            return Task.Factory.StartNew(() => client.CreateBucket(bucketName));
        }

        public static Task DeleteBucketAsync(this IOss client, string bucketName)
        {
            return Task.Factory.StartNew(() => client.DeleteBucket(bucketName));
        }

        public static Task<IEnumerable<Bucket>> ListBucketsAsync(this IOss client)
        {
            return Task.Factory.StartNew(() => client.ListBuckets());
        }

        public static Task<ListBucketsResult> ListBucketsAsync(this IOss client, ListBucketsRequest listBucketsRequest)
        {
            return Task.Factory.StartNew(() => client.ListBuckets(listBucketsRequest));
        }

        public static Task<BucketInfo> GetBucketInfoAsync(this IOss client, string bucketName)
        {
            return Task.Factory.StartNew(() => client.GetBucketInfo(bucketName));
        }

        public static Task<BucketStat> GetBucketStatAsync(this IOss client, string bucketName)
        {
            return Task.Factory.StartNew(() => client.GetBucketStat(bucketName));
        }

        public static Task SetBucketAclAsync(this IOss client, string bucketName, CannedAccessControlList acl)
        {
            return Task.Factory.StartNew(() => client.SetBucketAcl(bucketName, acl));
        }

        public static Task SetBucketAclAsync(this IOss client, SetBucketAclRequest setBucketAclRequest)
        {
            return Task.Factory.StartNew(() => client.SetBucketAcl(setBucketAclRequest));
        }

        public static Task<AccessControlList> GetBucketAclAsync(this IOss client, string bucketName)
        {
            return Task.Factory.StartNew(() => client.GetBucketAcl(bucketName));
        }

        public static Task<BucketLocationResult> GetBucketLocationAsync(this IOss client, string bucketName)
        {
            return Task.Factory.StartNew(() => client.GetBucketLocation(bucketName));
        }

        public static Task<BucketMetadata> GetBucketMetadataAsync(this IOss client, string bucketName)
        {
            return Task.Factory.StartNew(() => client.GetBucketMetadata(bucketName));
        }

        public static Task SetBucketCorsAsync(this IOss client, SetBucketCorsRequest setBucketCorsRequest)
        {
            return Task.Factory.StartNew(() => client.SetBucketCors(setBucketCorsRequest));
        }

        public static Task<IList<CORSRule>> GetBucketCorsAsync(this IOss client, string bucketName)
        {
            return Task.Factory.StartNew(() => client.GetBucketCors(bucketName));
        }

        public static Task DeleteBucketCorsAsync(this IOss client, string bucketName)
        {
            return Task.Factory.StartNew(() => client.DeleteBucketCors(bucketName));
        }

        public static Task SetBucketLoggingAsync(this IOss client, SetBucketLoggingRequest setBucketLoggingRequest)
        {
            return Task.Factory.StartNew(() => client.SetBucketLogging(setBucketLoggingRequest));
        }

        public static Task<BucketLoggingResult> GetBucketLoggingAsync(this IOss client, string bucketName)
        {
            return Task.Factory.StartNew(() => client.GetBucketLogging(bucketName));
        }

        public static Task DeleteBucketLoggingAsync(this IOss client, string bucketName)
        {
            return Task.Factory.StartNew(() => client.DeleteBucketLogging(bucketName));
        }

        public static Task SetBucketWebsiteAsync(this IOss client, SetBucketWebsiteRequest setBucketWebSiteRequest)
        {
            return Task.Factory.StartNew(() => client.SetBucketWebsite(setBucketWebSiteRequest));
        }

        public static Task<BucketWebsiteResult> GetBucketWebsiteAsync(this IOss client, string bucketName)
        {
            return Task.Factory.StartNew(() => client.GetBucketWebsite(bucketName));
        }

        public static Task DeleteBucketWebsiteAsync(this IOss client, string bucketName)
        {
            return Task.Factory.StartNew(() => client.DeleteBucketWebsite(bucketName));
        }

        public static Task SetBucketRefererAsync(this IOss client, SetBucketRefererRequest setBucketRefererRequest)
        {
            return Task.Factory.StartNew(() => client.SetBucketReferer(setBucketRefererRequest));
        }

        public static Task<RefererConfiguration> GetBucketRefererAsync(this IOss client, string bucketName)
        {
            return Task.Factory.StartNew(() => client.GetBucketReferer(bucketName));
        }

        public static Task SetBucketLifecycleAsync(this IOss client, SetBucketLifecycleRequest setBucketLifecycleRequest)
        {
            return Task.Factory.StartNew(() => client.SetBucketLifecycle(setBucketLifecycleRequest));
        }

        public static Task DeleteBucketLifecycleAsync(this IOss client, string bucketName)
        {
            return Task.Factory.StartNew(() => client.DeleteBucketLifecycle(bucketName));
        }

        public static Task<IList<LifecycleRule>> GetBucketLifecycleAsync(this IOss client, string bucketName)
        {
            return Task.Factory.StartNew(() => client.GetBucketLifecycle(bucketName));
        }

        public static Task SetBucketStorageCapacityAsync(this IOss client, SetBucketStorageCapacityRequest setBucketStorageCapacityRequest)
        {
            return Task.Factory.StartNew(() => client.SetBucketStorageCapacity(setBucketStorageCapacityRequest));
        }

        public static Task<GetBucketStorageCapacityResult> GetBucketStorageCapacityAsync(this IOss client, string bucketName)
        {
            return Task.Factory.StartNew(() => client.GetBucketStorageCapacity(bucketName));
        }

        public static Task<bool> DoesBucketExistAsync(this IOss client, string bucketName)
        {
            return Task.Factory.StartNew(() => client.DoesBucketExist(bucketName));
        }

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

        public static Task CreateSymlinkAsync(this IOss client, string bucketName, string symlink, string target)
        {
            return Task.Factory.StartNew(() => client.CreateSymlink(bucketName, symlink, target));
        }

        public static Task CreateSymlinkAsync(this IOss client, CreateSymlinkRequest createSymlinkRequest)
        {
            return Task.Factory.StartNew(() => client.CreateSymlink(createSymlinkRequest));
        }

        public static Task<OssSymlink> GetSymlinkAsync(this IOss client, string bucketName, string symlink)
        {
            return Task.Factory.StartNew(() => client.GetSymlink(bucketName, symlink));
        }

        public static Task ModifyObjectMetaAsync(this IOss client, string bucketName, string key, ObjectMetadata newMeta, long? partSize = default(long?), string checkpointDir = null)
        {
            return Task.Factory.StartNew(() => client.ModifyObjectMeta(bucketName, key, newMeta, partSize, checkpointDir));
        }

        public static Task<bool> DoesObjectExistAsync(this IOss client, string bucketName, string key)
        {
            return Task.Factory.StartNew(() => client.DoesObjectExist(bucketName, key));
        }

        public static Task SetObjectAclAsync(this IOss client, string bucketName, string key, CannedAccessControlList acl)
        {
            return Task.Factory.StartNew(() => client.SetObjectAcl(bucketName, key, acl));
        }

        public static Task SetObjectAclAsync(this IOss client, SetObjectAclRequest setObjectAclRequest)
        {
            return Task.Factory.StartNew(() => client.SetObjectAcl(setObjectAclRequest));
        }

        public static Task<AccessControlList> GetObjectAclAsync(this IOss client, string bucketName, string key)
        {
            return Task.Factory.StartNew(() => client.GetObjectAcl(bucketName, key));
        }

        public static Task<RestoreObjectResult> RestoreObjectAsync(this IOss client, string bucketName, string key)
        {
            return Task.Factory.StartNew(() => client.RestoreObject(bucketName, key));
        }

        public static Task<Uri> GeneratePresignedUriAsync(this IOss client, string bucketName, string key)
        {
            return Task.Factory.StartNew(() => client.GeneratePresignedUri(bucketName, key));
        }

        public static Task<Uri> GeneratePresignedUriAsync(this IOss client, GeneratePresignedUriRequest generatePresignedUriRequest)
        {
            return Task.Factory.StartNew(() => client.GeneratePresignedUri(generatePresignedUriRequest));
        }

        public static Task<Uri> GeneratePresignedUriAsync(this IOss client, string bucketName, string key, DateTime expiration)
        {
            return Task.Factory.StartNew(() => client.GeneratePresignedUri(bucketName, key, expiration));
        }

        public static Task<Uri> GeneratePresignedUriAsync(this IOss client, string bucketName, string key, SignHttpMethod method)
        {
            return Task.Factory.StartNew(() => client.GeneratePresignedUri(bucketName, key, method));
        }

        public static Task<Uri> GeneratePresignedUriAsync(this IOss client, string bucketName, string key, DateTime expiration, SignHttpMethod method)
        {
            return Task.Factory.StartNew(() => client.GeneratePresignedUri(bucketName, key, expiration, method));
        }

        public static Task<string> GeneratePostPolicyAsync(this IOss client, DateTime expiration, PolicyConditions conds)
        {
            return Task.Factory.StartNew(() => client.GeneratePostPolicy(expiration, conds));
        }

        public static Task<MultipartUploadListing> ListMultipartUploadsAsync(this IOss client, ListMultipartUploadsRequest listMultipartUploadsRequest)
        {
            return Task.Factory.StartNew(() => client.ListMultipartUploads(listMultipartUploadsRequest));
        }

        public static Task<InitiateMultipartUploadResult> InitiateMultipartUploadAsync(this IOss client, InitiateMultipartUploadRequest initiateMultipartUploadRequest)
        {
            return Task.Factory.StartNew(() => client.InitiateMultipartUpload(initiateMultipartUploadRequest));
        }

        public static Task AbortMultipartUploadAsync(this IOss client, AbortMultipartUploadRequest abortMultipartUploadRequest)
        {
            return Task.Factory.StartNew(() => client.AbortMultipartUpload(abortMultipartUploadRequest));
        }

        public static Task ListPartsAsync(this IOss client, ListPartsRequest listPartsRequest)
        {
            return Task.Factory.StartNew(() => client.ListParts(listPartsRequest));
        }

        public static Task CompleteMultipartUploadAsync(this IOss client, CompleteMultipartUploadRequest completeMultipartUploadRequest)
        {
            return Task.Factory.StartNew(() => client.CompleteMultipartUpload(completeMultipartUploadRequest));
        }
    }
}
