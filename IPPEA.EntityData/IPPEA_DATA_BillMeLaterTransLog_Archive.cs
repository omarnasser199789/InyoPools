//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPPEA.EntityData
{
    using System;
    using System.Collections.Generic;
    
    public partial class IPPEA_DATA_BillMeLaterTransLog_Archive
    {
        public int ArchiveID { get; set; }
        public string ArchiveType { get; set; }
        public string ArchiveReason { get; set; }
        public int ArchiveUserID { get; set; }
        public System.DateTimeOffset ArchiveDt { get; set; }
        public int ID { get; set; }
        public Nullable<System.DateTime> DateEntered { get; set; }
        public int CustomerID { get; set; }
        public string Decision { get; set; }
        public Nullable<int> ReplyType { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string AuthCode { get; set; }
        public Nullable<int> ReasonCode { get; set; }
        public string ReconciliationID { get; set; }
        public string RequestID { get; set; }
    
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees { get; set; }
    }
}
