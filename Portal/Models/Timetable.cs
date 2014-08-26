namespace Portal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Timetable")]
    public partial class Timetable
    {
        public int TimetableId { get; set; }

        public int Section_Id { get; set; }

        [Required]
        [StringLength(15)]
        public string Day { get; set; }

        [StringLength(100)]
        public string Period1 { get; set; }

        [StringLength(100)]
        public string Period2 { get; set; }

        [StringLength(100)]
        public string Period3 { get; set; }

        [StringLength(100)]
        public string Period4 { get; set; }

        [StringLength(100)]
        public string Period5 { get; set; }

        [StringLength(100)]
        public string Period6 { get; set; }

        [StringLength(100)]
        public string Period7 { get; set; }

        [StringLength(100)]
        public string Period8 { get; set; }

        [StringLength(100)]
        public string Period9 { get; set; }

        public DateTime AddedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public short Status { get; set; }

        public virtual Section Section { get; set; }
    }
}
