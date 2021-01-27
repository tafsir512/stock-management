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
            categoryGridView.DataSource = categoryManager.GetAllCategories();
            categoryGridView.DataBind();

        }

        protected void categorySaveButton_Click(object sender, EventArgs e)
        {

            if (categoryNameTextBox.Text != "")
            {
                Category aCategory = new Category();
                aCategory.CategoryName = categoryNameTextBox.Text;
                Outputlabel.Text = categoryManager.Save(aCategory);
                categoryNameTextBox.Text = "";

                
            }

            else
            {
                Outputlabel.Text = "Please Insert Category Name";
            }
           
        }

        protected void updateLinkButton_OnClick(object sender, EventArgs e)
        {
            LinkButton linkButton = (LinkButton)sender;
            DataControlFieldCell cell = (DataControlFieldCell)linkButton.Parent;
            GridViewRow row = (GridViewRow)cell.Parent;
            HiddenField idHiddenField = (HiddenField)row.FindControl("idHiddenField");
            Response.Write(idHiddenField.Value);
            int id = Convert.ToInt32(idHiddenField.Value);
            Response.Redirect("UpdateCategoryUI.aspx?CategoryId=" + id);
        }
    }
}