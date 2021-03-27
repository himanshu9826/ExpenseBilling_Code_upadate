using CINC.BAL.User;
using CINC.Common.Helper;
using CINC.DataContract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CINC.Web.Controllers
{
    public class ExpenseController : Controller
    {
        #region Variable declaration
        DropDownManager _dropDownManager;
        ExpenseManager _expenseManager;
        #endregion



        [HttpGet]
        public ActionResult GetExpenseByFilter(string startDate, string endDate)
        {
            _expenseManager = new ExpenseManager();
           // int startRow = (page - 1) * Configurations.GridPageSize;
           // int end = page * Configurations.GridPageSize;
            ExpenseDataContractList expenseListDC = new ExpenseDataContractList();
            expenseListDC = _expenseManager.GetExpenseList(startDate, endDate);
           
            //var totalPages = (int)Math.Ceiling(totalRecords / (float)Configurations.GridPageSize);
            var jsonData = new
            {
              //  total = totalPages,
              //  page,
              //  records = totalRecords,
                rows = expenseListDC.ExpenseDataListContract
            };
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ExpenseAddItem(int? id)
        {

            ExpenseDataContract expenseDC = new ExpenseDataContract();
            _dropDownManager = new DropDownManager();
            
            try
            {
                expenseDC.ClientList = _dropDownManager.GetClientList();
                expenseDC.ProductList = _dropDownManager.GetProductList();
            }
            catch (Exception ex)
            {
                var trace = new StackTrace(ex, true);
                var frame = trace.GetFrame(0);
                var line = frame.GetFileLineNumber();
                LibLogging.WriteErrorToDB("ExpenseAddItem", "LineNumber" + line.ToString() + "-" + ex.Message, ex);
            }
            return View(expenseDC);
        }
        [HttpPost]
          public ActionResult ExpenseAddItem(ExpenseDataContract expenseDC)
        {
            _expenseManager = new ExpenseManager();
            int result = 0;
            try
            {
                if (expenseDC != null)
                {
                    result = _expenseManager.ManageExpenseItem(expenseDC);
                }
            }
            catch (Exception ex)
            {
                var trace = new StackTrace(ex, true);
                var frame = trace.GetFrame(0);
                var line = frame.GetFileLineNumber();
                LibLogging.WriteErrorToDB("ExpenseAddItem", "LineNumber" + line.ToString() + "-" + ex.Message, ex);
            }
            return RedirectToAction("ExpenseAddItem", "Expense");
        }




    }
}