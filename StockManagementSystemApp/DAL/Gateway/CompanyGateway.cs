using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using StockManagementSystemApp.DAL.Model;

namespace StockManagementSystemApp.DAL.Gateway
{
    public class CompanyGateway
    {
        
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public CompanyGateway()
        {
            string conString = WebConfigurationManager.ConnectionStrings["StockManagementDB"].ConnectionString;
            connection = new SqlConnection(conString);
            
        }

        public int Save(Company company)
        {
            

            string query = "INSERT INTO CompanySetup VALUES('"+company.Name+"')";

             command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();
            return rowAffect;
        }

        public bool IsExistsCompanyName(String companyName)
        {


            string query = "SELECT * FROM CategorySetup WHERE Name='" + companyName + "'";

            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            bool isExists = reader.HasRows;
            connection.Close();
            return isExists;

        }
        public List<Company> GetAllCompanies()
        {
            string query = "SELECT * FROM CompanySetup ";

            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            List<Company> companyList = new List<Company>();
            while (reader.Read())
            {
                Company company=new Company();

                company.SL = Convert.ToInt32(reader["SL"]);
                company.Name = reader["Name"].ToString();
               

                companyList.Add(company);
            }
            connection.Close();
            return companyList;

        }

         
    }
     

}
