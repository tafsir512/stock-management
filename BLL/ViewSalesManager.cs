using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagementSystemApp.DAL.Gateway;
using StockManagementSystemApp.DAL.Model;

namespace StockManagementSystemApp.BLL
{
    public class ViewSalesManager
    {
        ViewSalesGateway viewSalesGateway=new ViewSalesGateway();
        public List<StockOut> GetAllDates(string fromDate, string toDate)
        {
            return viewSalesGateway.GetAllDates(fromDate,toDate);
        }

       
    }
}