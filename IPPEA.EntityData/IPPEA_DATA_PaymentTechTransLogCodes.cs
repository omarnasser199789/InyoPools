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
    
    public partial class IPPEA_DATA_PaymentTechTransLogCodes
    {
        public int ID { get; set; }
        public int PaymentTechTransLogID { get; set; }
        public int PaymentTechAfsCodeID { get; set; }
    
        public virtual IPPEA_DATA_PaymentTechTransLog IPPEA_DATA_PaymentTechTransLog { get; set; }
        public virtual IPPEA_DECODE_PaymentTechAfsCodes IPPEA_DECODE_PaymentTechAfsCodes { get; set; }
    }
}