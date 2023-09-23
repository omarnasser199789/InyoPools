using InyoPoolsRest.API.Application.Customers;
using InyoPoolsRest.API.Application.EmailLogs;
using InyoPoolsRest.API.Application.EmailTypes;
using Microsoft.AspNetCore.Mvc;

namespace InyoPoolsRest.API.Controllers
{

    //[Authorize]
    [Route("api/v1/email-type")]
    public class EmailTypeController : ControllerBase
    {


        private readonly IAddEmailTypeService _iAddEmailTypeService;



      public  EmailTypeController(IAddEmailTypeService iAddEmailTypeService) {
            _iAddEmailTypeService = iAddEmailTypeService;
      }

        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<ActionResult<AddEmailType.Response>> AddEmailLog([FromForm] AddEmailType.Request request)
        {
            try
            {


                // Call the service layer to add the new AddEmailType.
                var result = await _iAddEmailTypeService.AddEmailType(request);

                return Ok(result);
            }
            catch (Exception ex)
            {
                // If an error occurred, return a bad request response with the error message.
                var response = new AddEmailType.Response
                {
                    Status = "Error",
                    Message = ex.Message
                };
                return BadRequest(response);
            }
        }





    }
}
    