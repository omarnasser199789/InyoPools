using AutoMapper;
using InyoPools.Core.Domain.Model;

namespace InyoPoolsRest.API.Application.EmailLogs
{
    public class GetEmailLogs
    {


        public class Request
        {


        }


        public class Response
        {
            public EmailLog EmailLog { get; set; }

        }



        public class Mapper : Profile
        {


            public Mapper()
            {
                CreateMap<EmailLog, Response>();
            }



        }

    }
}
