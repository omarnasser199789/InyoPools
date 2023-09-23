using InyoPools.Infrastructure;
using static InyoPoolsRest.API.Application.Customers.GetCustomers;
using Microsoft.EntityFrameworkCore;
namespace InyoPoolsRest.API.Application.Customers
{


    public interface IGetCustomersService{

        Task<List<Response>> GetCustomers(Request request);
    }


    public class GetCustomersService: IGetCustomersService
    {
        private readonly InyoPoolsDbContext _inyoPoolsDbContext;

        public GetCustomersService(InyoPoolsDbContext inyoPoolsDbContext) {
            _inyoPoolsDbContext = inyoPoolsDbContext;
        }

        public async Task<List<Response>> GetCustomers(Request request)
        {
            return await _inyoPoolsDbContext.Customers.Select(g => new Response()
            {
                Customer = g
            }).ToListAsync();
        }
    }
}
