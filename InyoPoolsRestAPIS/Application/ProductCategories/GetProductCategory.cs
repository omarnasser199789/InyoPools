using AutoMapper;
using InyoPools.Core.Domain.Model;

namespace InyoPoolsRest.API.Application.ProductCategories
{
    public class GetProductCategory
    {

        public class Request
        {


        }


        public class Response
        {
            public ProductCategory ProductCategory { get; set; }

        }



        public class Mapper : Profile
        {


            public Mapper()
            {
                CreateMap<ProductCategory, Response>();
            }



        }
    }
}
