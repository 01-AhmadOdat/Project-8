//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace api
{
    using System;
    using System.Collections.Generic;
    
    public partial class InRolement
    {
        public int Course_Student_Id { get; set; }
        public Nullable<int> Payment_ID { get; set; }
        public Nullable<int> Time_ID { get; set; }
        public string UserID { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Time Time { get; set; }
    }
}
