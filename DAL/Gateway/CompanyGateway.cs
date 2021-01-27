using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using StockManagementSystemApp.DAL.Model;

namespace StockManagementSystemApp.DAL.Gateway
{
    public class CompanyGateway: BaseGateway
    {

        

        public int Save(Company company)
        {



            string query = "INSERT INTO CompanySetup VALUES('" + company.CompanyName + "')";

            Command = new SqlCommand(query, Connection);
            Connection.Open();
            int rowAffect = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffect;
        }




        public bool IsExistsCompanyName(String companyName)
        {


            string query = "SELECT * FROM CompanySetup WHERE CompanyName='" + companyName + "'";

            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            bool isExists = Reader.HasRows;
            Connection.Close();
            return isExists;

        }
        public List<Company> GetAllCompanies()
        {
            string query = "SELECT * FROM CompanySetup ";

            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();


            List<Company> companyList = new List<Company>();
            while (Reader.Read())
            {
                Company company=new Company();

                company.CompanyId = Convert.ToInt32(Reader["CompanyId"]);
                company.CompanyName = Reader["CompanyName"].ToString();


                companyList.Add(company);
            }
            Connection.Close();
            return companyList;

        }







    }


}