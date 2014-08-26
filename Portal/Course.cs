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
    
    public partial class Course
    {
        public Course()
        {
            this.Exams = new HashSet<Exam>();
            this.Lectures = new HashSet<Lecture>();
            this.Reg_Courses = new HashSet<Reg_Courses>();
        }
    
        public int CourseId { get; set; }
        public int Semester_Id { get; set; }
        public System.DateTime AddedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public short Status { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public bool IsElective { get; set; }
        public int CreditHours { get; set; }
    
        public virtual Semester Semester { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<Lecture> Lectures { get; set; }
        public virtual ICollection<Reg_Courses> Reg_Courses { get; set; }
    }
}