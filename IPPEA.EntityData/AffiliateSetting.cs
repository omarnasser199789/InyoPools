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
    
    public partial class AffiliateSetting
    {
        public int uid { get; set; }
        public Nullable<int> Active { get; set; }
        public string terms { get; set; }
        public string Payout { get; set; }
        public string MinPayout { get; set; }
        public Nullable<int> PayOutRule { get; set; }
        public int CommissionType { get; set; }
        public string FlatFee { get; set; }
    }
}
