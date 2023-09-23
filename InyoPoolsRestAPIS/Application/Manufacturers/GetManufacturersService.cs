using InyoPools.Infrastructure;
using Microsoft.EntityFrameworkCore;
using static InyoPoolsRest.API.Application.Manufacturers.GetManufacturers;

namespace InyoPoolsRest.API.Application.Manufacturers
{

    public interface IGetManufacturersService {

        Task<List<Response>> GetManufacturers(Request request);

    }
    public class GetManufacturersService : IGetManufacturersService
    {
        private readonly InyoPoolsDbContext _inyoPoolsDbContext;



        public GetManufacturersService(InyoPoolsDbContext inyoPoolsDbContext ) {
        
            _inyoPoolsDbContext = inyoPoolsDbContext;
        }


        public async Task<List<Response>> GetManufacturers(Request request)
        {
            return await _inyoPoolsDbContext.Manufacturers.Select(g => new Response()
            {
                Manufacturer = g
            }).ToListAsync();
        }
    }
}
