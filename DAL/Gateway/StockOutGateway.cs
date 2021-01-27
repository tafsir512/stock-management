using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StockManagementSystemApp.DAL.Model;
using StockManagementSystemApp.DAL.Model.ViewModel;


namespace StockManagementSystemApp.DAL.Gateway
{
    public class StockOutGateway : StockInGateway
    {
        public int AddStockOut(StockOut stockOut)
        {
            string query = "INSERT INTO StockOut VALUES('" + stockOut.ItemName + "','" + stockOut.CompanyName + "'," + stockOut.StockOutQuantity + ", GETUTCDATE(),'" + stockOut.ActionType + "')";
            Command = new SqlCommand(query, Connection);

            Connection.Open();
            int rowAffect = Command.ExecuteNonQuery();
            Connection.Close();

            return rowAffect;
        }

        public List<StockOut> GetAllStockOutItems()
        {
            string query = "SELECT * FROM StockOut";
            Command = new SqlCommand(query, Connection);

            Connection.Open();
            Reader = Command.ExecuteReader();

            List<StockOut> stockOutList = new List<StockOut>();
            while (Reader.Read())
            {
                StockOut stockOut = new StockOut();
                stockOut.StockOutId = Convert.ToInt32(Reader["StockOutId"]);
                stockOut.ItemName = (Reader["ItemName"]).ToString();
                stockOut.CompanyName = (Reader["CompanyName"]).ToString();
                stockOut.StockOutQuantity = Convert.ToInt32(Reader["StockOutQuantity"]);

                stockOutList.Add(stockOut);
            }
            Connection.Close();
            return stockOutList;
        }

        
    }
}