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
    
    public partial class tbBillingFrequency
    {
        public tbBillingFrequency()
        {
            this.tbBillingDatas = new HashSet<tbBillingData>();
        }
    
        public int tbBillingFrequencyId { get; set; }
        public string tbBillingFrequencyName { get; set; }
    
        public virtual ICollection<tbBillingData> tbBillingDatas { get; set; }
    }
}
