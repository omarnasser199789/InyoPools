using InyoPools.Infrastructure;
using Microsoft.EntityFrameworkCore;
using static InyoPoolsRest.API.Application.Categories.GetCategory;

namespace InyoPoolsRest.API.Application.Categories
{


    public interface IGetCategoryService {


        Task<List<Response>> GetCategories(Request request);
    
    
    }
    public class GetCategoryService : IGetCategoryService   
    {

        private readonly InyoPoolsDbContext _inyoPoolsDbContext;   

        public GetCategoryService(InyoPoolsDbContext inyoPoolsDbContext)
        {
            _inyoPoolsDbContext = inyoPoolsDbContext;
        }

        public async Task<List<Response>> GetCategories(Request request)
        {
            return await _inyoPoolsDbContext.Categories.Select(g => new Response()
            {
                Category = g
            }).ToListAsync();
        }
    }
}
