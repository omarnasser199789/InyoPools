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
    
    public partial class IPPEA_DECODE_ItemStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IPPEA_DECODE_ItemStatus()
        {
            this.IPPEA_DATA_OrderFormLineItem = new HashSet<IPPEA_DATA_OrderFormLineItem>();
        }
    
        public int ID { get; set; }
        public string Description { get; set; }
        public string PublicDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_OrderFormLineItem> IPPEA_DATA_OrderFormLineItem { get; set; }
    }
}
