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
    
    public partial class GalleryType
    {
        public GalleryType()
        {
            this.Galleries = new HashSet<Gallery>();
        }
    
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public System.DateTime AddedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public short Status { get; set; }
    
        public virtual ICollection<Gallery> Galleries { get; set; }
    }
}
