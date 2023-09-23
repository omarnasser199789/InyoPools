using InyoPools.Core.Domain.Model;
using InyoPools.Infrastructure;
using InyoPoolsRest.API.Application.EmailLogs;

namespace InyoPoolsRest.API.Application.EmailTypes
{


    public interface IAddEmailTypeService
    {

        Task<AddEmailType.Response> AddEmailType(AddEmailType.Request request);

    }

    public class AddEmailTypeService : IAddEmailTypeService
    {

        private readonly InyoPoolsDbContext _inyoPoolsDbContext;

      public  AddEmailTypeService(InyoPoolsDbContext inyoPoolsDbContext)
        {
            _inyoPoolsDbContext = inyoPoolsDbContext;

        }

        public async Task<AddEmailType.Response> AddEmailType(AddEmailType.Request request)
        {

            try
            {
                var emailType = new EmailType
                {


                    Description = request.Description,
                    EmailTo = request.EmailTo,
                    EmailFrom = request.EmailFrom,
                    EmailBcc = request.EmailBcc,
                    EmailSubject = request.EmailSubject,
                    EmailBody = request.EmailBody,
                    EmailTransactionTypeID = request.EmailTransactionTypeID,
                    DelaySendMinutes = request.DelaySendMinutes,
                    UseNewTemplate = request.UseNewTemplate,

                };

                await _inyoPoolsDbContext.EmailTypes.AddAsync(emailType);

                await _inyoPoolsDbContext.SaveChangesAsync();

                // If the EmailType was added successfully, return a success response.
                var response = new AddEmailType.Response { Status = "Success", Message = "EmailType added successfully." };
                return response;
            }
            catch (Exception ex)
            {
                // If an error occurred, return an error response.
                var response = new AddEmailType.Response { Status = "Error", Message = ex.Message };
                return response;
            }
        }
    }
}
