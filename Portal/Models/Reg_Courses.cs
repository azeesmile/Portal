namespace Portal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reg_Courses
    {
        [Key]
        public int RegId { get; set; }

        public int Course_Id { get; set; }

        public int Teacher_Id { get; set; }

        public int Student_Id { get; set; }

        public double? GPA { get; set; }

        public DateTime AddedDate { get; set; }

        public short Status { get; set; }

        public virtual Course Course { get; set; }

        public virtual Student Student { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}
