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
    
    public partial class tbClientContract
    {
        public int ContractsID { get; set; }
        public int ClientID { get; set; }
        public Nullable<bool> ActiveContract { get; set; }
        public Nullable<int> ServiceTypeID { get; set; }
        public Nullable<int> StateID { get; set; }
        public string Initial_Term_Years { get; set; }
        public Nullable<bool> CAM_Contract { get; set; }
        public string Contract_Version { get; set; }
        public Nullable<System.DateTime> Date_Signed { get; set; }
        public Nullable<System.DateTime> GoLiveDate { get; set; }
        public Nullable<decimal> NoUnits { get; set; }
        public Nullable<decimal> Original_Contract_Amount { get; set; }
        public Nullable<decimal> Startup_Fee { get; set; }
        public Nullable<bool> CPI { get; set; }
        public Nullable<decimal> CurrentContractAmount { get; set; }
        public Nullable<double> Late_Fee_Percent { get; set; }
        public Nullable<bool> BasicWebsite { get; set; }
        public Nullable<bool> CustomWebsite { get; set; }
        public Nullable<decimal> eManageLogins { get; set; }
        public Nullable<bool> CollectionAgencyResolution { get; set; }
        public Nullable<bool> Inspections { get; set; }
        public Nullable<decimal> NumberOfInspections { get; set; }
        public Nullable<bool> WalkingInspections { get; set; }
        public Nullable<decimal> PMHours { get; set; }
        public Nullable<bool> AnnualMeeting { get; set; }
        public Nullable<decimal> Number_BOD_Meetings { get; set; }
        public Nullable<bool> PoolMemberships { get; set; }
        public Nullable<bool> ClubhouseRentals { get; set; }
        public Nullable<bool> LeaseAdmin { get; set; }
        public Nullable<bool> MovingService { get; set; }
        public Nullable<bool> GateProgramming { get; set; }
        public string ContractNotes { get; set; }
        public Nullable<decimal> PMCommission { get; set; }
        public string InsertBy { get; set; }
        public Nullable<System.DateTime> InsertTime { get; set; }
    
        public virtual tbClient tbClient { get; set; }
        public virtual tbServiceType tbServiceType { get; set; }
        public virtual tbState tbState { get; set; }
    }
}
