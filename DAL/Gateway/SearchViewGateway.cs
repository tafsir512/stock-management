using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StockManagementSystemApp.DAL.Model.ViewModel;

namespace StockManagementSystemApp.DAL.Gateway
{
    public class SearchViewGateway: BaseGateway
    {
         public List<GetAllCompaniesViewModel> GetAllCompany()
        {
            string query = "SELECT DISTINCT CompanyName, CompanyId from CompanySetup";
            Command = new SqlCommand(query, Connection);

            Connection.Open();
            Reader = Command.ExecuteReader();

            List<GetAllCompaniesViewModel> itemList = new List<GetAllCompaniesViewModel>();
            while (Reader.Read())
            {
                GetAllCompaniesViewModel itemView = new GetAllCompaniesViewModel();
                itemView.CompanyId = Convert.ToInt32(Reader["CompanyId"]);
                itemView.CompanyName = Reader["CompanyName"].ToString();
                itemList.Add(itemView);
            }
            Reader.Close();
            Connection.Close();
            return itemList;
        }


        public List<GetAllCategoriesViewModel> GetAllItemsById(int companyId)
        {
            string query = "SELECT ItemName,CompanyName,AvailableQuantity,ReorderLevel FROM  GetAllCategoryView WHERE CompanyId =" + companyId + " ";
            Command = new SqlCommand(query, Connection);

            Connection.Open();
            Reader = Command.ExecuteReader();
            
            List<GetAllCategoriesViewModel> itemList = new List<GetAllCategoriesViewModel>();
            while (Reader.Read())
            {
                GetAllCategoriesViewModel item = new GetAllCategoriesViewModel();
                item.ItemName = Reader["ItemName"].ToString();
                item.CompanyName = Reader["CompanyName"].ToString();
                item.AvailableQuantity = Convert.ToInt32(Reader["AvailableQuantity"]);
                item.ReorderLevel = Convert.ToInt32(Reader["ReorderLevel"]);
                itemList.Add(item);
            }
            Reader.Close();
            Connection.Close();
            return itemList;
        }

        public List<GetAllCategoriesViewModel> GetAllCompanyItem()
        {
            string query = "SELECT ItemName,CompanyName,AvailableQuantity,ReorderLevel FROM  GetAllCategoryView";
            Command = new SqlCommand(query, Connection);

            Connection.Open();
            Reader = Command.ExecuteReader();
            
            List<GetAllCategoriesViewModel> itemList = new List<GetAllCategoriesViewModel>();
            while (Reader.Read())
            {
                GetAllCategoriesViewModel item = new GetAllCategoriesViewModel();
                item.ItemName = Reader["ItemName"].ToString();
                item.CompanyName = Reader["CompanyName"].ToString();
                item.AvailableQuantity = Convert.ToInt32(Reader["AvailableQuantity"]);
                item.ReorderLevel = Convert.ToInt32(Reader["ReorderLevel"]);
                
                itemList.Add(item);
            }
            Reader.Close();
            Connection.Close();
            return itemList;
        }

        public List<GetAllCategoriesViewModel> GetAllCompanyById(int companyId)
        {
            string query = "SELECT DISTINCT CategoryName,CategoryId FROM  GetAllCategoryView WHERE CompanyId =" + companyId + " ";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<GetAllCategoriesViewModel> itemList = new List<GetAllCategoriesViewModel>();
            while (Reader.Read())
            {
                GetAllCategoriesViewModel item = new GetAllCategoriesViewModel();
                item.CategoryId = Convert.ToInt32(Reader["CategoryId"]);
                item.CategoryName = Reader["CategoryName"].ToString();
                itemList.Add(item);
            }
            Reader.Close();
            Connection.Close();
            return itemList;
        }

        public List<GetAllCategoriesViewModel> GetAllCompanyAndCategoryById(int categoryId, int companyId)
        {
            string query = "SELECT ItemName,CompanyName,AvailableQuantity,ReorderLevel FROM  GetAllCategoryView WHERE CategoryId = " + categoryId + " and CompanyId =" + companyId + "";
            Command = new SqlCommand(query, Connection);

            Connection.Open();
            Reader = Command.ExecuteReader();
            List<GetAllCategoriesViewModel> itemList = new List<GetAllCategoriesViewModel>();
            while (Reader.Read())
            {
                
                GetAllCategoriesViewModel item = new GetAllCategoriesViewModel();
                item.ItemName = Reader["ItemName"].ToString();
                item.CompanyName = Reader["CompanyName"].ToString();
                item.AvailableQuantity = Convert.ToInt32(Reader["AvailableQuantity"]);
                item.ReorderLevel = Convert.ToInt32(Reader["ReorderLevel"]);
             
                itemList.Add(item);
            }
            Reader.Close();
            Connection.Close();
            return itemList;
        }


        public List<GetAllCategoriesViewModel> GetAllCategoryItem()
        {
            string query = "SELECT DISTINCT CategoryName, CategoryId FROM  GetAllCategoryView";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<GetAllCategoriesViewModel> itemList = new List<GetAllCategoriesViewModel>();
            while (Reader.Read())
            {
                GetAllCategoriesViewModel item = new GetAllCategoriesViewModel();
                item.CategoryId = Convert.ToInt32(Reader["CategoryId"]);
                item.CategoryName = Reader["CategoryName"].ToString();
                itemList.Add(item);
            }
            Reader.Close();
            Connection.Close();
            return itemList;
        }


        public List<GetAllCategoriesViewModel> GetCategoryById(int categoryId)
        {
            string query = "SELECT ItemName,CompanyName,AvailableQuantity,ReorderLevel FROM  GetAllCategoryView WHERE CategoryId = " + categoryId + " ";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            
            List<GetAllCategoriesViewModel> itemList = new List<GetAllCategoriesViewModel>();
            while (Reader.Read())
            {
                GetAllCategoriesViewModel item = new GetAllCategoriesViewModel();
                item.ItemName = Reader["ItemName"].ToString();
                item.CompanyName = Reader["CompanyName"].ToString();
                item.AvailableQuantity = Convert.ToInt32(Reader["AvailableQuantity"]);
                item.ReorderLevel = Convert.ToInt32(Reader["ReorderLevel"]);
                
                itemList.Add(item);
            }
            Reader.Close();
            Connection.Close();
            return itemList;
        }
    }
}
    
