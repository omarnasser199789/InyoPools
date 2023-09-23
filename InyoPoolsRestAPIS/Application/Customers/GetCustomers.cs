using AutoMapper;
using InyoPools.Core.Domain.Model;

namespace InyoPoolsRest.API.Application.Customers
{
    public class GetCustomers
    {

        public class Request
        {


        }


        public class Response
        {
            public Customer Customer { get; set; }

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
