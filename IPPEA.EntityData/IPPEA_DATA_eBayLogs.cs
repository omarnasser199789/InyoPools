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
    
    public partial class IPPEA_DATA_eBayLogs
    {
        public int ID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> eBayActionID { get; set; }
        public Nullable<bool> IseBayItem { get; set; }
        public string ProductName { get; set; }
        public string ManufacturerCode { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public string LargeImageName { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string eBayItemID { get; set; }
    
        public virtual IPPEA_DECODE_eBayAction IPPEA_DECODE_eBayAction { get; set; }
        public virtual IPPEA_DATA_Product IPPEA_DATA_Product { get; set; }
    }
}
