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
    public partial class StockInUi : System.Web.UI.Page
    {
        private StockInManager stockInManager = new StockInManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCompanies();
                itemDropDownList.Items.Insert(0, new ListItem("Item Not Available", "0"));
                itemDropDownList.Enabled = false;
                availableQuantityTextBox.Text = 0.ToString();
            }

        }

        protected void companyDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(companyDropDownList.SelectedValue);

            itemDropDownList.DataSource = stockInManager.GetAllItems(id);
            itemDropDownList.DataTextField = "ItemName";
            itemDropDownList.DataValueField = "ItemId";
            itemDropDownList.DataBind();
            itemDropDownList.Items.Insert(0, new ListItem("Select Item", "0"));
            itemDropDownList.Enabled = true;
        }

        public void BindCompanies()
        {
            companyDropDownList.DataSource = stockInManager.GetAllCompanies();
            companyDropDownList.DataTextField = "CompanyName";
            companyDropDownList.DataValueField = "CompanyId";
            companyDropDownList.DataBind();
            companyDropDownList.Items.Insert(0, new ListItem("Select Company", "0"));
        }

        protected void itemDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(itemDropDownList.SelectedValue);

            if (id == 0)
            {
                reorderLevelTextBox.Text = "";
            }
            else
            {
                Item item = stockInManager.GetReoderLevel(id);
                reorderLevelTextBox.Text = item.ReorderLevel.ToString();
            }

            reorderLevelTextBox.Enabled = false;
            availableQuantityTextBox.Enabled = false;


            StockIn stockIn = stockInManager.GetAvailableQuantity(id);
            if (stockIn.AvailableQuantity == 0)
            {
                availableQuantityTextBox.Text = 0.ToString();
            }

            else
            {
                availableQuantityTextBox.Text = stockIn.AvailableQuantity.ToString();
            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
           
            if (companyDropDownList.SelectedIndex != 0)
            {
                if (itemDropDownList.SelectedIndex != 0)
                {
                    if (stockInQuantityTextBox.Text != ""  && Convert.ToInt32(stockInQuantityTextBox.Text)>0)
                    {
                        StockIn stocOut = new StockIn();

                        int id = Convert.ToInt32(itemDropDownList.SelectedValue);

                        if (stockInManager.IsStockItemsExits(id) )
                        {
                            int value = Convert.ToInt32(availableQuantityTextBox.Text) + Convert.ToInt32(stockInQuantityTextBox.Text);

                            stocOut.ItemId = id;
                            stocOut.AvailableQuantity = value;
                            availableQuantityTextBox.Text = value.ToString();
                            OutputLabel.Text = stockInManager.Update(stocOut);
                            stockInQuantityTextBox.Text = "";

                            itemDropDownList.SelectedIndex = 0;
                            companyDropDownList.SelectedIndex = 0;
                            availableQuantityTextBox.Text = "";
                            reorderLevelTextBox.Text = "";

                        }

                        else
                        {
                            int value = Convert.ToInt32(availableQuantityTextBox.Text) + Convert.ToInt32(stockInQuantityTextBox.Text);

                            stocOut.ItemId = Convert.ToInt32(itemDropDownList.SelectedValue);
                            stocOut.AvailableQuantity = value;
                            availableQuantityTextBox.Text = value.ToString();
                            OutputLabel.Text = stockInManager.SaveStockIn(stocOut);

                        }


                    }

                    else
                    {
                        OutputLabel.Text = "Stock In Quantity Invalid!";
                    }
                }
                else
                {
                    OutputLabel.Text = "Please Select Item";
                }
            }
            else
            {
                OutputLabel.Text = "Please Select Company";
            }
           


        }
    }
}