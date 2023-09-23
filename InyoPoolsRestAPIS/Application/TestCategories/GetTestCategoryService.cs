


using InyoPools.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace InyoPoolsRest.API.Application.TestCategories
{



    public interface IGetTestCategoryService {

        Task<List<GetTestCategory.Response>> GetTestCategories(GetTestCategory.Request request);

    }
    public class GetTestCategoryService : IGetTestCategoryService
    {


        private readonly InyoPoolsDbContext _inyoPoolsDbContext;

        public GetTestCategoryService(InyoPoolsDbContext inyoPoolsDbContext) {
            _inyoPoolsDbContext = inyoPoolsDbContext;
        }

        public async Task<List<GetTestCategory.Response>> GetTestCategories(GetTestCategory.Request request)
        {
            return await _inyoPoolsDbContext.TestCategories.Select(g => new GetTestCategory.Response()
            {
                testCategory = g
            }).ToListAsync();
        }
    }
}
