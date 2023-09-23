using InyoPoolsRest.API.Application.Categories;
using InyoPoolsRest.API.Application.TestCategories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InyoPoolsRest.API.Controllers
{


    [Authorize]
    [Route("api/v1/testcategory")]
    public class TestCategoryController : ControllerBase
    {

        private readonly IGetTestCategoryService _iGetTestCategoryService;

        private readonly IAddTestCategoryService _iAddTestCategoryService;


        public TestCategoryController(IGetTestCategoryService iGetTestCategoryService, IAddTestCategoryService iAddTestCategoryService)
        {
            _iGetTestCategoryService = iGetTestCategoryService;
            _iAddTestCategoryService = iAddTestCategoryService;
        }




        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<ActionResult<List<GetTestCategory.Response>>> GetTestCategory([FromQuery] GetTestCategory.Request request)
        {
            var result = await _iGetTestCategoryService.GetTestCategories(request);
            return Ok(result);

        }



        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<ActionResult<AddTestCategory.Response>> AddTestCategory([FromForm] AddTestCategory.Request request)
        {
            try
            {


                // Call the service layer to add the new category.
                var result = await _iAddTestCategoryService.AddTestCategory(request);

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



    }
}
