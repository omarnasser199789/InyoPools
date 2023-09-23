using AutoMapper;
using InyoPools.Core.Domain.Model;

namespace InyoPoolsRest.API.Application.TestCategories
{
    public class GetTestCategory
    {
        public class Request
        {


        }


        public class Response
        {
            public TestCategory testCategory { get; set; }

        }



        public class Mapper : Profile
        {


            public Mapper()
            {
                CreateMap<TestCategory, Response>();
            }



        }
    }
}
