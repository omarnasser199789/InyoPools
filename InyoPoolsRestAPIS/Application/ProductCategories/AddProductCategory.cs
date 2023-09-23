using AutoMapper;
using InyoPools.Core.Domain.Enums;
using InyoPools.Core.Domain.Model;

namespace InyoPoolsRest.API.Application.ProductCategories
{
    public class AddProductCategory
    {

        public class Request
        {


            public string Name { get; set; }

            public int? ParentID { get; set; }
            public int ParentLevel { get; set; }
            public string Description { get; set; }
            public IFormFile Image { get; set; }
            public string CategoryPage { get; set; }
            public bool IsActive { get; set; }
            public string ImageName { get; set; }
            public string PageFooter { get; set; }
            public string PageHeader { get; set; }
            public bool DisplayProductListing { get; set; }
            public bool OverridePhysicalFile { get; set; }
            public string GoogleConversionLabel { get; set; }
            public decimal? GoogleConversionValue { get; set; }
            public string PageTitle { get; set; }
            public string PageDescription { get; set; }
            public string PageKeywords { get; set; }
            public string PageH1 { get; set; }
            public bool DisplayOnNavigation { get; set; }
            public string NavigationTitle { get; set; }
            public string NavigationAdvertisementHeading { get; set; }
            public string NavigationAdvertisementImagePath { get; set; }
            public string NavigationAdvertisementText { get; set; }
            public CategoryPage PageTypeId { get; set; }
            public bool RenderNewVersion { get; set; }





            public ICollection<ProductType> ProductType { get; set; }





        }


        public class Response
        {
            public string Status { get; set; }
            public string Message { get; set; }

        }



        public class Mapper : Profile
        {


            public Mapper()
            {
                CreateMap<AddProductCategory, Response>();
            }



        }

    }
}
