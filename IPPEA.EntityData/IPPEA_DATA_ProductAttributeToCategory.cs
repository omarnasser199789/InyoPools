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
    
    public partial class IPPEA_DATA_ProductAttributeToCategory
    {
        public int ID { get; set; }
        public int ProductAttributeID { get; set; }
        public int ProductAttributeCategoryID { get; set; }
    
        public virtual IPPEA_DATA_ProductAttribute IPPEA_DATA_ProductAttribute { get; set; }
        public virtual IPPEA_DATA_ProductAttributeCategory IPPEA_DATA_ProductAttributeCategory { get; set; }
    }
}
