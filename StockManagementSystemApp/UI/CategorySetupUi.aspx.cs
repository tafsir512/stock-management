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
    
    public partial class CategorySetuoUi : System.Web.UI.Page
    {
        CategoryManager categoryManager=new CategoryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void categorySaveButton_Click(object sender, EventArgs e)
        {
            Category aCategory=new Category();
            aCategory.Name = categoryNameTextBox.Text;
            Outputlabel.Text = categoryManager.Save(aCategory);
        }
    }
}