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
    
    public partial class Orders_Archive
    {
        public int uid { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public string DateOrdered { get; set; }
        public string SubTotal { get; set; }
        public string ShippingTotal { get; set; }
        public string HandlingTotal { get; set; }
        public string CountryTax { get; set; }
        public string StateTax { get; set; }
        public string PayMethod { get; set; }
        public string GiftCertificateTotal { get; set; }
        public string DownloadDate { get; set; }
        public Nullable<int> CustomerGroup { get; set; }
        public string DiscountsTotal { get; set; }
        public string TotalBilled { get; set; }
        public string AmountRemaining { get; set; }
        public Nullable<int> OrderNumber { get; set; }
        public string TotalAppliedDiscounts { get; set; }
        public string LocalTaxTotal { get; set; }
        public string Units { get; set; }
        public string GrandTotal { get; set; }
        public Nullable<int> PaymentsPending { get; set; }
        public Nullable<int> BOPaymentsPending { get; set; }
        public Nullable<int> Void { get; set; }
        public Nullable<int> Referrer { get; set; }
    }
}