using CINC.DAL.AbstractRepository;
using CINC.DAL.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CINC.DAL.Repository
{
    public class ProductRepository:AbstractRepository<tbProduct>
    {
        public virtual DataSet GetProductList()
        {
            DataSet dataSet = new DataSet();
            try
            {
                DBHelper obj = new DBHelper();
                dataSet = obj.ExecuteDataSet("up_tbProducts_SELECT");
            }
            catch (Exception ex)
            {
                string mess = ex.Message;
            }
            return dataSet;
        }
    }
}