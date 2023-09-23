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
    
    public partial class IPPEA_DATA_ProductCustomerReviews
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IPPEA_DATA_ProductCustomerReviews()
        {
            this.IPPEA_DATA_ProductCustomerReviewImages = new HashSet<IPPEA_DATA_ProductCustomerReviewImages>();
            this.IPPEA_DATA_ProductReviewMedia = new HashSet<IPPEA_DATA_ProductReviewMedia>();
            this.IPPEA_DATA_ProductReviewRating = new HashSet<IPPEA_DATA_ProductReviewRating>();
            this.IPPEA_DATA_ProductReviewRelation = new HashSet<IPPEA_DATA_ProductReviewRelation>();
        }
    
        public int ID { get; set; }
        public int Score { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string Pros { get; set; }
        public string Cons { get; set; }
        public string Review { get; set; }
        public bool RecommendProduct { get; set; }
        public string Location { get; set; }
        public Nullable<int> RecommendInyo { get; set; }
        public string InyoComment { get; set; }
        public Nullable<int> UserID { get; set; }
        public int Approval { get; set; }
        public string ReviewTitle { get; set; }
        public Nullable<bool> Cleared { get; set; }
        public string IPAddress { get; set; }
        public string InyoReply { get; set; }
        public int CustomerNumber { get; set; }
    
        public virtual IPPEA_DATA_Customer IPPEA_DATA_Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_ProductCustomerReviewImages> IPPEA_DATA_ProductCustomerReviewImages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_ProductReviewMedia> IPPEA_DATA_ProductReviewMedia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_ProductReviewRating> IPPEA_DATA_ProductReviewRating { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_ProductReviewRelation> IPPEA_DATA_ProductReviewRelation { get; set; }
    }
}