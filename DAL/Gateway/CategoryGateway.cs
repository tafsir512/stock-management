using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Services.Description;
using StockManagementSystemApp.DAL.Model;

namespace StockManagementSystemApp.DAL.Gateway
{
    public class CategoryGateway : BaseGateway
    {


        public int Save(Category category)
        {

            
            
                string query = "INSERT INTO CategorySetup VALUES('" + category.CategoryName + "')";

                Command = new SqlCommand(query, Connection);
                Connection.Open();
                int rowAffect = Command.ExecuteNonQuery();
                Connection.Close();
                return rowAffect;
            }
        



        public bool IsExistsCategoryName(String categoryName)
        {


            string query = "SELECT * FROM CategorySetup WHERE CategoryName='" + categoryName + "'";

            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            bool isExists = Reader.HasRows;
            Connection.Close();
            return isExists;

        }
        public List<Category> GetAllCategories()
        {
            string query = "SELECT * FROM CategorySetup ";

            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            
          
            List<Category> categoryList = new List<Category>();
            while (Reader.Read())
            {
                Category category=new Category();

                category.CategoryId = Convert.ToInt32(Reader["CategoryId"]);
                category.CategoryName = Reader["CategoryName"].ToString();
               

                categoryList.Add(category);
            }
            Connection.Close();
            return categoryList;

        }

        public Category GetCategoryById(int id)
        {
            string query = "SELECT * FROM CategorySetup WHERE CategoryId="+id;

            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();


            Reader.Read();
            Category category = new Category();
            if (Reader.HasRows)
            {
                category.CategoryId = Convert.ToInt32(Reader["CategoryId"]);
                category.CategoryName = Reader["CategoryName"].ToString();
            
                Connection.Close();
            }
            
               

                
            return category;
        }

        public int UpdateById(Category category)
        {
            string query = "UPDATE CategorySetup SET CategoryName='" + category.CategoryName + "' WHERE CategoryId= " + category.CategoryId;

            Command = new SqlCommand(query, Connection);
            Connection.Open();
            int rowAffect = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffect;
        }

     

        

         
    }
     

}