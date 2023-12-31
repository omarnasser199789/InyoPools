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
    
    public partial class IPPEA_DATA_OrderFormLineItem_Archive
    {
        public int ArchiveID { get; set; }
        public string ArchiveType { get; set; }
        public string ArchiveReason { get; set; }
        public int ArchiveUserID { get; set; }
        public System.DateTimeOffset ArchiveDt { get; set; }
        public int ID { get; set; }
        public Nullable<int> OrderFormID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<decimal> UnitCost { get; set; }
        public Nullable<int> ShipMethodID { get; set; }
        public string AuctionNumber { get; set; }
        public string AuctionTransID { get; set; }
        public Nullable<int> ExpectedShipDay { get; set; }
        public Nullable<int> ItemStatusID { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public Nullable<int> VendorLocationID { get; set; }
        public Nullable<decimal> OriginalCost { get; set; }
        public string AuctionUser { get; set; }
        public Nullable<System.DateTime> LastChangeDate { get; set; }
        public Nullable<int> CancelReasonId { get; set; }
    
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees { get; set; }
    }
}
