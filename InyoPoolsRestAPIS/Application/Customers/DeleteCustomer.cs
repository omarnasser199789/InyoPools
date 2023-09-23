using AutoMapper;
using InyoPools.Core.Domain.Model;

namespace InyoPoolsRest.API.Application.Customers
{
    public class DeleteCustomer
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
                CreateMap<Customer, Response>();
            }



        }

    }
}
