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
    
    public partial class tbMembership
    {
        public int MembershipID { get; set; }
        public int MemberID { get; set; }
        public Nullable<int> cal_year { get; set; }
        public string adult1 { get; set; }
        public string adult2 { get; set; }
        public string child1 { get; set; }
        public string child2 { get; set; }
        public string child3 { get; set; }
        public string child4 { get; set; }
        public string child5 { get; set; }
        public Nullable<decimal> amount_paid { get; set; }
        public Nullable<System.DateTime> date_paid { get; set; }
        public string check_no { get; set; }
        public string note { get; set; }
        public Nullable<int> num_passes { get; set; }
        public int statusID { get; set; }
        public Nullable<int> membership_plan { get; set; }
        public string PassNumber { get; set; }
    
        public virtual tbClientPoolFee tbClientPoolFee { get; set; }
        public virtual tbMember tbMember { get; set; }
        public virtual tbMembershipLog tbMembershipLog { get; set; }
    }
}
