using InyoPools.Core.Domain.Model;
using InyoPoolsRest.API.Application.Categories;
using InyoPoolsRest.API.Application.ProductCategories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InyoPoolsRest.API.Controllers
{
    [Authorize]
    [Route("api/v1/productCategory")]
    public class ProductCategoriesController : ControllerBase
    {
        private readonly IAddProductCategoryService _addProductCategoryService;
        private readonly IGetProductCategoryService _getProductCategoryService;

        public ProductCategoriesController(IAddProductCategoryService addProductCategoryService , IGetProductCategoryService getProductCategoryService) { 
        
        
            _addProductCategoryService = addProductCategoryService;
            _getProductCategoryService = getProductCategoryService;


        }




        [HttpPost]
        [ProducesResponseType(200)]
        public async Task<ActionResult<AddProductCategory.Response>> AddProductCategory([FromForm] AddProductCategory.Request request) {
            try
            {


                // Call the service layer to add the new product category.
                var result = await _addProductCategoryService.AddProductCategory(request);

                return Ok(result);
            }
            catch (Exception ex)
            {
                // If an error occurred, return a bad request response with the error message.
                var response = new AddProductCategory.Response
                {
                    Status = "Error",
                    Message = ex.Message
                };
                return BadRequest(response);
            }

        }





        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<ActionResult<List<GetProductCategory.Response>>> GetProductCategory([FromQuery] GetProductCategory.Request request)
        {
            var result = await _getProductCategoryService.GetProductCategories(request);
            return Ok(result);

        }


    }
}
