using InyoPools.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyoPools.Core.Domain.Model
{
    public class ProductCategory    
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int? ParentID { get; set; }
        public int ParentLevel { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string CategoryPage { get; set; }
        public bool IsActive { get; set; }
        public string ImageName { get; set; }
        public string PageFooter { get; set; }
        public string PageHeader { get; set; }
        public bool DisplayProductListing { get; set; }
        public bool OverridePhysicalFile { get; set; }
        public string GoogleConversionLabel { get; set; }
        public decimal? GoogleConversionValue { get; set; }
        public string PageTitle { get; set; }
        public string PageDescription { get; set; }
        public string PageKeywords { get; set; }
        public string PageH1 { get; set; }
        public bool DisplayOnNavigation { get; set; }
        public string NavigationTitle { get; set; }
        public string NavigationAdvertisementHeading { get; set; }
        public string NavigationAdvertisementImagePath { get; set; }
        public string NavigationAdvertisementText { get; set; }
        public CategoryPage PageTypeId { get; set; }
        public bool RenderNewVersion { get; set; }



        public virtual ICollection<ProductCategory> Subcategories { get; set; }

        [ForeignKey("ParentID")]
        public virtual ProductCategory ParentCategory { get; set; }



        //public virtual ICollection<ProductType> ProductType { get; set; } = new HashSet<ProductType>();
        //public virtual ICollection<ProductCategoryRelated> IPPEA_DATA_ProductCategoryRelated_CategoryID { get; set; } = new HashSet<ProductCategoryRelated>();
        //public virtual ICollection<ProductCategoryRelated> IPPEA_DATA_ProductCategoryRelated_RelatedCategoryID { get; set; } = new HashSet<ProductCategoryRelated>();
        //public virtual ICollection<ProductCategoryMedia> IPPEA_DATA_ProductCategoryMedia { get; set; } = new HashSet<ProductCategoryMedia>();
        //public virtual IPPEA_DECODE_CategoryPageTypes IPPEA_DECODE_CategoryPageTypes { get; set; }
        //public virtual IPPEA_DATA_PartCategory IPPEA_DATA_PartCategory { get; set; }
        //public virtual ICollection<IPPEA_DATA_VendorProductCategoryRank> IPPEA_DATA_VendorProductCategoryRank { get; set; } = new HashSet<IPPEA_DATA_VendorProductCategoryRank>();

    }
}
