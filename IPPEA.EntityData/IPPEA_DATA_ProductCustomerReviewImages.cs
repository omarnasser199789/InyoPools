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
    
    public partial class IPPEA_DATA_ProductCustomerReviewImages
    {
        public int ID { get; set; }
        public int ProductReviewID { get; set; }
        public string ImageCaption { get; set; }
        public string ImageGUID { get; set; }
    
        public virtual IPPEA_DATA_ProductCustomerReviews IPPEA_DATA_ProductCustomerReviews { get; set; }
    }
}
