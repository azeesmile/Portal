namespace Portal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Answer")]
    public partial class Answer
    {
        public int AnswerId { get; set; }

        public int Feedback_Id { get; set; }

        [Required]
        [StringLength(500)]
        public string AnsDescription { get; set; }

        public virtual Feedback Feedback { get; set; }
    }
}
