namespace Portal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CMSPage")]
    public partial class CMSPage
    {
        public int CMSPageId { get; set; }

        public int CMSCategory_Id { get; set; }

        [Required]
        public string CMSPageContent { get; set; }

        [Required]
        public string CMSPageHeading { get; set; }

        public DateTime AddedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public short Status { get; set; }

        public virtual CMS_Category CMS_Category { get; set; }
    }
}
