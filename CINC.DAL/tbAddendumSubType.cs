//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CINC.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbAddendumSubType
    {
        public tbAddendumSubType()
        {
            this.tbProducts = new HashSet<tbProduct>();
        }
    
        public int AddendumSubID { get; set; }
        public Nullable<int> AddendumID { get; set; }
        public string AddendumSub_Description { get; set; }
    
        public virtual tbAddendum tbAddendum { get; set; }
        public virtual ICollection<tbProduct> tbProducts { get; set; }
    }
}