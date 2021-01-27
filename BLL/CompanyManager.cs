using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagementSystemApp.DAL.Gateway;
using StockManagementSystemApp.DAL.Model;

namespace StockManagementSystemApp.BLL
{
    public class CompanyManager
    {
        CompanyGateway companyGateway=new CompanyGateway();

        public string Save(Company company)
        {
            if (companyGateway.IsExistsCompanyName(company.CompanyName))
            {
                return "Name Already Exists";
            }
            else
            {


                int rowAffect = companyGateway.Save(company);
                if (rowAffect > 0)
                {
                    return "Save Successful";
                }
                else
                {
                    return "Save Failed";
                }
            }
            


        }

        public List<Company> GetAllCompanies()
        {
            return companyGateway.GetAllCompanies();
        }
    }
}
