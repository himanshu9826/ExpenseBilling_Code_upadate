using CINC.Common.Helper;
using CINC.DAL;
using CINC.DAL.Repository;
using CINC.DataContract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CINC.BAL.User
{
    public class ExpenseManager
    {
        #region
        ExpenseItemRepository _expenseItemRepository;
        // DateTime currentDatetime = DateTime.Now.TrimMilliseconds();

        #endregion

        /// <summary>
        /// Method to Add Expense Item 
        /// </summary>
        /// <param name="ExpenseDataContract">ExpenseDataContract</param>
        public int ManageExpenseItem(ExpenseDataContract expenseDC)
        {
            int result = 0;
            _expenseItemRepository = new ExpenseItemRepository();
            tbExpenseItem tbExpenseItemObj = new tbExpenseItem();

            DataSet ds = new DataSet();
            try
            {
                expenseDC.invoicedate = Convert.ToDateTime(expenseDC.invoicedate_string);
                ds = _expenseItemRepository.ManageExpenseItem(expenseDC);
            }
            catch
            {
                LibLogging.WriteErrorToDB(
                    "ExpenseManager", "ManageExpenseItem");
            }
            return result;
        }
        /// <summary>
        /// Method to Add Expense Item 
        /// </summary>
        /// <param name="ExpenseDataContract">ExpenseDataContract</param>
        public ExpenseDataContractList GetExpenseList(string startDate, string endDate)
        {
            _expenseItemRepository = new ExpenseItemRepository();
            ExpenseDataContractList userListDC = new ExpenseDataContractList();
            DataSet ds = new DataSet();
            try
            {
                DateTime sStartDate = Convert.ToDateTime(startDate);
                    DateTime sEndDate = Convert.ToDateTime(endDate);


                ds = _expenseItemRepository.GetExpenseItemByFilter(sStartDate, sEndDate);
                if (ds != null && ds.Tables.Count > 0)
                {
                    foreach (DataTable item in ds.Tables)
                    {
                        string tableName = item.Rows != null && item.Rows.Count > 0 ? item.Rows[0][0].ToString() : string.Empty;
                       
                                userListDC.ExpenseDataListContract = GenericConversionHelper.DataTableToList<ExpenseDataContract>(item);
                                break;
                        
                    }
                }
            }
            catch (Exception ex)
            {
                LibLogging.WriteErrorToDB("ExpenseManager", "GetExpenseList", ex);
            }
            return userListDC;
        }



    }
}