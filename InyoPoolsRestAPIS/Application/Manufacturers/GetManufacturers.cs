using AutoMapper;
using InyoPools.Core.Domain.Model;

namespace InyoPoolsRest.API.Application.Manufacturers
{
    public class GetManufacturers
    {

        public class Request
        {


        }


        public class Response
        {
            public Manufacturer Manufacturer { get; set; }

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
