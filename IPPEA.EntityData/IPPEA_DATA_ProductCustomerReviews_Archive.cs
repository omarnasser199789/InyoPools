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
    
    public partial class IPPEA_DATA_ProductCustomerReviews_Archive
    {
        public int ArchiveID { get; set; }
        public string ArchiveType { get; set; }
        public string ArchiveReason { get; set; }
        public int ArchiveUserID { get; set; }
        public System.DateTimeOffset ArchiveDt { get; set; }
        public int ID { get; set; }
        public int Score { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string Pros { get; set; }
        public string Cons { get; set; }
        public string Review { get; set; }
        public bool RecommendProduct { get; set; }
        public string Location { get; set; }
        public Nullable<int> RecommendInyo { get; set; }
        public string InyoComment { get; set; }
        public Nullable<int> UserID { get; set; }
        public int Approval { get; set; }
        public string ReviewTitle { get; set; }
        public Nullable<bool> Cleared { get; set; }
        public string IPAddress { get; set; }
        public string InyoReply { get; set; }
        public int CustomerNumber { get; set; }
    
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees { get; set; }
    }
}
