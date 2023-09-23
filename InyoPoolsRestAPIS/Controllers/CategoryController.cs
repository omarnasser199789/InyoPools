
using InyoPoolsRest.API.Application.Categories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace InyoPoolsRest.API.Controllers
{
    //[Authorize]
    [Route("api/v1/category")]
    public class CategoryController : ControllerBase
    {
        private readonly IGetCategoryService _iGetCategoryService;

        private readonly IAddCategoryService _iAddCategoryService;

        private readonly IDeleteCategoryService _iDeleteCategoryService;

        public CategoryController(
            IGetCategoryService iGetCategoryService,
            IAddCategoryService iAddCategoryService,
            IDeleteCategoryService iDeleteCategoryService
            )
        {
            _iGetCategoryService = iGetCategoryService;
            _iAddCategoryService = iAddCategoryService;
            _iDeleteCategoryService = iDeleteCategoryService;
        }



        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<ActionResult<List<GetCategory.Response>>> GetCategory([FromQuery] GetCategory.Request request)
        {
            var result = await _iGetCategoryService.GetCategories(request);
            return Ok(result);

        }



        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<ActionResult<AddCategory.Response>> AddCategory([FromForm] AddCategory.Request request)
        {
            try
            {


                // Call the service layer to add the new category.
                var result = await _iAddCategoryService.AddCategory(request);

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


        [HttpDelete]
        [ProducesResponseType(200)]
        public async Task<ActionResult<DeleteCategory.Response>> DeleteCategory([FromForm] DeleteCategory.Request request)
        {
            try
            {
                // Call the service layer to delete the category.
                var result = await _iDeleteCategoryService.DeleteCategory(request);

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
