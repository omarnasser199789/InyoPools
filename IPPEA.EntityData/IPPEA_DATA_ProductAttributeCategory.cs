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
    
    public partial class IPPEA_DATA_ProductAttributeCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IPPEA_DATA_ProductAttributeCategory()
        {
            this.IPPEA_DATA_ProductAttributeProducts = new HashSet<IPPEA_DATA_ProductAttributeProducts>();
            this.IPPEA_DATA_ProductAttributeToCategory = new HashSet<IPPEA_DATA_ProductAttributeToCategory>();
        }
    
        public int ID { get; set; }
        public int TemplateID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryIntro { get; set; }
        public int SortOrder { get; set; }
    
        public virtual IPPEA_DATA_ProductAttributeTemplate IPPEA_DATA_ProductAttributeTemplate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_ProductAttributeProducts> IPPEA_DATA_ProductAttributeProducts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_ProductAttributeToCategory> IPPEA_DATA_ProductAttributeToCategory { get; set; }
    }
}