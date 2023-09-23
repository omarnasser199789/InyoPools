using InyoPools.Infrastructure;
using InyoPoolsRest.API.Application.Categories;

namespace InyoPoolsRest.API.Application.Customers
{



    public interface IDeleteCustomerService {

        Task<DeleteCustomer.Response> DeleteCustomer(DeleteCustomer.Request request);
    }

    public class DeleteCustomerService : IDeleteCustomerService
    {
        private readonly InyoPoolsDbContext _inyoPoolsDbContext;

        public DeleteCustomerService(InyoPoolsDbContext inyoPoolsDbContext) {
            _inyoPoolsDbContext = inyoPoolsDbContext;
        }

        public async Task<DeleteCustomer.Response> DeleteCustomer(DeleteCustomer.Request request)
        {
            // Retrieve the customer to be deleted
            var customer = await _inyoPoolsDbContext.Customers.FindAsync(request.Id);


            if (customer == null)
            {
                return new DeleteCustomer.Response
                {
                    Status = "Error",
                    Message = $"Customer with ID {request.Id} not found"
                };
            }

            //Delete the customer
            _inyoPoolsDbContext.Customers.Remove(customer);
            await _inyoPoolsDbContext.SaveChangesAsync();

            return new DeleteCustomer.Response
            {
                Status = "Success",
                Message = $"Customer with ID {request.Id} deleted successfully"
            };
        }
    }
}
