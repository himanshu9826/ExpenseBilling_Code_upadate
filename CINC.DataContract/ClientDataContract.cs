using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CINC.DataContract
{
    public class ClientDataContract
    {
        [DataMember]
        public int ClientID { get; set; }
        [DataMember]
        public string Client_Name { get; set; }
        [DataMember]
        public string website_url { get; set; }
        [DataMember]
        public bool Active { get; set; }
        [DataMember]
        public string Fed_tax_id { get; set; }
        [DataMember]
        public Nullable<int> ServiceTypeID { get; set; }
        [DataMember]
        public Nullable<int> RegionID { get; set; }
        [DataMember]
        public Nullable<System.DateTime> Date_To_New_Mngmnt { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public Nullable<int> StateID { get; set; }
        [DataMember]
        public Nullable<decimal> ZipCode { get; set; }
        [DataMember]
        public string Insertby { get; set; }
        [DataMember]
        public Nullable<System.DateTime> InsertTime { get; set; }
        [DataMember]
        public Nullable<int> PMID { get; set; }
        [DataMember]
        public Nullable<int> PIID { get; set; }
    }



}