using InyoPools.Core.Domain.Model;
using InyoPools.Infrastructure;
using InyoPoolsRest.API.Application.Categories;

namespace InyoPoolsRest.API.Application.Customers
{


    public interface IAddCustomerService
    {
        Task<AddCustomer.Response> AddCategory(AddCustomer.Request request);

    }

    public class AddCustomerService : IAddCustomerService
    {
        private readonly InyoPoolsDbContext _inyoPoolsDbContext;
        public AddCustomerService(InyoPoolsDbContext inyoPoolsDbContext)
        {
            _inyoPoolsDbContext = inyoPoolsDbContext;
        }



        public async Task<AddCustomer.Response> AddCategory(AddCustomer.Request request)
        {
            try
            {




                var customer = new Customer
                {


                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    CompanyName = request.CompanyName,
                    Subscribed = request.Subscribed,
                    DateCreated = request.DateCreated,
                    IsINYOPool = request.IsINYOPool,
                    IsINYOWinter = request.IsINYOWinter,
                    BypassCVVCheck = request.BypassCVVCheck,
                    QandAQuestionOptOut = request.QandAQuestionOptOut,
                    LastOnlineChatDate = request.LastOnlineChatDate,
                    LastSubscribedChangeDate = request.LastSubscribedChangeDate,
                    LastSubscribedNewsletterGroupTypeId = request.LastSubscribedNewsletterGroupTypeId,
                    EmailAddress = request.EmailAddress,
                    LastBounceDate = request.LastBounceDate,
                    LastComplaintDate = request.LastComplaintDate,
                    LastEmailChangeDate = request.LastEmailChangeDate,
                    UserId = request.UserId,
                    LastSubscribedNewsletterGroupChangeDate = request.LastSubscribedNewsletterGroupChangeDate,
                    FraudReason = request.FraudReason,
                    FraudReportedBy = request.FraudReportedBy,
                    FraudStatusId = request?.FraudStatusId,
                    FraudReportedDate = request?.FraudReportedDate,



                };

                await _inyoPoolsDbContext.Customers.AddAsync(customer);

                await _inyoPoolsDbContext.SaveChangesAsync();

                // If the Customer was added successfully, return a success response.
                var response = new AddCustomer.Response { Status = "Success", Message = "Customer added successfully." };
                return response;
            }
            catch (Exception ex)
            {
                // If an error occurred, return an error response.
                var response = new AddCustomer.Response { Status = "Error", Message = ex.Message };
                return response;
            }
        }
    }
}
