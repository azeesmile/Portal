namespace Portal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        public Course()
        {
            Exams = new HashSet<Exam>();
            Lectures = new HashSet<Lecture>();
            Reg_Courses = new HashSet<Reg_Courses>();
        }

        public int CourseId { get; set; }

        public int Semester_Id { get; set; }

        public DateTime AddedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public short Status { get; set; }

        [Required]
        [StringLength(100)]
        public string CourseName { get; set; }

        [Required]
        [StringLength(20)]
        public string CourseCode { get; set; }

        public bool IsElective { get; set; }

        public int CreditHours { get; set; }

        public virtual Semester Semester { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }

        public virtual ICollection<Lecture> Lectures { get; set; }

        public virtual ICollection<Reg_Courses> Reg_Courses { get; set; }
    }
}
