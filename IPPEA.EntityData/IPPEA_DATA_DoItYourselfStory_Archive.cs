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
    
    public partial class IPPEA_DATA_DoItYourselfStory_Archive
    {
        public int ArchiveID { get; set; }
        public string ArchiveType { get; set; }
        public string ArchiveReason { get; set; }
        public int ArchiveUserID { get; set; }
        public System.DateTimeOffset ArchiveDt { get; set; }
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Problem { get; set; }
        public string OriginalProblem { get; set; }
        public string Solution { get; set; }
        public string OriginalSolution { get; set; }
        public int OriginalProductId { get; set; }
        public int StoryStatus { get; set; }
        public string ToolsOther { get; set; }
        public int ProjectLengthId { get; set; }
        public int DifficultyId { get; set; }
        public System.DateTimeOffset InsertDate { get; set; }
        public string IPAddress { get; set; }
        public string UserAgent { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<System.DateTimeOffset> EmailSentDate { get; set; }
    
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees { get; set; }
    }
}
