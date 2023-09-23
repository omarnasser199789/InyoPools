using AutoMapper;
using InyoPools.Core.Domain.Model;

namespace InyoPoolsRest.API.Application.Categories
{
    public class GetCategory
    {


        public class Request { 
        
        
        }


        public class Response 
        {
            public Category Category { get; set; }
        
        }



        public class Mapper : Profile 
        {


            public Mapper() {
                CreateMap<Category, Response>();
            }

           
        
        }

    }
}
