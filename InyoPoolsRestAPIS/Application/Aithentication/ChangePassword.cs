using AutoMapper;
using InyoPools.Core.Domain.Model;

namespace InyoPoolsRest.API.Application.Aithentication
{
    public class ChangePassword
    {
        public class Request
        {
            public string Username { get; set; }
            public string OldPassword { get; set; }
            public string NewPassword { get; set; }
            public string ConfirmPassword { get; set; }



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
