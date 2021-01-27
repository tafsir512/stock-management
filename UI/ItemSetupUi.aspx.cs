using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StockManagementSystemApp.BLL;
using StockManagementSystemApp.DAL.Gateway;
using StockManagementSystemApp.DAL.Model;

namespace StockManagementSystemApp.UI
{
    public partial class ItemSetupUi : System.Web.UI.Page
    {
        CategoryManager categoryManager=new CategoryManager();
        CompanyManager companyManager=new CompanyManager();

        ItemManager itemManager = new ItemManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCategories();

                BindCompanies();

                reorderLevelTextBox.Text = "0";
                reorderLevelTextBox.Enabled = false;
            }



        }

        public void BindCategories()
        {
            

            categoryDropDownList.DataSource = categoryManager.GetAllCategories();
            categoryDropDownList.DataValueField = "CategoryId";
            categoryDropDownList.DataTextField = "CategoryName";
       
            categoryDropDownList.DataBind();
            categoryDropDownList.AutoPostBack = true;
            categoryDropDownList.Items.Insert(0,"Please Select Category");

          
        }

        public void BindCompanies()
        {
            companyDropDownList.DataSource = companyManager.GetAllCompanies();
            companyDropDownList.DataValueField = "CompanyId";
            companyDropDownList.DataTextField = "CompanyName";
            companyDropDownList.DataBind();
            companyDropDownList.Items.Insert(0,"Please Select Company");
        }

        protected void saveButton_Click(object sender, EventArgs e)
        
        {
            if (categoryDropDownList.SelectedIndex != 0)
            {
                if (companyDropDownList.SelectedIndex != 0)
                {
                    if (itemNameTextBox.Text != "")
                    {

                        Item item = new Item();
                        
                        item.CategoryId = Convert.ToInt32(categoryDropDownList.SelectedValue);
                        item.CompanyId = Convert.ToInt32(companyDropDownList.SelectedValue);
                        item.ItemName = itemNameTextBox.Text;
                        item.ReorderLevel = Convert.ToInt32(reorderLevelTextBox.Text);


                        OutputLabel.Text = itemManager.SaveItem(item);

                        categoryDropDownList.SelectedIndex = 0;
                        companyDropDownList.SelectedIndex = 0;
                        itemNameTextBox.Text = "";
                        reorderLevelTextBox.Text = "";

                    }

                    else
                    {
                        OutputLabel.Text = "Please Insert Item Name";
                    }
                }
                else
                {
                    OutputLabel.Text = "Please Select Company";
                }
            }

            else
            {
                OutputLabel.Text = "Please Select Category";
            }
        }


        }
}