using InyoPools.Infrastructure;
using InyoPoolsRest.API.Application.Categories;

namespace InyoPoolsRest.API.Application.Manufacturers
{


    public interface IDeleteManufacturerService{
        Task<DeleteManufacturer.Response> DeleteCategory(DeleteManufacturer.Request request);

    }

    public class DeleteManufacturerService: IDeleteManufacturerService
    {
        private readonly InyoPoolsDbContext _inyoPoolsDbContext;

        public DeleteManufacturerService(InyoPoolsDbContext inyoPoolsDbContext) {
            _inyoPoolsDbContext = inyoPoolsDbContext;
        }

        public async Task<DeleteManufacturer.Response> DeleteCategory(DeleteManufacturer.Request request)
        {
            // Retrieve the manufacturer to be deleted
            var category = await _inyoPoolsDbContext.Manufacturers.FindAsync(request.Id);


            if (category == null)
            {
                return new DeleteManufacturer.Response
                {
                    Status = "Error",
                    Message = $"Manufacturer with ID {request.Id} not found"
                };
            }

            //Delete the category
            _inyoPoolsDbContext.Manufacturers.Remove(category);
            await _inyoPoolsDbContext.SaveChangesAsync();

            return new DeleteManufacturer.Response
            {
                Status = "Success",
                Message = $"Manufacturer with ID {request.Id} deleted successfully"
            };
        }
    }
}
