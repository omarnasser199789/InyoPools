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
    
    public partial class IPPEA_DATA_QandAAnswer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IPPEA_DATA_QandAAnswer()
        {
            this.IPPEA_DATA_QandAAnswer1 = new HashSet<IPPEA_DATA_QandAAnswer>();
            this.IPPEA_DATA_QandAAnswerMedia = new HashSet<IPPEA_DATA_QandAAnswerMedia>();
        }
    
        public int Id { get; set; }
        public int QandAQuestionId { get; set; }
        public string Answer { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public System.DateTimeOffset InsertDate { get; set; }
        public string IPAddress { get; set; }
        public string UserAgent { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public int QandAAnswerStatusId { get; set; }
        public Nullable<System.DateTimeOffset> LastStatusChangeDate { get; set; }
        public string OriginalAnswer { get; set; }
        public Nullable<System.DateTimeOffset> EmailSentDate { get; set; }
        public Nullable<int> VendorId { get; set; }
        public Nullable<int> ManufacturerId { get; set; }
        public string UserId { get; set; }
        public Nullable<int> ParentId { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual IPPEA_DATA_Customer IPPEA_DATA_Customer { get; set; }
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees { get; set; }
        public virtual IPPEA_DATA_Manufacturer IPPEA_DATA_Manufacturer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_QandAAnswer> IPPEA_DATA_QandAAnswer1 { get; set; }
        public virtual IPPEA_DATA_QandAAnswer IPPEA_DATA_QandAAnswer2 { get; set; }
        public virtual IPPEA_DECODE_QandAAnswerStatus IPPEA_DECODE_QandAAnswerStatus { get; set; }
        public virtual IPPEA_DATA_QandAQuestion IPPEA_DATA_QandAQuestion { get; set; }
        public virtual IPPEA_DATA_Vendor IPPEA_DATA_Vendor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IPPEA_DATA_QandAAnswerMedia> IPPEA_DATA_QandAAnswerMedia { get; set; }
    }
}