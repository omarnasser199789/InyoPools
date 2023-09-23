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
    
    public partial class IPPEA_DATA_Media
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IPPEA_DATA_Media()
        {
            this.IPPEA_DATA_ConversationMessageMedia = new HashSet<IPPEA_DATA_ConversationMessageMedia>();
            this.IPPEA_DATA_EmailAttachmentsLog = new HashSet<IPPEA_DATA_EmailAttachmentsLog>();
            this.IPPEA_DATA_EmailLog = new HashSet<IPPEA_DATA_EmailLog>();
            this.IPPEA_DATA_HowToInformationMedia = new HashSet<IPPEA_DATA_HowToInformationMedia>();
            this.IPPEA_DATA_HowToPageMedia = new HashSet<IPPEA_DATA_HowToPageMedia>();
            this.IPPEA_DATA_PaidVendorBatch = new HashSet<IPPEA_DATA_PaidVendorBatch>();
            this.IPPEA_DATA_PartCategoryMedia = new HashSet<IPPEA_DATA_PartCategoryMedia>();
            this.IPPEA_DATA_PartPageMedia = new HashSet<IPPEA_DATA_PartPageMedia>();
            this.IPPEA_DATA_ProductCategoryMedia = new HashSet<IPPEA_DATA_ProductCategoryMedia>();
            this.IPPEA_DATA_ProductMedia = new HashSet<IPPEA_DATA_ProductMedia>();
            this.IPPEA_DATA_ProductReviewMedia = new HashSet<IPPEA_DATA_ProductReviewMedia>();
            this.IPPEA_DATA_ProductSpecificationMedia = new HashSet<IPPEA_DATA_ProductSpecificationMedia>();
            this.IPPEA_DATA_QandAAnswerMedia = new HashSet<IPPEA_DATA_QandAAnswerMedia>();
            this.IPPEA_DATA_QandAQuestionMedia = new HashSet<IPPEA_DATA_QandAQuestionMedia>();
            this.IPPEA_DATA_SalesTaxExemption = new HashSet<IPPEA_DATA_SalesTaxExemption>();
            this.IPPEA_DATA_SupportAttachmentMedia = new HashSet<IPPEA_DATA_SupportAttachmentMedia>();
        }
    
        public int Id { get; set; }
        public int MediaFormatTypeId { get; set; }
        public int MediaLocationId { get; set; }
        public string Url { get; set; }
        public System.DateTime InsertDate { get; set; }
        public Nullable<int> Height { get; set; }
        public Nullable<int> Width { get; set; }
        public Nullable<float> VerticalResolution { get; set; }
        public Nullable<float> HorizontalResolution { get; set; }
        public string PixelFormat { get; set; }
        public Nullable<decimal> SizeInKB { get; set; }
        public string ImageType { get; set; }
        public string Title { get; set; }
        public Nullable<int> AzureContainerTypeId { get; set; }
        public string PreAzureUrl { get; set; }
        public Nullable<System.DateTimeOffset> FileCreateDate { get; set; }
        public string User { get; set; }
        public string MD5HashCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_ConversationMessageMedia> IPPEA_DATA_ConversationMessageMedia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_EmailAttachmentsLog> IPPEA_DATA_EmailAttachmentsLog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_EmailLog> IPPEA_DATA_EmailLog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_HowToInformationMedia> IPPEA_DATA_HowToInformationMedia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_HowToPageMedia> IPPEA_DATA_HowToPageMedia { get; set; }
        public virtual IPPEA_DECODE_AzureContainerTypes IPPEA_DECODE_AzureContainerTypes { get; set; }
        public virtual IPPEA_DECODE_MediaFormatTypes IPPEA_DECODE_MediaFormatTypes { get; set; }
        public virtual IPPEA_DECODE_MediaLocations IPPEA_DECODE_MediaLocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_PaidVendorBatch> IPPEA_DATA_PaidVendorBatch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_PartCategoryMedia> IPPEA_DATA_PartCategoryMedia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_PartPageMedia> IPPEA_DATA_PartPageMedia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_ProductCategoryMedia> IPPEA_DATA_ProductCategoryMedia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_ProductMedia> IPPEA_DATA_ProductMedia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_ProductReviewMedia> IPPEA_DATA_ProductReviewMedia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_ProductSpecificationMedia> IPPEA_DATA_ProductSpecificationMedia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_QandAAnswerMedia> IPPEA_DATA_QandAAnswerMedia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_QandAQuestionMedia> IPPEA_DATA_QandAQuestionMedia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_SalesTaxExemption> IPPEA_DATA_SalesTaxExemption { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_SupportAttachmentMedia> IPPEA_DATA_SupportAttachmentMedia { get; set; }
    }
}