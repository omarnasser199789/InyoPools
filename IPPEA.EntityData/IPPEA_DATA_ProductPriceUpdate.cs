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
    
    public partial class IPPEA_DATA_ProductPriceUpdate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IPPEA_DATA_ProductPriceUpdate()
        {
            this.IPPEA_DATA_ProductPriceUpdateResult = new HashSet<IPPEA_DATA_ProductPriceUpdateResult>();
        }
    
        public int Id { get; set; }
        public string UserId { get; set; }
        public System.DateTimeOffset DateRun { get; set; }
        public int TotalEntries { get; set; }
        public int EntriesUpdated { get; set; }
        public int EntriesNoUpdateRequired { get; set; }
        public int EntriesNoMatchFound { get; set; }
        public int EntriesRequiringManualReview { get; set; }
        public int TotalProducts { get; set; }
        public int TotalProductsUpdated { get; set; }
        public bool HasErrors { get; set; }
        public string ErrorMessage { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_ProductPriceUpdateResult> IPPEA_DATA_ProductPriceUpdateResult { get; set; }
    }
}