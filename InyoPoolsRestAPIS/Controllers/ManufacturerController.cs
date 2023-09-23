using InyoPoolsRest.API.Application.Categories;
using InyoPoolsRest.API.Application.Manufacturers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InyoPoolsRest.API.Controllers
{
    //[Authorize]
    [Route("api/v1/manufacturer")]
    public class ManufacturerController : ControllerBase
    {
        private readonly IAddManufacturerService _iAddManufacturerService;
        private readonly IGetManufacturersService _iGetManufacturerService;
        private readonly IDeleteManufacturerService _iDeleteManufacturersService;

        public ManufacturerController(IAddManufacturerService iAddManufacturerService, IGetManufacturersService iGetManufacturerService, IDeleteManufacturerService iDeleteManufacturersService)
        {
            _iAddManufacturerService = iAddManufacturerService;
            _iGetManufacturerService = iGetManufacturerService;
            _iDeleteManufacturersService = iDeleteManufacturersService;
        }

        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<ActionResult<AddManufacturer.Response>> AddCategory([FromForm] AddManufacturer.Request request)
        {
            try
            {


                // Call the service layer to add the new manufacturer.
                var result = await _iAddManufacturerService.AddManufacturer(request);

                return Ok(result);
            }
            catch (Exception ex)
            {
                // If an error occurred, return a bad request response with the error message.
                var response = new AddCategory.Response
                {
                    Status = "Error",
                    Message = ex.Message
                };
                return BadRequest(response);
            }
        }




        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<ActionResult<List<GetManufacturers.Response>>> GetManufacturers([FromQuery] GetManufacturers.Request request)
        {
            var result = await _iGetManufacturerService.GetManufacturers(request);
            return Ok(result);

        }


        [HttpDelete]
        [ProducesResponseType(200)]
        public async Task<ActionResult<DeleteManufacturer.Response>> DeleteManufacturer([FromQuery] DeleteManufacturer.Request request)
        {
            try
            {
                // Call the service layer to delete the manufacturer.
                var result = await _iDeleteManufacturersService.DeleteCategory(request);

                return Ok(result);
            }
            catch (Exception ex)
            {
                // If an error occurred, return a bad request response with the error message.
                var response = new DeleteCategory.Response
                {
                    Status = "Error",
                    Message = ex.Message
                };
                return BadRequest(response);
            }
        }
    }
}
