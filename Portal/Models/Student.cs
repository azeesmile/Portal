namespace Portal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        public Student()
        {
            Reg_Courses = new HashSet<Reg_Courses>();
            Teachers = new HashSet<Teacher>();
        }

        public int StudentId { get; set; }

        [Required]
        [StringLength(30)]
        public string RegistrationNumber { get; set; }

        public int Section_Id { get; set; }

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
        [StringLength(100)]
        public string FatherName { get; set; }

        [Required]
        [StringLength(20)]
        public string CNIC { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

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

        public int Age { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        public virtual ICollection<Reg_Courses> Reg_Courses { get; set; }

        public virtual Section Section { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
