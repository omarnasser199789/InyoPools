using AutoMapper;
using InyoPools.Core.Domain.Model;

namespace InyoPoolsRest.API.Application.EmailTypes
{
    public class AddEmailType
    {

        public class Request
        {
        
            public string Description { get; set; }
            public string EmailTo { get; set; }
            public string EmailFrom { get; set; }
            public string EmailBcc { get; set; }
            public string EmailSubject { get; set; }
            public string EmailBody { get; set; }
            public int EmailTransactionTypeID { get; set; }
            public int? DelaySendMinutes { get; set; }
            public bool UseNewTemplate { get; set; }


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
                CreateMap<EmailType, Response>();
            }



        }

    }
}
