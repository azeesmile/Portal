//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Portal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reg_Courses
    {
        public int RegId { get; set; }
        public int Course_Id { get; set; }
        public int Teacher_Id { get; set; }
        public int Student_Id { get; set; }
        public Nullable<double> GPA { get; set; }
        public System.DateTime AddedDate { get; set; }
        public short Status { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
