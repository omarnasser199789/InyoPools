using Microsoft.AspNetCore.Http;
using Azure.Storage.Blobs;
using System;
using System.IO;
using System.Threading.Tasks;

namespace InyoPools.Infrastructure
{
    public static class Utilities
    {
        public static async Task<string> UploadFile(IFormFile file, string containerName)
        {
            // Get the stream of the uploaded file
            using var stream = file.OpenReadStream();

            // Save the contents of the file to a byte array
            using var memoryStream = new MemoryStream();
            await stream.CopyToAsync(memoryStream);
            var fileBytes = memoryStream.ToArray();

            // Create a new MemoryStream from the byte array
            using var content = new MemoryStream(fileBytes);

            string connectionString = "DefaultEndpointsProtocol=https;AccountName=blobcontainertesttest;AccountKey=Nf8AGvNlI2L2s00vc2KYrDq/upuAI9yi+EVoazfTdvyEUixdOIesdvOPX1d8xO40F8GvMefkW4FD+AStrYqk3w==;EndpointSuffix=core.windows.net";
            
            var fileName = Path.GetFileName(file.FileName);

            var containerClient = new BlobContainerClient(connectionString, containerName);
            DateTime now = DateTime.Now;
            string formattedDate = now.ToString("yyyy-MM-dd HH:mm:ss");

            await containerClient.UploadBlobAsync(formattedDate + fileName, content);

            return $"https://blobcontainertesttest.blob.core.windows.net/{containerName}/{formattedDate}{fileName}";
        }
    }
}
