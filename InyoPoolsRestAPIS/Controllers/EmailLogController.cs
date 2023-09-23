using InyoPoolsRest.API.Application.Categories;
using InyoPoolsRest.API.Application.EmailLogs;
using Microsoft.AspNetCore.Mvc;

namespace InyoPoolsRest.API.Controllers
{

        //[Authorize]
        [Route("api/v1/email-log")]
    public class EmailLogController : ControllerBase
    {

        private readonly IAddEmailLogService _iAddEmailLogService;
        private readonly IGetEmailLogsService _iGetEmailLogsService;
        public EmailLogController(IAddEmailLogService emailLogService, IGetEmailLogsService iGetEmailLogsService)
        {
            _iAddEmailLogService = emailLogService;
            _iGetEmailLogsService = iGetEmailLogsService;
        }


        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<ActionResult<AddEmailLog.Response>> AddCategory([FromForm] AddEmailLog.Request request)
        {
            try
            {


                // Call the service layer to add the new category.
                var result = await _iAddEmailLogService.AddEmailLog(request);

                return Ok(result);
            }
            catch (Exception ex)
            {
                // If an error occurred, return a bad request response with the error message.
                var response = new AddEmailLog.Response
                {
                    Status = "Error",
                    Message = ex.Message
                };
                return BadRequest(response);
            }
        }



        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<ActionResult<List<GetEmailLogs.Response>>> GetCategory([FromQuery] GetEmailLogs.Request request)
        {
            var result = await _iGetEmailLogsService.GetEmailLogs(request);
            return Ok(result);

        }
    }
}
