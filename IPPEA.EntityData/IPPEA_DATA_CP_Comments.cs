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
    
    public partial class IPPEA_DATA_CP_Comments
    {
        public int ID { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public Nullable<int> CommentTypeID { get; set; }
        public string Comment { get; set; }
        public string UserName { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<bool> Show { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> StatusSnapShotID { get; set; }
    }
}
