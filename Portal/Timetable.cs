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
    
    public partial class Timetable
    {
        public int TimetableId { get; set; }
        public int Section_Id { get; set; }
        public string Day { get; set; }
        public string Period1 { get; set; }
        public string Period2 { get; set; }
        public string Period3 { get; set; }
        public string Period4 { get; set; }
        public string Period5 { get; set; }
        public string Period6 { get; set; }
        public string Period7 { get; set; }
        public string Period8 { get; set; }
        public string Period9 { get; set; }
        public System.DateTime AddedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public short Status { get; set; }
    
        public virtual Section Section { get; set; }
    }
}