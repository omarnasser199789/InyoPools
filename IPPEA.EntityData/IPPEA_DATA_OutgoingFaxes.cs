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
    
    public partial class IPPEA_DATA_OutgoingFaxes
    {
        public int ID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public string Description { get; set; }
        public string FaxNumber { get; set; }
        public Nullable<bool> CoverSheet { get; set; }
        public string CoverSheetMsg { get; set; }
        public string UserID { get; set; }
        public Nullable<System.DateTime> DateEntered { get; set; }
        public string FaxFrom { get; set; }
        public string FaxTo { get; set; }
        public Nullable<int> AffiliateID { get; set; }
    
        public virtual IPPEA_DATA_Customer IPPEA_DATA_Customer { get; set; }
    }
}
