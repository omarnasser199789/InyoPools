using AutoMapper;
using InyoPools.Core.Domain.Model;

namespace InyoPoolsRest.API.Application.Manufacturers
{
    public class DeleteManufacturer
    {
        public class Request
        {
            public int Id { get; set; }




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
