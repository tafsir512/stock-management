using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StockManagementSystemApp.BLL;
using StockManagementSystemApp.DAL.Model;

namespace StockManagementSystemApp.UI
{
    public partial class CompanyUI : System.Web.UI.Page
    {
        CompanyManager companyManager=new CompanyManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            companyGridView.DataSource = companyManager.GetAllCompanies();
            companyGridView.DataBind();
        }

        protected void categorySaveButton_Click(object sender, EventArgs e)
        {
            if (companyNameTextBox.Text != "")
            {
                Company aCompany = new Company();
                aCompany.CompanyName = companyNameTextBox.Text;
                Outputlabel.Text = companyManager.Save(aCompany);
                companyNameTextBox.Text = "";
            }
            else
            {
                Outputlabel.Text = "Please Insert Company Name";
            }
        }
    }
}