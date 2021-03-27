using CINC.DAL.AbstractRepository;
using CINC.DAL.Helper;
using CINC.DataContract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CINC.DAL.Repository
{
    public class ExpenseItemRepository :AbstractRepository<tbExpenseItem>
    {

        public virtual DataSet ManageExpenseItem(ExpenseDataContract expenseDC)
        {
            DataSet dataSet = new DataSet();
            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                     new SqlParameter("@hoa",expenseDC.ClientID),
                     new SqlParameter("@product", expenseDC.ProductID),
                     new SqlParameter("@price",expenseDC.UnitPrice),
                     new SqlParameter("@notes",expenseDC.Notes),
                     new SqlParameter("total",expenseDC.Extended_Price),
                     new SqlParameter("@invdate",expenseDC.invoicedate),
                     new SqlParameter("@user",HttpContext.Current.Request.ServerVariables["Logon_User"].ToString())
                };

                DBHelper obj = new DBHelper();
                dataSet = obj.ExecuteDataSet("sp_AddExpenseItem", parameters);
            }
            catch (Exception ex)
            {
                string mess = ex.Message;
            }
            return dataSet;
        }


        /// <summary>
        /// Get the Filter expense item list
        /// </summary>
        /// <param name="sStartDate"></param>
        /// <param name="sEndDate"></param>

        /// <returns>DataSet</returns>
        public virtual DataSet GetExpenseItemByFilter(DateTime sStartDate, DateTime sEndDate)
        {
            DataSet userDS = new DataSet();
            DBHelper obj = new DBHelper();
            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@DateCreatedBegDate", sStartDate),
                    new SqlParameter("@DateCreatedEndDate", sEndDate)
                };
                userDS = obj.ExecuteDataSet("up_dbExpenseItem_SELECT", parameters);
            }
            catch (Exception ex)
            {
                string mess = ex.Message;
            }
            return userDS;
        }

    }
}