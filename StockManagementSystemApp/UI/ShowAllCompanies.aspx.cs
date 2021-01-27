using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StockManagementSystemApp.BLL;

namespace StockManagementSystemApp.UI
{
    public partial class ShowAllCompanies : System.Web.UI.Page
    {
        CompanyManager companyManager=new CompanyManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            companyGridView.DataSource = companyManager.GetAllCompanies();
            companyGridView.DataBind();
        }
    }
}