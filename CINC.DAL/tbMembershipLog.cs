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
    
    public partial class tbMembershipLog
    {
        public int MembershipID { get; set; }
        public bool pooltag_appln_rcvd { get; set; }
        public string indem_waiver_rcvd { get; set; }
        public Nullable<System.DateTime> appln_mailed { get; set; }
        public bool mail_merge_exported { get; set; }
        public bool lifeguard_exported { get; set; }
        public Nullable<System.DateTime> PassMailed { get; set; }
        public Nullable<bool> AssociationMember { get; set; }
    
        public virtual tbMembership tbMembership { get; set; }
    }
}
