using InyoPools.Core.Domain.Model;
using InyoPools.Infrastructure;
using InyoPoolsRest.API.Application.Categories;

namespace InyoPoolsRest.API.Application.EmailLogs
{



    public interface IAddEmailLogService
    {

        Task<AddEmailLog.Response> AddEmailLog(AddEmailLog.Request request);
    }

    public class AddEmailLogService : IAddEmailLogService
    {
        private readonly InyoPoolsDbContext _inyoPoolsDbContext;


        public AddEmailLogService(InyoPoolsDbContext inyoPoolsDbContext)
        {
            _inyoPoolsDbContext = inyoPoolsDbContext;
        }

        public async Task<AddEmailLog.Response> AddEmailLog(AddEmailLog.Request request)
        {

            try
            {








                var emailLog = new EmailLog
                {

                    EmailTo = request.EmailTo,
                    EmailFrom = request.EmailFrom,
                    EmailSubject = request.EmailSubject,
                    UserID = request.UserID,
                    DateSent = request.DateSent,
                    EmailTransactionTypeID = request.EmailTransactionTypeID,
                    EmailBody = request.EmailBody,
                    EmailBcc = request.EmailBcc,
                    EmployeeId = request.EmployeeId,
                    QuoteId = request.QuoteId,
                    OriginalEmailLogId = request.OriginalEmailLogId,

                };

                await _inyoPoolsDbContext.emailLogs.AddAsync(emailLog);

                await _inyoPoolsDbContext.SaveChangesAsync();

                // If the EmailLog was added successfully, return a success response.
                var response = new AddEmailLog.Response { Status = "Success", Message = "EmailLog added successfully." };
                return response;
            }
            catch (Exception ex)
            {
                // If an error occurred, return an error response.
                var response = new AddEmailLog.Response { Status = "Error", Message = ex.Message };
                return response;
            }
        }
    }
}
