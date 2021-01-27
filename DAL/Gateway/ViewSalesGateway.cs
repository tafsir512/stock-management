using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StockManagementSystemApp.DAL.Model;

namespace StockManagementSystemApp.DAL.Gateway
{
    public class ViewSalesGateway: BaseGateway
    {
        public List<StockOut> GetAllDates(string fromDate,string toDate)
        {
            string query = "SELECT ItemName,StockOutQuantity,ActionType FROM StockOut WHERE  Date BETWEEN '" + fromDate +
                           "' AND '" + toDate + "' INTERSECT SELECT ItemName,StockOutQuantity,ActionType FROM StockOut WHERE ActionType = 'Sell'";

            Command = new SqlCommand(query, Connection);

            Connection.Open();
            Reader = Command.ExecuteReader();

            List<StockOut> stockOutList = new List<StockOut>();
            while (Reader.Read())
            {
                StockOut stockOut = new StockOut();
                stockOut.ItemName = (Reader["ItemName"]).ToString();
                stockOut.StockOutQuantity = Convert.ToInt32(Reader["StockOutQuantity"]);
                stockOut.CompanyName = (Reader["ActionType"]).ToString();

                stockOutList.Add(stockOut);
            }
            Connection.Close();
            return stockOutList;
        }

      
    }
}