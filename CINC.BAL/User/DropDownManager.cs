using CINC.Common.Helper;
using CINC.DAL.Repository;
using CINC.DataContract.DropDownDataContract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CINC.BAL.User
{
    public class DropDownManager
    {
        #region Variable declaration

        ClientRepository _clientRepository;
        ProductRepository _productRepository;
        #endregion
        ///// <summary>
        ///// Method to get the list of All Client List
        ///// </summary>
        ///// <returns></returns>
        //public List<SelectListItem> GetClientList()
        //{
        //    _clientRepository = new ClientRepository();
        //    List<SelectListItem> objList = null;
        //    try
        //    {
        //        objList = _clientRepository.GetList(x => x.Active == true).Select(q => new SelectListItem
        //        {
        //            Text = q.Client_Name,
        //            Value = q.ClientID.ToString()
        //        }).ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        LibLogging.WriteErrorToDB("DropDownManager", "GetClientList", ex);
        //    }
        //    return objList;
        //}

        /// <summary>
        /// Method to get the list of All Product List
        /// </summary>
        /// <returns></returns>
        public List<SelectListItem> GetProductList()
        {
            _productRepository = new ProductRepository();
            List<SelectListItem> productDCList = new List<SelectListItem>();
            List<ProductsListDataContract> productObjDCList = new List<ProductsListDataContract>();
            try
            {
                DataSet ds = new DataSet();
                ds = _productRepository.GetProductList();
                if (ds != null && ds.Tables.Count > 0)
                {
                    foreach (DataTable item in ds.Tables)
                    {
                        string tableName = item.Rows != null && item.Rows.Count > 0 ? item.Rows[0][0].ToString() : string.Empty;
                        productObjDCList = GenericConversionHelper.DataTableToList<ProductsListDataContract>(item);
                    }

                }

                if (productObjDCList != null && productObjDCList.Count > 0)
                {
                    productDCList = productObjDCList.Select(x => new SelectListItem { Text = x.Product_Description, Value = x.ProductID }).ToList();
                }
            }
            catch (Exception ex)
            {
                LibLogging.WriteErrorToDB("DropDownManager", "GetClientList", ex);
            }
            return productDCList;
        }


        public List<SelectListItem> GetClientList()
        {
            _clientRepository = new ClientRepository();
            List<SelectListItem> clientDCList = new List<SelectListItem>();
            List<HOAListDataContract> clientObjDCList = new List<HOAListDataContract>();
            try
            {
                DataSet ds = new DataSet();
                ds = _clientRepository.GetClientList();
                if (ds != null && ds.Tables.Count > 0)
                {
                    foreach (DataTable item in ds.Tables)
                    {
                        string tableName = item.Rows != null && item.Rows.Count > 0 ? item.Rows[0][0].ToString() : string.Empty;
                        clientObjDCList = GenericConversionHelper.DataTableToList<HOAListDataContract>(item);
                    }

                }

                if (clientObjDCList != null && clientObjDCList.Count > 0)
                {
                    clientDCList = clientObjDCList.Select(x => new SelectListItem { Text = x.Client_Name, Value = x.ClientID }).ToList();
                }
            }
            catch (Exception ex)
            {
                LibLogging.WriteErrorToDB("DropDownManager", "GetClientList", ex);
            }
            return clientDCList;
        }

        ///// <summary>
        ///// Method to get the list of All Product List
        ///// </summary>
        ///// <returns></returns>

        //public List<ProductDataContract> GetProductList()
        //{
        //    _productRepository = new ProductRepository();
        //    List<ProductDataContract> productList = new List<ProductDataContract>();
        //    try
        //    {
        //        DataSet ds = new DataSet();
        //        ds = _productRepository.GetProductList();
        //        if (ds != null && ds.Tables.Count > 0)
        //        {
        //            foreach (DataTable item in ds.Tables)
        //            {
        //                string tableName = item.Rows != null && item.Rows.Count > 0 ? item.Rows[0][0].ToString() : string.Empty;
        //                productList = GenericConversionHelper.DataTableToList<ProductDataContract>(item);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        LibLogging.WriteErrorToDB("DropDownManager", "GetProductList", ex);
        //    }
        //    return productList;
        //}



    }
}