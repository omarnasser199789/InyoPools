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
    
    public partial class OrderPayment
    {
        public int uid { get; set; }
        public Nullable<int> Type { get; set; }
        public string PONumber { get; set; }
        public string CheckNumber { get; set; }
        public string BankName { get; set; }
        public string RoutingNumber { get; set; }
        public string AccountNumber { get; set; }
        public string CreditCardNumber { get; set; }
        public string CardType { get; set; }
        public string SecurityCode { get; set; }
        public string ExpireMonth { get; set; }
        public string ExpireYear { get; set; }
        public Nullable<int> OrderID { get; set; }
        public string StartMonth { get; set; }
        public string StartYear { get; set; }
        public string IssueNumber { get; set; }
        public string Last4Digits { get; set; }
        public bool IsDirty { get; set; }
    }
}
