using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagementSystemApp.DAL.Gateway;
using StockManagementSystemApp.DAL.Model;

namespace StockManagementSystemApp.BLL
{
    public class ItemManager
    {
        private ItemGateway itemGateway;

        public ItemManager()
        {
            itemGateway = new ItemGateway();
        }

        public string SaveItem(Item item)
        {
            bool isPresent = itemGateway.isItemPresent(item);

            if (isPresent)
            {
                return "Item Already Exist!";
            }

            {
                int rowAffected = itemGateway.SaveItem(item);
                if (rowAffected > 0)
                {
                    return "Save Successful";
                }
                else
                {
                    return "Save Failed";
                }
            }
        }

        public List<Item> GetAllItems()
        {
            return itemGateway.GetAllItems();
        }
    }
}