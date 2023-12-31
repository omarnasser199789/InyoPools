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
    
    public partial class IPPEA_DATA_AccountsPayment_Archive
    {
        public int ArchiveID { get; set; }
        public string ArchiveType { get; set; }
        public string ArchiveReason { get; set; }
        public int ArchiveUserID { get; set; }
        public System.DateTimeOffset ArchiveDt { get; set; }
        public int ID { get; set; }
        public int InvoiceID { get; set; }
        public Nullable<int> OrderGroupID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public string UserID { get; set; }
        public Nullable<System.DateTime> Entrydate { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> BillingTypeID { get; set; }
        public byte[] CCNumber { get; set; }
        public string CCID { get; set; }
        public string CCExpDate { get; set; }
        public string CCNameOnCard { get; set; }
        public string BAAccountName { get; set; }
        public string BABankName { get; set; }
        public byte[] BARoutingNumber { get; set; }
        public byte[] BAAccountNumber { get; set; }
        public Nullable<int> BACheckNumber { get; set; }
        public Nullable<decimal> CTCreditLimit { get; set; }
        public Nullable<int> AuthNetTransLogID { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string PPUserID { get; set; }
        public string PPTransID { get; set; }
        public Nullable<int> RepID { get; set; }
        public string CHCheckNumber { get; set; }
        public Nullable<int> CreditBillingTypeID { get; set; }
        public Nullable<System.DateTime> PPTransDate { get; set; }
        public Nullable<int> PTTransLogID { get; set; }
    
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees { get; set; }
    }
}
