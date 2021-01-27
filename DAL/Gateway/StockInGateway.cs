using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StockManagementSystemApp.DAL.Model;

namespace StockManagementSystemApp.DAL.Gateway
{
    public class StockInGateway: BaseGateway
    {
        public int SaveStockIn(StockIn stockIn)
        {
            string query = "INSERT INTO StockInItems VALUES('" + stockIn.ItemId + "','" + stockIn.AvailableQuantity + "',"+stockIn.ReorderLevel+")";
            Command = new SqlCommand(query, Connection);

            Connection.Open();
            int rowAffect = Command.ExecuteNonQuery();
            Connection.Close();

            return rowAffect;
        }

        public List<StockIn> GetAllStockInItems()
        {
            string query = "SELECT * FROM StockInItems";
            Command = new SqlCommand(query, Connection);

            Connection.Open();
            Reader = Command.ExecuteReader();

            List<StockIn> stockInList = new List<StockIn>();
            while (Reader.Read())
            {
                StockIn stockIn = new StockIn();
                stockIn.StockInItemId = Convert.ToInt32(Reader["StockInItemsId"]);
                stockIn.ItemId = Convert.ToInt32(Reader["ItemId"]);
                stockIn.AvailableQuantity = Convert.ToInt32(Reader["AvailableQuantity"]);

                stockInList.Add(stockIn);
            }
            Connection.Close();
            return stockInList;
        }

        public List<Item> GetAllItems(int companyId)
        {
            string query = "SELECT * FROM ItemSetup WHERE CompanyId = '" + companyId + "' ";
            Command = new SqlCommand(query, Connection);

            Connection.Open();
             Reader = Command.ExecuteReader();

            List<Item> itemList = new List<Item>();
            while (Reader.Read())
            {
                Item item = new Item();
                item.ItemId = Convert.ToInt32(Reader["ItemId"]);
                item.ItemName = Reader["ItemName"].ToString();
                item.ReorderLevel = Convert.ToInt32(Reader["ReorderLevel"]);

                itemList.Add(item);
            }
            Reader.Close();
            Connection.Close();
            return itemList;
        }

        public List<Company> GetAllCompanies()
        {
            string query = "SELECT DISTINCT CompanyName,CompanyId FROM CompanySetup";
            Command = new SqlCommand(query, Connection);

            Connection.Open();
            Reader = Command.ExecuteReader();
            List<Company> companyList = new List<Company>();
            while (Reader.Read())
            {
                Company company = new Company();
                company.CompanyId = Convert.ToInt32(Reader["CompanyId"]);
                company.CompanyName = Reader["CompanyName"].ToString();

                companyList.Add(company);
            }
            Reader.Close();
            Connection.Close();
            return companyList;
        }

        public Item GetReoderLevel(int itemId)
        {
            string query = "SELECT ReorderLevel FROM ItemSetup WHERE ItemId = " + itemId + " ";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader= Command.ExecuteReader();

            Item item = new Item();
            while (Reader.Read())
            {
                item.ReorderLevel = Convert.ToInt32(Reader["ReorderLevel"]);
            }
            Reader.Close();
            Connection.Close();
            return item;
        }

        public bool IsStockItemsExits(int itemid)
        {
            string query = "SELECT * FROM StockInItems  WHERE ItemId  ='" + itemid + "'";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            bool isExists = Reader.HasRows;
            Connection.Close();
            return isExists;
        }

        public int Update(StockIn stockIn)
        {
            string query = "UPDATE StockInItems SET AvailableQuantity = " + stockIn.AvailableQuantity + " WHERE ItemId = " + stockIn.ItemId + "";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            int rowAffect = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffect;
        }


        public StockIn GetAvailableQuantity(int itemid)
        {
            string query = "SELECT AvailableQuantity  FROM StockInItems  WHERE ItemId  ='" + itemid + "'";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            StockIn stockIn = new StockIn();
            while (Reader.Read())
            {
                stockIn.AvailableQuantity = Convert.ToInt32(Reader["AvailableQuantity"]);
            }
            Reader.Close();
            Connection.Close();
            return stockIn;
        }

    }
}