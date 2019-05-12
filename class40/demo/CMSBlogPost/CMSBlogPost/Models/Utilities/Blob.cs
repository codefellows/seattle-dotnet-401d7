using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSBlogPost.Models.Utilities
{
    public class Blob
    {
        public CloudStorageAccount CloudStorage { get; set; }
        public CloudBlobClient CloudBlob { get; set; }

        public Blob(IConfiguration configuration)
        {
            CloudStorage = CloudStorageAccount.Parse(configuration["AzureBlobConnString"]);
            // Needs to be chained from value from above.
            CloudBlob = CloudStorage.CreateCloudBlobClient();
        }

        public async Task<CloudBlobContainer> GetContainer(string containerName)
        {
            CloudBlobContainer cbc = CloudBlob.GetContainerReference(containerName);
            await cbc.CreateIfNotExistsAsync();
            await cbc.SetPermissionsAsync(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });

            return cbc;
        }

        public async Task<CloudBlob> GetBlob(string imageName, string containerName)
        {
            CloudBlobContainer container = await GetContainer(containerName);
            CloudBlob blob = container.GetBlobReference(imageName);
            return blob;
        }

        public void UploadFile(CloudBlobContainer container, string filename, string filePath)
        {
            CloudBlockBlob blobFile = container.GetBlockBlobReference(filename);
            blobFile.UploadFromFileAsync(filePath);
        }




    }
}
