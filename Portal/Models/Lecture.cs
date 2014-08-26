namespace Portal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lecture")]
    public partial class Lecture
    {
        public int LectureId { get; set; }

        public int Teacher_Id { get; set; }

        public int Section_Id { get; set; }

        public int Course_Id { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [StringLength(200)]
        public string FileUrl { get; set; }

        public DateTime? AddedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public short? Status { get; set; }

        public virtual Course Course { get; set; }

        public virtual Section Section { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}
