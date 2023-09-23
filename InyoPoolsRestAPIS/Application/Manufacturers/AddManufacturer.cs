using AutoMapper;
using InyoPools.Core.Domain.Model;

namespace InyoPoolsRest.API.Application.Manufacturers
{
    public class AddManufacturer
    {
        public class Request
        {

           
            public string Name { get; set; }
            public string Description { get; set; }
            public string URL { get; set; }
            public bool NoPublicDisplayOfMfg { get; set; }
            public bool NoDisplayPopularItems { get; set; }
            public bool NoDisplayToVendors { get; set; }
            public string AbbrDisplayName { get; set; }


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
                CreateMap<Manufacturer, Response>();
            }



        }
    }
}
