using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyoPools.Core.Domain.Model
{
    public class Customer
    {
        public int ID { get; set; }
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
        //public IPPEA.EntityData.Enumerations.CustomerCreateTypeEF? CreateTypeId { get; set; }
        public string UserId { get; set; }
        public DateTimeOffset? LastSubscribedNewsletterGroupChangeDate { get; set; }
        public string FraudReason { get; set; }
        public string FraudReportedBy { get; set; }
        public int? FraudStatusId { get; set; }
        public DateTimeOffset? FraudReportedDate { get; set; }


    }
}
