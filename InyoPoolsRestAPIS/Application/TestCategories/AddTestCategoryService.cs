using InyoPools.Core.Domain.Model;
using InyoPools.Infrastructure;
using InyoPoolsRest.API.Application.Categories;
using InyoPoolsRest.API.Application.ProductCategories;

namespace InyoPoolsRest.API.Application.TestCategories
{


    public interface IAddTestCategoryService {

        Task<AddTestCategory.Response> AddTestCategory(AddTestCategory.Request request);
    }

    public class AddTestCategoryService : IAddTestCategoryService
    {



        private readonly InyoPoolsDbContext _inyoPoolsDbContext;


      
        public AddTestCategoryService(InyoPoolsDbContext inyoPoolsDbContext) {
            _inyoPoolsDbContext = inyoPoolsDbContext;   
        }

        public async Task<AddTestCategory.Response> AddTestCategory(AddTestCategory.Request request)
        {
            try
            {

                var category = new TestCategory
                {
                  
                    Name = request.Name,
                    ParentID = request.ParentId,    
                  
                };

                await _inyoPoolsDbContext.TestCategories.AddAsync(category);

                await _inyoPoolsDbContext.SaveChangesAsync();

                // If the category was added successfully, return a success response.
                var response = new AddTestCategory.Response { Status = "Success", Message = "Category added successfully." };
                return response;
            }
            catch (Exception ex)
            {
                // If an error occurred, return an error response.
                var response = new AddTestCategory.Response { Status = "Error", Message = ex.Message };
                return response;
            }
        }
    }
}
