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
    
    public partial class tbProduct
    {
        public int ProductID { get; set; }
        public string Product_Description { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<int> AddendumSubID { get; set; }
        public Nullable<double> Commission { get; set; }
        public Nullable<bool> Commission_Salaried { get; set; }
        public string CAMGL { get; set; }
        public string AGL { get; set; }
        public string Department { get; set; }
        public Nullable<bool> AutoBill { get; set; }
        public string Active { get; set; }
    
        public virtual tbAddendumSubType tbAddendumSubType { get; set; }
    }
}
