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
    
    public partial class IPPEA_DATA_DoItYourselfTools
    {
        public int Id { get; set; }
        public int StoryId { get; set; }
        public int ToolId { get; set; }
    
        public virtual IPPEA_DATA_DoItYourselfStory IPPEA_DATA_DoItYourselfStory { get; set; }
        public virtual IPPEA_DECODE_DiyTools IPPEA_DECODE_DiyTools { get; set; }
    }
}
