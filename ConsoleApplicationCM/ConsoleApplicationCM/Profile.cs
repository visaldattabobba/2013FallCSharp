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
    
    public partial class Profile
    {
        public int RegistrationNum { get; set; }
        public string RegistrationDate { get; set; }
        public string Picture { get; set; }
    
        public virtual User User { get; set; }
    }
}