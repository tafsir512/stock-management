using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagementSystemApp.DAL.Gateway;
using StockManagementSystemApp.DAL.Model;

namespace StockManagementSystemApp.BLL
{
    public class StockInManager
    {
        private StockInGateway stockInGateway;
        private ItemGateway itemgateway;

        public StockInManager()
        {
            stockInGateway = new StockInGateway();
        }

        public string SaveStockIn(StockIn stockIn)
        {
            int rowAffect = stockInGateway.SaveStockIn(stockIn);

            if (rowAffect > 0)
            {
                return "Item Stock In Successful";
            }
            else
            {
                return "Item Stock In Failed";
            }
        }

        public List<Item> GetAllItems(int companyId)
        {
            return stockInGateway.GetAllItems(companyId);
        }

        public List<Company> GetAllCompanies()
        {
            return stockInGateway.GetAllCompanies();
        }

        public List<StockIn> GetAllStockInItems()
        {
            return stockInGateway.GetAllStockInItems();
        }

        public Item GetReoderLevel(int itemId)
        {
            return stockInGateway.GetReoderLevel(itemId);
        }

        public StockIn GetAvailableQuantity(int itemid)
        {
            return stockInGateway.GetAvailableQuantity(itemid);
        }

        public bool IsStockItemsExits(int itemid)
        {
            return stockInGateway.IsStockItemsExits(itemid);
        }

        public string Update(StockIn stockIn)
        {
            int rowAffect = stockInGateway.Update(stockIn);
            if (rowAffect > 0)
            {
                return "update Sucessful";
            }
            else
            {
                return "update Failed";
            }
        }

    }
}