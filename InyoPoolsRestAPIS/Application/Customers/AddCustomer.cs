using AutoMapper;
using InyoPools.Core.Domain.Model;

namespace InyoPoolsRest.API.Application.Customers
{
    public class AddCustomer
    {

        public class Request
        {
         
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string CompanyName { get; set; }
            public bool Subscribed { get; set; }
            public DateTime DateCreated { get; set; }
            public bool IsINYOPool { get; set; }
            public bool IsINYOWinter { get; set; }
            public bool BypassCVVCheck { get; set; }
            public bool QandAQuestionOptOut { get; set; }
            public DateTimeOffset? LastOnlineChatDate { get; set; }
            public DateTimeOffset? LastSubscribedChangeDate { get; set; }
            public int? LastSubscribedNewsletterGroupTypeId { get; set; }
            public string EmailAddress { get; set; }
            public DateTime? LastBounceDate { get; set; }
            public DateTime? LastComplaintDate { get; set; }
            public DateTimeOffset? LastEmailChangeDate { get; set; }
            
            public string UserId { get; set; }
            public DateTimeOffset? LastSubscribedNewsletterGroupChangeDate { get; set; }
            public string FraudReason { get; set; }
            public string FraudReportedBy { get; set; }
            public int? FraudStatusId { get; set; }
            public DateTimeOffset? FraudReportedDate { get; set; }


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
