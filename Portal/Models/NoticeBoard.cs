namespace Portal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NoticeBoard")]
    public partial class NoticeBoard
    {
        [Key]
        public int NewsId { get; set; }

        [Required]
        [StringLength(300)]
        public string NewsHeading { get; set; }

        [Required]
        public string Detail { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        public DateTime AddedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public short Status { get; set; }
    }
}
