namespace Portal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Semester")]
    public partial class Semester
    {
        public Semester()
        {
            Courses = new HashSet<Course>();
            Sections = new HashSet<Section>();
        }

        public int SemesterId { get; set; }

        [Required]
        [StringLength(20)]
        public string SemesterName { get; set; }

        public DateTime AddedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public short Status { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Section> Sections { get; set; }
    }
}
