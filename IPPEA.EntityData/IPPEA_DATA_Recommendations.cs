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
    
    public partial class IPPEA_DATA_Recommendations
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int RecommendedProductID { get; set; }
        public int Rank { get; set; }
        public System.DateTime DateEntered { get; set; }
        public Nullable<int> ProductRelationshipID { get; set; }
    
        public virtual IPPEA_DATA_Product IPPEA_DATA_Product { get; set; }
        public virtual IPPEA_DATA_Product IPPEA_DATA_Product1 { get; set; }
        public virtual IPPEA_DECODE_ProductRelationship IPPEA_DECODE_ProductRelationship { get; set; }
    }
}
