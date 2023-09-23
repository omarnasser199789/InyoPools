using InyoPools.Core.Domain.Model;
using InyoPools.Infrastructure;
using InyoPoolsRest.API.Application.Categories;

namespace InyoPoolsRest.API.Application.ProductCategories
{


    public interface IAddProductCategoryService
    {
        Task<AddProductCategory.Response> AddProductCategory(AddProductCategory.Request request);
    }

    public class AddProductCategoryService: IAddProductCategoryService
    {
        private readonly InyoPoolsDbContext _inyoPoolsDbContext;
        private string containerName = "product-categories";
        public AddProductCategoryService(InyoPoolsDbContext inyoPoolsDbContext) { 
        _inyoPoolsDbContext = inyoPoolsDbContext;   

        }



        public async Task<AddProductCategory.Response> AddProductCategory(AddProductCategory.Request request)
        {

            try
            {



                string imagePath = await Utilities.UploadFile(request.Image, containerName);




                var productCategory = new ProductCategory
                {
                 
                  
                    Name = request.Name,
                    ParentID = request.ParentID,
                    ParentLevel = request.ParentLevel,
                    Description = request.Description,
                    ImagePath = imagePath,
                    CategoryPage = request.CategoryPage,
                    IsActive = request.IsActive,
                    ImageName = request.ImageName,
                    PageFooter = request.PageFooter,
                    PageHeader = request.PageHeader,
                    DisplayProductListing = request.DisplayProductListing,
                    OverridePhysicalFile = request.OverridePhysicalFile,
                    GoogleConversionLabel = request.GoogleConversionLabel,
                    GoogleConversionValue = request.GoogleConversionValue,
                    PageTitle = request.PageTitle,
                    PageDescription = request.PageDescription,
                    PageKeywords = request.PageKeywords,
                    PageH1 = request.PageH1,
                    DisplayOnNavigation = request.DisplayOnNavigation,
                    NavigationTitle = request.NavigationTitle,
                    NavigationAdvertisementHeading = request.NavigationAdvertisementHeading,
                    NavigationAdvertisementImagePath = request.NavigationAdvertisementImagePath,
                    NavigationAdvertisementText = request.NavigationAdvertisementText,
                    PageTypeId = request.PageTypeId,
                    RenderNewVersion = request.RenderNewVersion,
                    //ProductType = request.ProductType,

                };

                await _inyoPoolsDbContext.ProductCategories.AddAsync(productCategory);

                await _inyoPoolsDbContext.SaveChangesAsync();

                // If the category was added successfully, return a success response.
                var response = new AddProductCategory.Response { Status = "Success", Message = "ProductCategory added successfully." };
                return response;
            }
            catch (Exception ex)
            {
                // If an error occurred, return an error response.
                var response = new AddProductCategory.Response { Status = "Error", Message = ex.Message };
                return response;
            }
        }




    }
}
