using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CINC.DataContract
{
    public class ProductDataContract
    {
        [DataMember]
        public string Product_Description { get; set; }
        [DataMember]
        public Nullable<decimal> UnitPrice { get; set; }
        [DataMember]
        public Nullable<int> AddendumSubID { get; set; }
        [DataMember]
        public Nullable<double> Commission { get; set; }
        [DataMember]
        public Nullable<bool> Commission_Salaried { get; set; }
        [DataMember]
        public string CAMGL { get; set; }
        [DataMember]
        public string AGL { get; set; }
        [DataMember]
        public string Department { get; set; }
        [DataMember]
        public Nullable<bool> AutoBill { get; set; }
        [DataMember]
        public string Active { get; set; }

    }
}