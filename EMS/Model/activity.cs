//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Activity
    {
        public int ID { get; set; }
        public int TopicID { get; set; }
        public int TypeID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual ActivityType ActivityType { get; set; }
        public virtual Topic Topic { get; set; }
    }
}
