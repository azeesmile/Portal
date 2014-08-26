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
    
    public partial class Teacher
    {
        public Teacher()
        {
            this.Feedbacks = new HashSet<Feedback>();
            this.Lectures = new HashSet<Lecture>();
            this.Reg_Courses = new HashSet<Reg_Courses>();
            this.Students = new HashSet<Student>();
            this.Sections = new HashSet<Section>();
        }
    
        public int TeacherId { get; set; }
        public System.DateTime AddedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public short Status { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string CNIC { get; set; }
        public string Qulification { get; set; }
        public string Designation { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string MobileNumber { get; set; }
        public string LandlineNumber { get; set; }
        public bool Gender { get; set; }
        public Nullable<int> Age { get; set; }
        public string UserName { get; set; }
        public string Passwrd { get; set; }
    
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Lecture> Lectures { get; set; }
        public virtual ICollection<Reg_Courses> Reg_Courses { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
    }
}