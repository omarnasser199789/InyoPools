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
    
    public partial class IPPEA_DATA_ConversationVendorMentions
    {
        public int Id { get; set; }
        public int ConversationMessageId { get; set; }
        public int VendorId { get; set; }
        public string Email { get; set; }
        public string EmailField { get; set; }
    
        public virtual IPPEA_DATA_ConversationMessage IPPEA_DATA_ConversationMessage { get; set; }
        public virtual IPPEA_DATA_Vendor IPPEA_DATA_Vendor { get; set; }
    }
}
