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
    
    public partial class IPPEA_DATA_Product_Archive
    {
        public int ArchiveID { get; set; }
        public string ArchiveType { get; set; }
        public string ArchiveReason { get; set; }
        public int ArchiveUserID { get; set; }
        public System.DateTimeOffset ArchiveDt { get; set; }
        public int ID { get; set; }
        public int ManufacturerID { get; set; }
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ProductPage { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Length { get; set; }
        public Nullable<decimal> Width { get; set; }
        public string SmallImageName { get; set; }
        public string LargeImageName { get; set; }
        public bool IsActive { get; set; }
        public string ManufacturerCode { get; set; }
        public decimal Price { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public bool IsShippable { get; set; }
        public Nullable<decimal> ShipPrice { get; set; }
        public string ProductNotes { get; set; }
        public string Warranty { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyWords { get; set; }
        public bool IsPackage { get; set; }
        public bool IsPart { get; set; }
        public bool FreeShipping { get; set; }
        public System.DateTime DateAdded { get; set; }
        public bool ProductAvailability { get; set; }
        public Nullable<int> AvailabilityStatus { get; set; }
        public string AvailabilityNotes { get; set; }
        public bool NoShipIntl { get; set; }
        public bool ShipsAlone { get; set; }
        public bool IsEbayItem { get; set; }
        public bool IseBayItemUpdated { get; set; }
        public Nullable<int> StoreCategoryID { get; set; }
        public bool IsShoppingComItem { get; set; }
        public Nullable<int> ShoppingComCategoryID { get; set; }
        public bool IsNexTagItem { get; set; }
        public Nullable<int> NexTagCategoryID { get; set; }
        public bool IsShopzillaItem { get; set; }
        public Nullable<int> ShopzillaCategoryID { get; set; }
        public bool IsYahooShoppingItem { get; set; }
        public Nullable<int> YahooShoppingCategoryID { get; set; }
        public bool IsFroogleItem { get; set; }
        public Nullable<int> FroogleCategoryID { get; set; }
        public bool IsINYOPool { get; set; }
        public bool IsINYOWinter { get; set; }
        public bool IsFreightQuote { get; set; }
        public bool InXML { get; set; }
        public string PublicManufacturerCode { get; set; }
        public string Dimensions { get; set; }
        public bool NonBiddable { get; set; }
        public Nullable<int> FreightClass { get; set; }
        public bool CheckInActiveForInStock { get; set; }
        public bool NoDisplayPopularItems { get; set; }
        public string AltImage1 { get; set; }
        public string AltImage2 { get; set; }
        public string AltImage3 { get; set; }
        public string AltImage4 { get; set; }
        public string AltImage5 { get; set; }
        public string AltImage6 { get; set; }
        public string OldAlternatePartNumbers { get; set; }
        public bool ExpeditedShippingNotAvailable { get; set; }
        public bool NonReturnable { get; set; }
        public bool BypassLowMargin { get; set; }
        public bool IsBingShoppingItem { get; set; }
        public Nullable<int> BingShoppingCategoryID { get; set; }
        public string LongDescriptionOld { get; set; }
        public bool LongDescriptionCleaned { get; set; }
        public Nullable<int> ProductGroupID { get; set; }
        public Nullable<int> ProductGroupOrder { get; set; }
        public Nullable<decimal> RegularPrice { get; set; }
        public Nullable<decimal> RebateValue { get; set; }
        public Nullable<int> RebateMethodID { get; set; }
        public Nullable<int> ProductAttributeID { get; set; }
        public Nullable<bool> UnCheckIsActiveForNotInStock { get; set; }
        public string GTIN { get; set; }
        public Nullable<int> BackorderTypeID { get; set; }
        public Nullable<System.DateTime> BackorderDate { get; set; }
        public Nullable<bool> IncludeInactiveProductOnProductListing { get; set; }
        public Nullable<bool> SendProductAvailabilityEmail { get; set; }
        public Nullable<System.DateTimeOffset> DiscontinuedDate { get; set; }
        public Nullable<int> DiscontinuedReasonId { get; set; }
        public string HighRiskForFraudBy { get; set; }
        public Nullable<System.DateTimeOffset> HighRiskForFraudDate { get; set; }
        public string MarketingCategory { get; set; }
    
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees { get; set; }
    }
}
