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
    
    public partial class tbTimeDetail
    {
        public int TimeDetailId { get; set; }
        public int ClientID { get; set; }
        public System.DateTime Original_Date { get; set; }
        public int PMID { get; set; }
        public Nullable<decimal> Mgr_Time_In { get; set; }
        public Nullable<decimal> Mgr_Time_Out { get; set; }
        public Nullable<decimal> Mgr_Time_Mtg { get; set; }
        public Nullable<decimal> Total_CSS_Tickets { get; set; }
        public Nullable<decimal> Total_Calls { get; set; }
        public Nullable<decimal> Total_Call_Time { get; set; }
    
        public virtual tbClient tbClient { get; set; }
    }
}
