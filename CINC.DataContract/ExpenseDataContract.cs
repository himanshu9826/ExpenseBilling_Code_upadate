using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Mvc;

namespace CINC.DataContract
{
    public class ExpenseDataContract
    {
        [DataMember]
        public int InvoiceItemID { get; set; }
        [DataMember]

        [Required(ErrorMessage = " Email Required!")]
        public int ClientID { get; set; }
        [DataMember]

        [Required(ErrorMessage = " Product Required!")]
        public int ProductID { get; set; }
        [DataMember]
        public decimal UnitPrice { get; set; }
        [DataMember]

        [Range(typeof(decimal), "1", "79228162514264337593543950335")]
        [Required(ErrorMessage = " Quantity Required!")]
        public int Quantity { get; set; }
        [DataMember]

        [Required(ErrorMessage = " Note Required!")]
        public string Notes { get; set; }
        [DataMember]
        public Nullable<decimal> Extended_Price { get; set; }
        [DataMember]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = " Date Required!")]
        public Nullable<System.DateTime> invoicedate { get; set; }
        [DataMember]
        public string invoicedate_string { get; set; }
        [DataMember]
        public bool Exported { get; set; }
        [DataMember]
        public Nullable<System.DateTime> Exported_On { get; set; }
        [DataMember]
        public string logon_user { get; set; }
        [DataMember]
        public System.DateTime date_created { get; set; }
        [DataMember]
        public Nullable<int> BatchID { get; set; }
        [DataMember]
        public List<SelectListItem> ClientList { get; set; }
        [DataMember]
        public List<SelectListItem> ProductList { get; set; }
        [DataMember]
        public string Client_Name { get; set; }
        [DataMember]
        public string Product_Description { get; set; }
        [DataMember]
        public string Addendum_Description{get;set;}
      

        //[DataMember]
        //public List<ClientDataContract> ClientList { get; set; }
        //[DataMember]
        //public List<ProductDataContract> ProductList { get; set; }
    }
    public class ExpenseDataContractList
    {
        [DataMember]
        public List<ExpenseDataContract> ExpenseDataListContract { get; set; }
        
    }
}