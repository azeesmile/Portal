namespace Portal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GalleryType")]
    public partial class GalleryType
    {
        public GalleryType()
        {
            Galleries = new HashSet<Gallery>();
        }

        [Key]
        public int TypeId { get; set; }

        [Required]
        [StringLength(200)]
        public string TypeName { get; set; }

        public DateTime AddedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public short Status { get; set; }

        public virtual ICollection<Gallery> Galleries { get; set; }
    }
}
