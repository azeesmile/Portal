namespace Portal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Exam")]
    public partial class Exam
    {
        public int ExamId { get; set; }

        public DateTime AddedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public short Status { get; set; }

        public short ExamType { get; set; }

        public DateTime ExamDate { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        public int? Section_Id { get; set; }

        public int? Course_Id { get; set; }

        public virtual Course Course { get; set; }

        public virtual Section Section { get; set; }
    }
}
