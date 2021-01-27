using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StockManagementSystemApp.DAL.Model;

namespace StockManagementSystemApp.DAL.Gateway
{
    public class ItemGateway:BaseGateway
    {
        public int SaveItem(Item item)
        {
            string query = "INSERT INTO ItemSetup VALUES(" + item.CategoryId + "," + item.CompanyId + ",'" + item.ItemName + "','" + item.ReorderLevel + "')";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();

            return rowAffected;
        }

        public bool isItemPresent(Item item)
        {
            string query = "SELECT CategoryId,CompanyId FROM ItemSetup WHERE ItemName ='" + item.ItemName + "'";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            bool isPresent = reader.HasRows;
            Connection.Close();
            return isPresent;
        }

        public List<Item> GetAllItems()
        {
            string query = "SELECT * FROM ItemSetup";
            Command = new SqlCommand(query, Connection);
           
            Connection.Open();
            SqlDataReader itemReader = Command.ExecuteReader();

            List<Item> itemList = new List<Item>();
            while (itemReader.Read())
            {
                Item item = new Item();
                item.CategoryId = Convert.ToInt32(itemReader["CategoryId"]);
                item.CompanyId = Convert.ToInt32(itemReader["CompanyId"]);
                item.ItemName = itemReader["ItemName"].ToString();
                item.ReorderLevel = Convert.ToInt32(itemReader["ReorderLevel"]);
                itemList.Add(item);
            }
            Connection.Close();
            return itemList;
        }
    }
    }
