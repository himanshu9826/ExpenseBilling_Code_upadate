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
    
    public partial class tbClient
    {
        public tbClient()
        {
            this.tbBillingDatas = new HashSet<tbBillingData>();
            this.tbClientManagementDatas = new HashSet<tbClientManagementData>();
            this.tbClientContracts = new HashSet<tbClientContract>();
            this.tbMembers = new HashSet<tbMember>();
            this.tbNewManagementCompanies = new HashSet<tbNewManagementCompany>();
            this.tbPreviousManagementCompanies = new HashSet<tbPreviousManagementCompany>();
            this.tbTimeDetails = new HashSet<tbTimeDetail>();
        }
    
        public int ClientID { get; set; }
        public string Client_Name { get; set; }
        public string website_url { get; set; }
        public bool Active { get; set; }
        public string Fed_tax_id { get; set; }
        public Nullable<int> ServiceTypeID { get; set; }
        public Nullable<int> RegionID { get; set; }
        public Nullable<System.DateTime> Date_To_New_Mngmnt { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public Nullable<int> StateID { get; set; }
        public Nullable<decimal> ZipCode { get; set; }
        public string Insertby { get; set; }
        public Nullable<System.DateTime> InsertTime { get; set; }
        public Nullable<int> PMID { get; set; }
        public Nullable<int> PIID { get; set; }
    
        public virtual ICollection<tbBillingData> tbBillingDatas { get; set; }
        public virtual ICollection<tbClientManagementData> tbClientManagementDatas { get; set; }
        public virtual ICollection<tbClientContract> tbClientContracts { get; set; }
        public virtual ICollection<tbMember> tbMembers { get; set; }
        public virtual ICollection<tbNewManagementCompany> tbNewManagementCompanies { get; set; }
        public virtual ICollection<tbPreviousManagementCompany> tbPreviousManagementCompanies { get; set; }
        public virtual ICollection<tbTimeDetail> tbTimeDetails { get; set; }
    }
}
