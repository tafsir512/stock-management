using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StockManagementSystemApp.BLL;

namespace StockManagementSystemApp.UI
{
    public partial class ShowAllCategories : System.Web.UI.Page
    {
        CategoryManager categoryManager=new CategoryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            categoryGridView.DataSource = categoryManager.GetAllCategories();
            categoryGridView.DataBind();
        }
    }
}