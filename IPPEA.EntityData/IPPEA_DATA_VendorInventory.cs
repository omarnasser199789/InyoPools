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
    
    public partial class IPPEA_DATA_VendorInventory
    {
        public int ID { get; set; }
        public int VendorID { get; set; }
        public string ManufacturerCode { get; set; }
        public int TotalInventory { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public int VendorLocationID { get; set; }
    
        public virtual IPPEA_DATA_Vendor IPPEA_DATA_Vendor { get; set; }
        public virtual IPPEA_DATA_VendorLocations IPPEA_DATA_VendorLocations { get; set; }
    }
}
