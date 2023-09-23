using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyoPools.Core.Domain.Model
{
    public class EmailLog
    {
        public int ID { get; set; }
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

        //public virtual Customer Customer { get; set; }
        //public virtual IPPEA_DECODE_EmailTypes IPPEA_DECODE_EmailTypes { get; set; }
        //public virtual IPPEA_DATA_OrderFormHeader IPPEA_DATA_OrderFormHeader { get; set; }
        //public virtual IPPEA_DATA_OrderGroup IPPEA_DATA_OrderGroup { get; set; }
        //public virtual IPPEA_DATA_Manufacturer IPPEA_DATA_Manufacturer { get; set; }
        //public virtual IPPEA_DATA_Vendor IPPEA_DATA_Vendor { get; set; }
        //public virtual ICollection<IPPEA_DATA_EmailAttachmentsLog> IPPEA_DATA_EmailAttachmentsLog { get; set; } = new HashSet<IPPEA_DATA_EmailAttachmentsLog>();
        //public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees { get; set; }
        //public virtual IPPEA_DATA_Quotes IPPEA_DATA_Quotes { get; set; }
        //public virtual ICollection<IPPEA_DATA_EmailLog> IPPEA_DATA_EmailLog_ResentLogs { get; set; } = new HashSet<IPPEA_DATA_EmailLog>();
        //public virtual IPPEA_DATA_EmailLog IPPEA_DATA_EmailLog_OriginalLog { get; set; }
        //public virtual ICollection<IPPEA_DATA_EmailQueue> IPPEA_DATA_EmailQueue { get; set; } = new HashSet<IPPEA_DATA_EmailQueue>();
    }
}
