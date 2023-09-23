using InyoPools.Core.Domain.Model;
using InyoPools.Infrastructure;
using InyoPoolsRest.API.Application.Categories;

namespace InyoPoolsRest.API.Application.Manufacturers
{

    public interface IAddManufacturerService {
        Task<AddManufacturer.Response> AddManufacturer(AddManufacturer.Request request);
    }
    public class AddManufacturerService : IAddManufacturerService
    {
        private readonly InyoPoolsDbContext _inyoPoolsDbContext;

        public AddManufacturerService(InyoPoolsDbContext inyoPoolsDbContext) { 
        
            _inyoPoolsDbContext = inyoPoolsDbContext;
        }

        public async Task<AddManufacturer.Response> AddManufacturer(AddManufacturer.Request request)
        {
            try
            {


                var manufacturer = new Manufacturer
                {
                   
                    Name = request.Name,
                    Description = request.Description,
                    URL = request.URL,
                    NoPublicDisplayOfMfg = request.NoPublicDisplayOfMfg,
                    NoDisplayPopularItems = request.NoDisplayPopularItems,
                    NoDisplayToVendors = request.NoDisplayToVendors,
                    AbbrDisplayName = request.AbbrDisplayName,
                    
                };

                await _inyoPoolsDbContext.Manufacturers.AddAsync(manufacturer);

                await _inyoPoolsDbContext.SaveChangesAsync();

                // If the Manufacturer was added successfully, return a success response.
                var response = new AddManufacturer.Response { Status = "Success", Message = "Category added successfully." };
                return response;
            }
            catch (Exception ex)
            {
                // If an error occurred, return an error response.
                var response = new AddManufacturer.Response { Status = "Error", Message = ex.Message };
                return response;
            }
        }
    }
}
