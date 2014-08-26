namespace Portal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gallery")]
    public partial class Gallery
    {
        public int GalleryId { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [StringLength(200)]
        public string FriendlyName { get; set; }

        public int Type_Id { get; set; }

        public DateTime AddedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public short Status { get; set; }

        public virtual GalleryType GalleryType { get; set; }
    }
}
