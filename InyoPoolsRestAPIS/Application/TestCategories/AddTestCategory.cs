using AutoMapper;
using InyoPools.Core.Domain.Model;

namespace InyoPoolsRest.API.Application.TestCategories
{
    public class AddTestCategory
    {


        public class Request
        {
            public string Name { get; set; }

            public int? ParentId { get; set; } = null;
          


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
                CreateMap<AddTestCategory, Response>();
            }



        }
    }
}
