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
    
    public partial class IPPEA_DATA_ShipTracking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IPPEA_DATA_ShipTracking()
        {
            this.IPPEA_DATA_SellingChannelActivity = new HashSet<IPPEA_DATA_SellingChannelActivity>();
        }
    
        public int ID { get; set; }
        public int OrderFormID { get; set; }
        public int CarrierID { get; set; }
        public string TrackingNumber { get; set; }
        public System.DateTime ShipDate { get; set; }
        public Nullable<System.DateTime> EmailSentDate { get; set; }
        public bool ReturnService { get; set; }
        public string Items { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public bool NoPublicDisplay { get; set; }
    
        public virtual IPPEA_DATA_OrderFormHeader IPPEA_DATA_OrderFormHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_SellingChannelActivity> IPPEA_DATA_SellingChannelActivity { get; set; }
        public virtual IPPEA_DATA_ShipCarriers IPPEA_DATA_ShipCarriers { get; set; }
    }
}
