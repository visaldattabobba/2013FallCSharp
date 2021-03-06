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
    
    public partial class User
    {
        public User()
        {
            this.ContactLists = new HashSet<ContactList>();
            this.Helps = new HashSet<Help>();
            this.Emails = new HashSet<Email>();
            this.Schedules = new HashSet<Schedule>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Business { get; set; }
        public string General { get; set; }
        public int ProfileRegistrationNum { get; set; }
    
        public virtual PersonalInfo PersonalInfo { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual ICollection<ContactList> ContactLists { get; set; }
        public virtual ICollection<Help> Helps { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
