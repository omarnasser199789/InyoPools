using InyoPools.Core.Domain.Model;
using InyoPools.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace InyoPoolsRest.API.Application.Categories
{


    public interface IDeleteCategoryService
    {
        Task<DeleteCategory.Response> DeleteCategory(DeleteCategory.Request request);
    }

    public class DeleteCategoryService : IDeleteCategoryService
    {
        private readonly InyoPoolsDbContext _inyoPoolsDbContext;


        public DeleteCategoryService(InyoPoolsDbContext inyoPoolsDbContext)
        {
            _inyoPoolsDbContext = inyoPoolsDbContext;
        }
        public async Task<DeleteCategory.Response> DeleteCategory(DeleteCategory.Request request)
        {
            // Retrieve the category to be deleted
            var category = await _inyoPoolsDbContext.Categories.FindAsync(request.Id);


            if (category == null)
            {
                return new DeleteCategory.Response
                {
                    Status = "Error",
                    Message = $"Category with ID {request.Id} not found"
                };
            }

            //Delete the category
            _inyoPoolsDbContext.Categories.Remove(category);
            await _inyoPoolsDbContext.SaveChangesAsync();

            return new DeleteCategory.Response
            {
                Status = "Success",
                Message = $"Category with ID {request.Id} deleted successfully"
            };
        }
    }
}
