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
    
    public partial class IPPEA_DATA_TransLog
    {
        public int TranID { get; set; }
        public Nullable<int> TranTypeID { get; set; }
        public Nullable<int> ObjectTypeID { get; set; }
        public Nullable<int> ObjectKey { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public Nullable<System.DateTime> TranDate { get; set; }
        public Nullable<double> TranNbr { get; set; }
        public string UserID { get; set; }
    }
}
