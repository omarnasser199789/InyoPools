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
    
    public partial class IPPEA_DATA_VendorProductCategoryRank
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public int ProductCategoryId { get; set; }
        public int Rank { get; set; }
    
        public virtual IPPEA_DATA_ProductCategory IPPEA_DATA_ProductCategory { get; set; }
        public virtual IPPEA_DATA_Vendor IPPEA_DATA_Vendor { get; set; }
    }
}
