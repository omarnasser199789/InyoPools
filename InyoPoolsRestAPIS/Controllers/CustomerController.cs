using InyoPoolsRest.API.Application.Categories;
using InyoPoolsRest.API.Application.Customers;
using Microsoft.AspNetCore.Mvc;

namespace InyoPoolsRest.API.Controllers
{

    [Route("api/v1/customer")]
    public class CustomerController: ControllerBase
    {


        private readonly IAddCustomerService _iAddCustomerService;
        private readonly IGetCustomersService _iGetCustomersService;
        private readonly IDeleteCustomerService _iDeleteCustomerService;

        public CustomerController(IAddCustomerService iAddCustomerService, IGetCustomersService iGetCustomersService, IDeleteCustomerService iDeleteCustomerService) {
            _iAddCustomerService = iAddCustomerService;
            _iGetCustomersService = iGetCustomersService;
            _iDeleteCustomerService = iDeleteCustomerService;
        }



        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<ActionResult<AddCustomer.Response>> AddCustomer([FromForm] AddCustomer.Request request)
        {
            try
            {


                // Call the service layer to add the new Customer.
                var result = await _iAddCustomerService.AddCategory(request);

                return Ok(result);
            }
            catch (Exception ex)
            {
                // If an error occurred, return a bad request response with the error message.
                var response = new AddCustomer.Response
                {
                    Status = "Error",
                    Message = ex.Message
                };
                return BadRequest(response);
            }
        }



        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<ActionResult<List<GetCustomers.Response>>> GetCustomer([FromQuery] GetCustomers.Request request)
        {
            var result = await _iGetCustomersService.GetCustomers(request);
            return Ok(result);

        }



        [HttpDelete]
        [ProducesResponseType(200)]
        public async Task<ActionResult<DeleteCustomer.Response>> DeleteCustomer([FromQuery] DeleteCustomer.Request request)
        {
            try
            {
                // Call the service layer to delete the customer.
                var result = await _iDeleteCustomerService.DeleteCustomer(request);

                return Ok(result);
            }
            catch (Exception ex)
            {
                // If an error occurred, return a bad request response with the error message.
                var response = new DeleteCustomer.Response
                {
                    Status = "Error",
                    Message = ex.Message
                };
                return BadRequest(response);
            }
        }



    }
}
