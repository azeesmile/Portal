namespace Portal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CMS_Category
    {
        public CMS_Category()
        {
            CMSPages = new HashSet<CMSPage>();
        }

        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }

        public DateTime AddedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public short Status { get; set; }

        public virtual ICollection<CMSPage> CMSPages { get; set; }
    }
}
