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
    
    public partial class IPPEA_DATA_MergeProductLog
    {
        public int Id { get; set; }
        public int KeepProductId { get; set; }
        public int DeleteProductId { get; set; }
        public int EmployeeId { get; set; }
        public System.DateTimeOffset InsertDate { get; set; }
        public int MergeProductStatusId { get; set; }
        public System.DateTimeOffset RunDate { get; set; }
        public int FailedAttempts { get; set; }
    
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees { get; set; }
        public virtual IPPEA_DATA_Product IPPEA_DATA_Product { get; set; }
        public virtual IPPEA_DECODE_MergeProductStatus IPPEA_DECODE_MergeProductStatus { get; set; }
    }
}
