namespace Portal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Feedback")]
    public partial class Feedback
    {
        public Feedback()
        {
            Answers = new HashSet<Answer>();
        }

        [Key]
        public int ReportId { get; set; }

        public int Teacher_Id { get; set; }

        public int Student_Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}
