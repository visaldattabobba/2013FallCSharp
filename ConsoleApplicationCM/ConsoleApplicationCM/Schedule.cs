//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplicationCM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedule
    {
        public int SNum { get; set; }
        public string S_Time { get; set; }
        public string S_Next { get; set; }
        public string ScheduleCreate { get; set; }
        public int UserId { get; set; }
    
        public virtual User User { get; set; }
    }
}
