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
    
    public partial class tbNewManagementCompany
    {
        public int NewManagementCompanyId { get; set; }
        public int ClientID { get; set; }
        public string NewCompanyName { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public Nullable<int> StateID { get; set; }
        public Nullable<int> Zip { get; set; }
        public string InsertBy { get; set; }
        public Nullable<System.DateTime> InsertTime { get; set; }
    
        public virtual tbClient tbClient { get; set; }
    }
}
