


using Azure.Storage.Blobs;
using InyoPools.Core.Domain.Model;
using InyoPools.Infrastructure;


namespace InyoPoolsRest.API.Application.Categories
{
    public interface IAddCategoryService
    {
        Task<AddCategory.Response> AddCategory(AddCategory.Request request);
    }



    public class AddCategoryservice : IAddCategoryService
    {
        private readonly InyoPoolsDbContext _inyoPoolsDbContext;


        public AddCategoryservice(InyoPoolsDbContext inyoPoolsDbContext)
        {
            _inyoPoolsDbContext = inyoPoolsDbContext;
        }
                    

        public async Task<AddCategory.Response> AddCategory(AddCategory.Request request)
        {

            try
            {



                string filePath = await uploadFile(request.Image);
                



                var category = new Category {
                    IsActive =request.IsActive,
                    PerentLevel = request.PerentLevel,
                    Name = request.Name,
                    PerentId = request.PerentId,
                    Description = request.Description,
                    ImagePath = filePath,
                };

                await _inyoPoolsDbContext.Categories.AddAsync(category);

                await _inyoPoolsDbContext.SaveChangesAsync();

                // If the category was added successfully, return a success response.
                var response = new AddCategory.Response { Status = "Success", Message = "Category added successfully." };
                return response;
            }
            catch (Exception ex)
            {
                // If an error occurred, return an error response.
                var response = new AddCategory.Response { Status = "Error", Message = ex.Message };
                return response;
            }
        }





        private async Task<string> uploadFile(IFormFile file)
        {

            // Get the stream of the uploaded file
            using var stream = file.OpenReadStream();

            // Save the contents of the file to a byte array
            var memoryStream = new MemoryStream();
            await stream.CopyToAsync(memoryStream);
            var fileBytes = memoryStream.ToArray();

            // Create a new MemoryStream from the byte array
            var content = new MemoryStream(fileBytes);

            string connectionString = "DefaultEndpointsProtocol=https;AccountName=blobcontainertesttest;AccountKey=Nf8AGvNlI2L2s00vc2KYrDq/upuAI9yi+EVoazfTdvyEUixdOIesdvOPX1d8xO40F8GvMefkW4FD+AStrYqk3w==;EndpointSuffix=core.windows.net";
            string containerName = "democontainertest";
            var fileName = Path.GetFileName(file.FileName);

            var containerClient = new BlobContainerClient(connectionString, containerName);
            DateTime now = DateTime.Now;
            string formattedDate = now.ToString("yyyy-MM-dd HH:mm:ss");

            await containerClient.UploadBlobAsync(formattedDate+fileName, content);

            return "https://blobcontainertesttest.blob.core.windows.net/" + containerName +"/"+formattedDate+fileName;
           
        }
    }


}
