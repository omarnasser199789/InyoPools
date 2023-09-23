using InyoPools.Infrastructure;
using static InyoPoolsRest.API.Application.ProductCategories.GetProductCategory;
using Microsoft.EntityFrameworkCore;
namespace InyoPoolsRest.API.Application.ProductCategories
{


    public interface IGetProductCategoryService {


        Task<List<Response>> GetProductCategories(Request request);

    }

    public class GetProductCategoryService : IGetProductCategoryService
    {
        private readonly InyoPoolsDbContext _inyoPoolsDbContext;

        public GetProductCategoryService(InyoPoolsDbContext inyoPoolsDbContext) {
        
        _inyoPoolsDbContext = inyoPoolsDbContext;

        }




        public async Task<List<Response>> GetProductCategories(Request request)
        {
            return await _inyoPoolsDbContext.ProductCategories.Select(g => new Response()
            {
                ProductCategory = g
            }).ToListAsync();
        }




    }
}
