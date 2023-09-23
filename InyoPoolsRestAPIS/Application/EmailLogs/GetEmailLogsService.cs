using InyoPools.Infrastructure;
using static InyoPoolsRest.API.Application.EmailLogs.GetEmailLogs;
using Microsoft.EntityFrameworkCore;

namespace InyoPoolsRest.API.Application.EmailLogs
{



    public interface IGetEmailLogsService {


        Task<List<Response>> GetEmailLogs(Request request);
    }



    public class GetEmailLogsService: IGetEmailLogsService
    {
        private readonly InyoPoolsDbContext _inyoPoolsDbContext;




        public GetEmailLogsService(InyoPoolsDbContext inyoPoolsDbContext) {
            _inyoPoolsDbContext = inyoPoolsDbContext;
        }

        public async Task<List<Response>> GetEmailLogs(Request request)
        {
            return await _inyoPoolsDbContext.emailLogs.Select(g => new Response()
            {
                EmailLog = g
            }).ToListAsync();
        }
    }
}
