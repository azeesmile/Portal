namespace Portal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Section")]
    public partial class Section
    {
        public Section()
        {
            Exams = new HashSet<Exam>();
            Lectures = new HashSet<Lecture>();
            Timetables = new HashSet<Timetable>();
            Students = new HashSet<Student>();
            Teachers = new HashSet<Teacher>();
        }

        public int SectionId { get; set; }

        [Required]
        [StringLength(20)]
        public string SectionName { get; set; }

        public DateTime AddedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public short Status { get; set; }

        public int Semester_Id { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }

        public virtual ICollection<Lecture> Lectures { get; set; }

        public virtual ICollection<Timetable> Timetables { get; set; }

        public virtual Semester Semester { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
