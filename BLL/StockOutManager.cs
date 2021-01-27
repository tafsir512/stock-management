using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagementSystemApp.BLL;
using StockManagementSystemApp.DAL.Gateway;
using StockManagementSystemApp.DAL.Model;
using StockManagementSystemApp.DAL.Model.ViewModel;

namespace StockManagementSystemApp.BLL
{
    
    public class StockOutManager : StockInManager
    {
        StockOutGateway stockOutGateway=new StockOutGateway();
        public string AddStockOut(StockOut stockOut)
        {
            
            int rowAffect= stockOutGateway.AddStockOut(stockOut);
            if (rowAffect>0)
            {
                return "Stock Out Successful";
            }
            else
            {
                return "Stock Out Failed";
            }
        }

        public List<StockOut> GetAllStockOutItems()
        {
            return stockOutGateway.GetAllStockOutItems();
        }

       
    }
}