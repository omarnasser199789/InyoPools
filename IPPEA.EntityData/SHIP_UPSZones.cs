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
    
    public partial class SHIP_UPSZones
    {
        public int ID { get; set; }
        public string OriginZip { get; set; }
        public string DestZip { get; set; }
        public Nullable<int> ZoneGround { get; set; }
        public Nullable<int> Zone3Day { get; set; }
        public Nullable<int> Zone2ndDay { get; set; }
        public Nullable<int> Zone2ndDayAM { get; set; }
        public Nullable<int> ZoneNextDaySaver { get; set; }
        public Nullable<int> ZoneNextDay { get; set; }
        public Nullable<int> ZoneNextDayAM { get; set; }
    }
}
