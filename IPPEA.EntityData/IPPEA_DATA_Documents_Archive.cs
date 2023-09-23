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
    
    public partial class IPPEA_DATA_Documents_Archive
    {
        public int ArchiveID { get; set; }
        public string ArchiveType { get; set; }
        public string ArchiveReason { get; set; }
        public int ArchiveUserID { get; set; }
        public System.DateTimeOffset ArchiveDt { get; set; }
        public int ID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> ObjectTypeID { get; set; }
        public Nullable<int> ObjectKey { get; set; }
        public Nullable<int> ObjectGroupID { get; set; }
        public string Description { get; set; }
        public byte[] Content { get; set; }
        public Nullable<int> ContentSize { get; set; }
        public string ContentType { get; set; }
        public string Filename { get; set; }
        public string UserID { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees { get; set; }
    }
}