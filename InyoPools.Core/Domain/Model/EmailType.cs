using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyoPools.Core.Domain.Model
{
    public class EmailType
    {

        public int ID { get; set; }
        public string Description { get; set; }
        public string EmailTo { get; set; }
        public string EmailFrom { get; set; }
        public string EmailBcc { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public int EmailTransactionTypeID { get; set; }
        public int? DelaySendMinutes { get; set; }
        public bool UseNewTemplate { get; set; }

        //public virtual ICollection<IPPEA_DATA_EmailLog> IPPEA_DATA_EmailLog { get; set; } = new HashSet<IPPEA_DATA_EmailLog>();
        //public virtual ICollection<IPPEA_DATA_EmailQueue> IPPEA_DATA_EmailQueue { get; set; } = new HashSet<IPPEA_DATA_EmailQueue>();

    }
}
