namespace Portal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Teacher")]
    public partial class Teacher
    {
        public Teacher()
        {
            Feedbacks = new HashSet<Feedback>();
            Lectures = new HashSet<Lecture>();
            Reg_Courses = new HashSet<Reg_Courses>();
            Students = new HashSet<Student>();
            Sections = new HashSet<Section>();
        }

        public int TeacherId { get; set; }

        public DateTime AddedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public short Status { get; set; }

        [Required]
        [StringLength(50)]
        public string FName { get; set; }

        [Required]
        [StringLength(50)]
        public string LName { get; set; }

        [Required]
        [StringLength(20)]
        public string CNIC { get; set; }

        [Required]
        [StringLength(100)]
        public string Qulification { get; set; }

        [Required]
        [StringLength(50)]
        public string Designation { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }

        [StringLength(20)]
        public string MobileNumber { get; set; }

        [StringLength(20)]
        public string LandlineNumber { get; set; }

        public bool Gender { get; set; }

        public int? Age { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(20)]
        public string Passwrd { get; set; }

        public virtual ICollection<Feedback> Feedbacks { get; set; }

        public virtual ICollection<Lecture> Lectures { get; set; }

        public virtual ICollection<Reg_Courses> Reg_Courses { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public virtual ICollection<Section> Sections { get; set; }
    }
}
