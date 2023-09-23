using AutoMapper;
using InyoPools.Core.Domain.Model;

namespace InyoPoolsRest.API.Application.EmailLogs
{
    public class AddEmailLog
    {

        public class Request
        {
            public string EmailTo { get; set; }
            public string EmailFrom { get; set; }
            public string EmailSubject { get; set; }
            public string UserID { get; set; }
            public DateTime DateSent { get; set; }
            public int? EmailTransactionTypeID { get; set; }
            public string EmailBody { get; set; }
            public string EmailBcc { get; set; }
            public int? EmployeeId { get; set; }
            public int? QuoteId { get; set; }
            public int? OriginalEmailLogId { get; set; }


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
                CreateMap<EmailLog, Response>();
            }



        }


    }
}
