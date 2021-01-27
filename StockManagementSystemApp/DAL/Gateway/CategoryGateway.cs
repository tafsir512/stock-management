using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using StockManagementSystemApp.DAL.Model;

namespace StockManagementSystemApp.DAL.Gateway
{
    public class CategoryGateway
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public CategoryGateway()
        {
            string conString = WebConfigurationManager.ConnectionStrings["StockManagementDB"].ConnectionString;
            connection = new SqlConnection(conString);
            
        }

        public int Save(Category category)
        {
            

            string query = "INSERT INTO CategorySetup VALUES('"+category.Name+"')";

             command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();
            return rowAffect;
        }

        public bool IsExistsCategoryName(String categoryName)
        {


            string query = "SELECT * FROM CategorySetup WHERE Name='" + categoryName + "'";

            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            bool isExists = reader.HasRows;
            connection.Close();
            return isExists;

        }
        public List<Category> GetAllCategories()
        {
            string query = "SELECT * FROM CategorySetup ";

            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            List<Category> studentList = new List<Category>();
            while (reader.Read())
            {
                Category category=new Category();

                category.SL = Convert.ToInt32(reader["SL"]);
                category.Name = reader["Name"].ToString();
               

                studentList.Add(category);
            }
            connection.Close();
            return studentList;

        }

         
    }
     

}