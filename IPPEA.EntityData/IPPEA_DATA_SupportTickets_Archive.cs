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
    
    public partial class IPPEA_DATA_SupportTickets_Archive
    {
        public int ArchiveID { get; set; }
        public string ArchiveType { get; set; }
        public string ArchiveReason { get; set; }
        public int ArchiveUserID { get; set; }
        public System.DateTimeOffset ArchiveDt { get; set; }
        public int ID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public int CategoryID { get; set; }
        public Nullable<int> ServiceRepID { get; set; }
        public bool Urgent { get; set; }
        public bool Answered { get; set; }
        public Nullable<int> AffiliateID { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public bool VendorRequest { get; set; }
        public Nullable<int> OrderGroupID { get; set; }
        public int TicketStatusID { get; set; }
        public bool ClosedByCust { get; set; }
        public bool ReviewTicket { get; set; }
        public string Lock { get; set; }
        public Nullable<System.DateTime> Locktime { get; set; }
        public string MessageID { get; set; }
        public string AuctionUser { get; set; }
        public string ItemID { get; set; }
        public string ItemURL { get; set; }
        public bool Pending { get; set; }
        public string PendingMessage { get; set; }
        public int ProofStatus { get; set; }
        public Nullable<System.DateTime> ProofTime { get; set; }
        public Nullable<System.DateTime> DateSent { get; set; }
        public Nullable<int> AssignedBy { get; set; }
        public string ReasonForClosing { get; set; }
        public Nullable<int> ClosedBy { get; set; }
        public Nullable<System.DateTimeOffset> ClosedTime { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<double> SentimentResult { get; set; }
        public bool TaggedForQuote { get; set; }
        public Nullable<int> TaggedById { get; set; }
        public Nullable<System.DateTimeOffset> DateTagged { get; set; }
    
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees { get; set; }
    }
}
