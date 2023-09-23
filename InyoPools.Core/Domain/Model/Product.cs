using InyoPools.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyoPools.Core.Domain.Model
{
    public class Product
    {
        public int ID { get; set; }
        public int ManufacturerID { get; set; }
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ProductPage { get; set; }
        public decimal Weight { get; set; }
        public decimal? Height { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public string SmallImageName { get; set; }
        public string LargeImageName { get; set; }
        public bool IsActive { get; set; }
        public string ManufacturerCode { get; set; }
        public decimal Price { get; set; }
        public decimal? SalePrice { get; set; }
        public bool IsShippable { get; set; }
        public decimal? ShipPrice { get; set; }
        public string ProductNotes { get; set; }
        public string Warranty { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyWords { get; set; }
        public bool IsPackage { get; set; }
        public bool IsPart { get; set; }
        public bool FreeShipping { get; set; }
        public DateTime DateAdded { get; set; }
        public bool ProductAvailability { get; set; }
        public int? AvailabilityStatus { get; set; }
        public string AvailabilityNotes { get; set; }
        public bool NoShipIntl { get; set; }
        public bool ShipsAlone { get; set; }
        public bool IsEbayItem { get; set; }
        public bool IseBayItemUpdated { get; set; }
        public int? StoreCategoryID { get; set; }
        public bool IsShoppingComItem { get; set; }
        public int? ShoppingComCategoryID { get; set; }
        public bool IsNexTagItem { get; set; }
        public int? NexTagCategoryID { get; set; }
        public bool IsShopzillaItem { get; set; }
        public int? ShopzillaCategoryID { get; set; }
        public bool IsYahooShoppingItem { get; set; }
        public int? YahooShoppingCategoryID { get; set; }
        public bool IsFroogleItem { get; set; }
        public int? FroogleCategoryID { get; set; }
        public bool IsINYOPool { get; set; }
        public bool IsINYOWinter { get; set; }
        public bool IsFreightQuote { get; set; }
        public bool InXML { get; set; }
        public string PublicManufacturerCode { get; set; }
        public string Dimensions { get; set; }
        public bool NonBiddable { get; set; }
        public int? FreightClass { get; set; }
        public bool CheckInActiveForInStock { get; set; }
        public bool NoDisplayPopularItems { get; set; }
        public string AltImage1 { get; set; }
        public string AltImage2 { get; set; }
        public string AltImage3 { get; set; }
        public string AltImage4 { get; set; }
        public string AltImage5 { get; set; }
        public string AltImage6 { get; set; }
        public bool ExpeditedShippingNotAvailable { get; set; }
        public bool NonReturnable { get; set; }
        public bool BypassLowMargin { get; set; }
        public bool IsBingShoppingItem { get; set; }
        public int? BingShoppingCategoryID { get; set; }
        public string LongDescriptionOld { get; set; }
        public bool LongDescriptionCleaned { get; set; }
        public int? ProductGroupID { get; set; }
        public int? ProductGroupOrder { get; set; }
        public decimal? RegularPrice { get; set; }
        public decimal? RebateValue { get; set; }
        public int? RebateMethodID { get; set; }
        public int? ProductAttributeID { get; set; }
        public string OldAlternatePartNumbers { get; set; }
        public bool UnCheckIsActiveForNotInStock { get; set; }
        public string GTIN { get; set; }
        public int? BackorderTypeID { get; set; }
        public DateTime? BackorderDate { get; set; }
        public bool IncludeInactiveProductOnProductListing { get; set; }
        public bool SendProductAvailabilityEmail { get; set; }
        public DateTimeOffset? DiscontinuedDate { get; set; }
        public DiscontinuedReason? DiscontinuedReasonId { get; set; }
        public string HighRiskForFraudBy { get; set; }
        public DateTimeOffset? HighRiskForFraudDate { get; set; }
        public string MarketingCategory { get; set; }


        //public virtual ICollection<IPPEA_DATA_PartProducts> IPPEA_DATA_PartProducts { get; set; } = new HashSet<IPPEA_DATA_PartProducts>();
        //public virtual IPPEA_DATA_ProductGroup IPPEA_DATA_ProductGroup { get; set; }
        //public virtual ICollection<IPPEA_DATA_ProductSpecifications> IPPEA_DATA_ProductSpecifications { get; set; } = new HashSet<IPPEA_DATA_ProductSpecifications>();
        //public virtual ICollection<IPPEA_DATA_ProductType> IPPEA_DATA_ProductType { get; set; } = new HashSet<IPPEA_DATA_ProductType>();
        //public virtual IPPEA_DATA_Manufacturer IPPEA_DATA_Manufacturer { get; set; }
        //public virtual IPPEA_DECODE_RebateMethod IPPEA_DECODE_RebateMethod { get; set; }
        //public virtual IPPEA_DATA_ProductAttribute IPPEA_DATA_ProductAttribute { get; set; }
        //public virtual ICollection<IPPEA_DATA_ProductAttribute> IPPEA_DATA_ProductAttribute_OldProductID { get; set; } = new HashSet<IPPEA_DATA_ProductAttribute>();
        //public virtual ICollection<IPPEA_DATA_ManualProduct> IPPEA_DATA_ManualProduct { get; set; } = new HashSet<IPPEA_DATA_ManualProduct>();
        //public virtual ICollection<IPPEA_DATA_ProductReviewRelation> IPPEA_DATA_ProductReviewRelation { get; set; } = new HashSet<IPPEA_DATA_ProductReviewRelation>();
        //public virtual ICollection<IPPEA_DATA_PartChartRows> IPPEA_DATA_PartChartRows { get; set; } = new HashSet<IPPEA_DATA_PartChartRows>();
        //public virtual ICollection<IPPEA_DATA_ShoppingCartItem> IPPEA_DATA_ShoppingCartItem { get; set; } = new HashSet<IPPEA_DATA_ShoppingCartItem>();
        //public virtual ICollection<IPPEA_DATA_CheckoutItem> IPPEA_DATA_CheckoutItem { get; set; } = new HashSet<IPPEA_DATA_CheckoutItem>();
        //public virtual ICollection<IPPEA_DATA_ProductPackages> IPPEA_DATA_ProductPackages_PackageID { get; set; } = new HashSet<IPPEA_DATA_ProductPackages>();
        //public virtual ICollection<IPPEA_DATA_ProductPackages> IPPEA_DATA_ProductPackages_ProductID { get; set; } = new HashSet<IPPEA_DATA_ProductPackages>();
        //public virtual ICollection<IPPEA_DATA_VendorProducts> IPPEA_DATA_VendorProducts { get; set; } = new HashSet<IPPEA_DATA_VendorProducts>();
        //public virtual ICollection<IPPEA_DATA_QuoteItems> IPPEA_DATA_QuoteItems { get; set; } = new HashSet<IPPEA_DATA_QuoteItems>();
        //public virtual ICollection<IPPEA_DATA_CheckoutItemProduct> IPPEA_DATA_CheckoutItemProduct { get; set; } = new HashSet<IPPEA_DATA_CheckoutItemProduct>();
        //public virtual ICollection<IPPEA_DATA_ProductMedia> IPPEA_DATA_ProductMedia { get; set; } = new HashSet<IPPEA_DATA_ProductMedia>();
        //public virtual ICollection<IPPEA_DATA_QandAProducts> IPPEA_DATA_QandAProducts { get; set; } = new HashSet<IPPEA_DATA_QandAProducts>();
        //public virtual ICollection<IPPEA_DATA_QandAQuestion> IPPEA_DATA_QandAQuestion { get; set; } = new HashSet<IPPEA_DATA_QandAQuestion>();
        //public virtual ICollection<IPPEA_DATA_OrderFormLineItem> IPPEA_DATA_OrderFormLineItem { get; set; } = new HashSet<IPPEA_DATA_OrderFormLineItem>();


        //public virtual ICollection<IPPEA_DATA_HowToPageProductRelation> IPPEA_DATA_HowToPageProductRelation { get; set; } = new HashSet<IPPEA_DATA_HowToPageProductRelation>();
        //public virtual ICollection<IPPEA_DATA_ProductAlternatePartNumbers> IPPEA_DATA_ProductAlternatePartNumbers { get; set; } = new HashSet<IPPEA_DATA_ProductAlternatePartNumbers>();
        //public virtual ICollection<IPPEA_DATA_ProductShipMethods> IPPEA_DATA_ProductShipMethods { get; set; } = new HashSet<IPPEA_DATA_ProductShipMethods>();
        //public virtual ICollection<IPPEA_DATA_Recommendations> IPPEA_DATA_Recommendations_ProductID { get; set; } = new HashSet<IPPEA_DATA_Recommendations>();
        //public virtual ICollection<IPPEA_DATA_Recommendations> IPPEA_DATA_Recommendations_RecommendedByProductID { get; set; } = new HashSet<IPPEA_DATA_Recommendations>();
        //public virtual ICollection<IPPEA_DATA_CouponProducts> IPPEA_DATA_CouponProducts { get; set; } = new HashSet<IPPEA_DATA_CouponProducts>();
        //public virtual ICollection<IPPEA_DATA_DoItYourselfStory> IPPEA_DATA_DoItYourselfStory { get; set; } = new HashSet<IPPEA_DATA_DoItYourselfStory>();
        //public virtual ICollection<IPPEA_DATA_DoItYourselfStoryProducts> IPPEA_DATA_DoItYourselfStoryProducts { get; set; } = new HashSet<IPPEA_DATA_DoItYourselfStoryProducts>();
        //public virtual ICollection<IPPEA_DATA_ProductAttributeProducts> IPPEA_DATA_ProductAttributeProducts { get; set; } = new HashSet<IPPEA_DATA_ProductAttributeProducts>();
        //public virtual ICollection<IPPEA_DATA_ProductSocialMediaSubmission> IPPEA_DATA_ProductSocialMediaSubmission { get; set; } = new HashSet<IPPEA_DATA_ProductSocialMediaSubmission>();
        //public virtual ICollection<IPPEA_DATA_QandAProductOptOut> IPPEA_DATA_QandAProductOptOut { get; set; } = new HashSet<IPPEA_DATA_QandAProductOptOut>();
        //public virtual IPPEA_DECODE_ProductAvailability IPPEA_DECODE_ProductAvailability { get; set; }
        //public virtual IPPEA_DECODE_BackorderType IPPEA_DECODE_BackorderType { get; set; }
        //public virtual ICollection<IPPEA_DATA_ConversationProductMentions> IPPEA_DATA_ConversationProductMentions { get; set; } = new HashSet<IPPEA_DATA_ConversationProductMentions>();
        //public virtual ICollection<IPPEA_DATA_WmsOrderProduct> IPPEA_DATA_WmsOrderProduct { get; set; } = new HashSet<IPPEA_DATA_WmsOrderProduct>();
        //public virtual ICollection<IPPEA_DATA_WmsJobs> IPPEA_DATA_WmsJobs { get; set; } = new HashSet<IPPEA_DATA_WmsJobs>();
        //public virtual ICollection<IPPEA_DATA_WmsJobLog> IPPEA_DATA_WmsJobLog { get; set; } = new HashSet<IPPEA_DATA_WmsJobLog>();
        //public virtual ICollection<IPPEA_DATA_ProductAvailability> IPPEA_DATA_ProductAvailability { get; set; } = new HashSet<IPPEA_DATA_ProductAvailability>();
        //public virtual IPPEA_DECODE_ProductDiscontinuedReason IPPEA_DECODE_ProductDiscontinuedReason { get; set; }
        //public virtual ICollection<IPPEA_DATA_MergeProduct> IPPEA_DATA_MergeProduct { get; set; } = new HashSet<IPPEA_DATA_MergeProduct>();
        //public virtual ICollection<IPPEA_DATA_MergeProductLog> IPPEA_DATA_MergeProductLog { get; set; } = new HashSet<IPPEA_DATA_MergeProductLog>();





    }
}
