using CINC.DAL.AbstractRepository;
using CINC.DAL.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CINC.DAL.Repository
{
    public class ClientRepository: AbstractRepository<tbClient>
    {

        public virtual DataSet GetClientList()
        {
            DataSet dataSet = new DataSet();
            try
            {   DBHelper obj = new DBHelper();
                dataSet = obj.ExecuteDataSet("up_tbClients_SELECT");
            }
            catch (Exception ex)
            {
                string mess = ex.Message;
            }
            return dataSet;
        }
 }
}