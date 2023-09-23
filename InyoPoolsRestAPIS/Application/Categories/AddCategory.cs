using AutoMapper;
using InyoPools.Core.Domain.Model;

namespace InyoPoolsRest.API.Application.Categories
{
    public class AddCategory
    {
        public class Request
        {
            public bool IsActive { get; set; }

            public int PerentLevel { get; set; }

            public int PerentId { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }

            //public string Image { get; set; }

            public IFormFile Image { get; set; }


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
                CreateMap<Category, Response>();
            }



        }
    }
}
