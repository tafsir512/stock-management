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
    public partial class UpdateCategoryUI : System.Web.UI.Page
    {
        CategoryManager categoryManager=new CategoryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int id = Convert.ToInt32(Request.QueryString["CategoryId"]);
                Category category = categoryManager.GetCategoryById(id);
                if (category != null)
                {
                    LoadCategory(category);
                }
            }
            
          
            

        }

        private void LoadCategory(Category category)
        {
            idHiddenField.Value = category.CategoryId.ToString();
            categoryNameTextBox.Text = category.CategoryName;   
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            if (categoryNameTextBox.Text != "")
            {
                Category category = new Category();
                category.CategoryId = Convert.ToInt32(idHiddenField.Value);
                category.CategoryName = categoryNameTextBox.Text;
                outputLabel.Text = categoryManager.UpdateById(category);
            }
            else
            {
                outputLabel.Text = "Please Insert Category Name";
            }
        }
    }
}