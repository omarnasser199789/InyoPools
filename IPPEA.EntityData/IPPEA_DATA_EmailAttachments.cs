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
    
    public partial class IPPEA_DATA_EmailAttachments
    {
        public int ID { get; set; }
        public int EmailQueueID { get; set; }
        public byte[] Content { get; set; }
        public int ContentSize { get; set; }
        public string Filename { get; set; }
    
        public virtual IPPEA_DATA_EmailQueue IPPEA_DATA_EmailQueue { get; set; }
    }
}
