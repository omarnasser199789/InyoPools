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
    
    public partial class IPPEA_DATA_Session_Archive
    {
        public int ArchiveID { get; set; }
        public string ArchiveType { get; set; }
        public string ArchiveReason { get; set; }
        public int ArchiveUserID { get; set; }
        public System.DateTimeOffset ArchiveDt { get; set; }
        public int ID { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public string IPAddress { get; set; }
        public string UserAgent { get; set; }
        public Nullable<System.DateTimeOffset> CreateDate { get; set; }
        public Nullable<System.DateTimeOffset> LastUpdate { get; set; }
        public string ZipPostalCode { get; set; }
        public string Province { get; set; }
        public string CityTown { get; set; }
        public string StateProvinceCode { get; set; }
        public string CountryCode { get; set; }
        public string PersonalPrinterId { get; set; }
        public Nullable<int> QuoteId { get; set; }
    
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees { get; set; }
    }
}
