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
    
    public partial class IPPEA_DATA_EmailAttachmentsLog
    {
        public int ID { get; set; }
        public int EmailLogId { get; set; }
        public byte[] Content { get; set; }
        public Nullable<int> ContentSize { get; set; }
        public string Filename { get; set; }
        public Nullable<int> MediaId { get; set; }
    
        public virtual IPPEA_DATA_EmailLog IPPEA_DATA_EmailLog { get; set; }
        public virtual IPPEA_DATA_Media IPPEA_DATA_Media { get; set; }
    }
}
