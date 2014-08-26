//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Portal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lecture
    {
        public int LectureId { get; set; }
        public int Teacher_Id { get; set; }
        public int Section_Id { get; set; }
        public int Course_Id { get; set; }
        public string Description { get; set; }
        public string FileUrl { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<short> Status { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Section Section { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
