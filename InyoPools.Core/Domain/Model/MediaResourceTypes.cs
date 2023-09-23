using InyoPools.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyoPools.Core.Domain.Model
{
    public class MediaResourceTypes
    {
        public MediaResource Id { get; set; }
        public string Resource { get; set; }

        public virtual ICollection<ProductMedia> IPPEA_DATA_ProductMedia { get; set; } = new HashSet<ProductMedia>();
        //public virtual ICollection<IPPEA_DATA_PartPageMedia> IPPEA_DATA_PartPageMedia { get; set; } = new HashSet<IPPEA_DATA_PartPageMedia>();
        //public virtual ICollection<IPPEA_DATA_HowToInformationMedia> IPPEA_DATA_HowToInformationMedia { get; set; } = new HashSet<IPPEA_DATA_HowToInformationMedia>();
        //public virtual ICollection<IPPEA_DATA_HowToPageMedia> IPPEA_DATA_HowToPageMedia { get; set; } = new HashSet<IPPEA_DATA_HowToPageMedia>();
        //public virtual ICollection<IPPEA_DATA_PartCategoryMedia> IPPEA_DATA_PartCategoryMedia { get; set; } = new HashSet<IPPEA_DATA_PartCategoryMedia>();
        //public virtual ICollection<IPPEA_DATA_ProductCategoryMedia> IPPEA_DATA_ProductCategoryMedia { get; set; } = new HashSet<IPPEA_DATA_ProductCategoryMedia>();
        //public virtual ICollection<IPPEA_DATA_ProductSpecificationMedia> IPPEA_DATA_ProductSpecificationMedia { get; set; } = new HashSet<IPPEA_DATA_ProductSpecificationMedia>();
        //public virtual ICollection<IPPEA_DATA_SupportAttachmentMedia> IPPEA_DATA_SupportAttachmentMedia { get; set; } = new HashSet<IPPEA_DATA_SupportAttachmentMedia>();
        //public virtual ICollection<IPPEA_DATA_ProductReviewMedia> IPPEA_DATA_ProductReviewMedia { get; set; } = new HashSet<IPPEA_DATA_ProductReviewMedia>();
        //public virtual ICollection<IPPEA_DATA_QandAQuestionMedia> IPPEA_DATA_QandAQuestionMedia { get; set; } = new HashSet<IPPEA_DATA_QandAQuestionMedia>();
        //public virtual ICollection<IPPEA_DATA_QandAAnswerMedia> IPPEA_DATA_QandAAnswerMedia { get; set; } = new HashSet<IPPEA_DATA_QandAAnswerMedia>();
        //public virtual ICollection<IPPEA_DATA_SalesTaxExemption> IPPEA_DATA_SalesTaxExemption { get; set; } = new HashSet<IPPEA_DATA_SalesTaxExemption>();
        //public virtual ICollection<IPPEA_DATA_ConversationMessageMedia> IPPEA_DATA_ConversationMessageMedia { get; set; } = new HashSet<IPPEA_DATA_ConversationMessageMedia>();
        //public virtual ICollection<IPPEA_DATA_PaidVendorBatch> IPPEA_DATA_PaidVendorBatch { get; set; } = new HashSet<IPPEA_DATA_PaidVendorBatch>();

    }
}
