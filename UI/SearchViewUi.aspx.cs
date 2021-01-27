using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StockManagementSystemApp.BLL;

namespace StockManagementSystemApp.UI
{
    public partial class SearchViewUi : System.Web.UI.Page
    {
        private SearchViewManager searchViewManager = new SearchViewManager();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                BindCompanies();

                categoryDropDownList.DataSource = searchViewManager.GetAllCategoryItem();
                categoryDropDownList.DataValueField = "CategoryId";
                categoryDropDownList.DataTextField = "CategoryName";
                categoryDropDownList.DataBind();
                categoryDropDownList.Items.Insert(0, new ListItem("-Select Category-", "0"));


            }

        }

        protected void companyDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(companyDropDownList.SelectedValue);
            categoryDropDownList.DataSource = searchViewManager.GetAllCompanyById(id);
            categoryDropDownList.DataTextField = "CategoryName";
            categoryDropDownList.DataValueField = "CategoryId";
            categoryDropDownList.DataBind();
            categoryDropDownList.Items.Insert(0, new ListItem("-Select Category-", "0"));

        }

        public void BindCompanies()
        {
            companyDropDownList.DataSource = searchViewManager.GetAllCompany();
            companyDropDownList.DataTextField = "CompanyName";
            companyDropDownList.DataValueField = "CompanyId";
            companyDropDownList.DataBind();
            companyDropDownList.Items.Insert(0, new ListItem("-Select Company-", "0"));
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            int companyId = Convert.ToInt32(companyDropDownList.SelectedValue);
            int categoryId = Convert.ToInt32(categoryDropDownList.SelectedValue);

           

                if (companyId == 0 && categoryId == 0)
                {
                    SearchListGridView.DataSource = searchViewManager.GetAllCompanyItem();
                    SearchListGridView.DataBind();
                }
                else if (companyId != 0)
                {
                    SearchListGridView.DataSource = searchViewManager.GetAllItemsById(companyId);
                    SearchListGridView.DataBind();
                }
                else if (categoryId != 0)
                {
                    SearchListGridView.DataSource = searchViewManager.GetCategoryById(categoryId);
                    SearchListGridView.DataBind();
                }
                else if (companyId != 0 && categoryId != 0)
                {
                    SearchListGridView.DataSource = searchViewManager.GetAllCompanyAndCategoryById(categoryId, companyId);
                    SearchListGridView.DataBind();
                }
            }

           

        }
    }

            
        



    

