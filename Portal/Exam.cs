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
    
    public partial class Exam
    {
        public int ExamId { get; set; }
        public System.DateTime AddedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public short Status { get; set; }
        public short ExamType { get; set; }
        public System.DateTime ExamDate { get; set; }
        public string Description { get; set; }
        public Nullable<int> Section_Id { get; set; }
        public Nullable<int> Course_Id { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Section Section { get; set; }
    }
}