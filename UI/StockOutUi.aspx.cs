using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StockManagementSystemApp.BLL;
using StockManagementSystemApp.DAL.Model;
using StockManagementSystemApp.DAL.Model.ViewModel;

namespace StockManagementSystemApp.UI
{
    public partial class StockOutUi : System.Web.UI.Page
    {
        private StockOutManager stockOutManager = new StockOutManager();

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

        public void BindCompanies()
        {
            companyDropDownList.DataSource = stockOutManager.GetAllCompanies();
            companyDropDownList.DataTextField = "CompanyName";
            companyDropDownList.DataValueField = "CompanyId";
            companyDropDownList.DataBind();
            companyDropDownList.Items.Insert(0, new ListItem("Select Company", "0"));
        }

        protected void companyDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(companyDropDownList.SelectedValue);

            itemDropDownList.DataSource = stockOutManager.GetAllItems(id);
            itemDropDownList.DataTextField = "ItemName";
            itemDropDownList.DataValueField = "ItemId";
            itemDropDownList.DataBind();
            itemDropDownList.Items.Insert(0, new ListItem("Select Item", "0"));
            itemDropDownList.Enabled = true;
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
                Item item = stockOutManager.GetReoderLevel(id);
                reorderLevelTextBox.Text = item.ReorderLevel.ToString();
            }

            reorderLevelTextBox.Enabled = false;
            availableQuantityTextBox.Enabled = false;


            StockIn stockIn = stockOutManager.GetAvailableQuantity(id);
            if (stockIn.AvailableQuantity == 0)
            {
                availableQuantityTextBox.Text = 0.ToString();
            }


            else
            {
                availableQuantityTextBox.Text = stockIn.AvailableQuantity.ToString();
            }

        }



        protected void addButton_Click(object sender, EventArgs e)
        {
            
            if (companyDropDownList.SelectedIndex != 0)
            {
                if (itemDropDownList.SelectedIndex != 0)
                {
                    if (stockOutQuantityTextBox.Text != "" && Convert.ToInt32(stockOutQuantityTextBox.Text) > 0)
                    {


                        int id = Convert.ToInt32(itemDropDownList.SelectedValue);

                        if (Convert.ToInt32(stockOutQuantityTextBox.Text) <
                            Convert.ToInt32(availableQuantityTextBox.Text))
                        {
                            



            itemQuantityGridView.DataSource = AddItemsInGrid();
            itemQuantityGridView.DataBind();

            StockOut stockOut = new StockOut();
            //int value = Convert.ToInt32(availableQuantityTextBox.Text) -
            //            Convert.ToInt32(stockOutQuantityTextBox.Text);

            stockOut.StockOutQuantity = Convert.ToInt32(stockOutQuantityTextBox.Text);
            //availableQuantityTextBox.Text = value.ToString();
            //stockOutQuantityTextBox.Text = "";

            stockOutQuantityTextBox.Text = "";
            availableQuantityTextBox.Text = "";
            reorderLevelTextBox.Text = "";
            companyDropDownList.SelectedIndex = 0;
                            itemDropDownList.SelectedIndex = 0;

                        }
                        else
                        {


                            outputLabel.Text = "Stock out Quantity is too much";
                        }


                    }

                    else
                    {
                        outputLabel.Text = "Stock Out Quantity Invalid!";
                    }
                }
                else
                {
                    outputLabel.Text = "Please Select Item";
                }
            }

            else
            {
                outputLabel.Text = "Please Select Company";
            }
}

        protected void sellButton_Click(object sender, EventArgs e)
        {
           
                            StockOut stockOut = new StockOut();
                            foreach (GridViewRow row in itemQuantityGridView.Rows)
                            {
                                stockOut.ItemName = (((Label) row.FindControl("ItemNameLabel")).Text);
                                stockOut.CompanyName = (((Label) row.FindControl("companyNameLabel")).Text);
                                stockOut.StockOutQuantity =
                                    Convert.ToInt32(((Label) row.FindControl("quantityLabel")).Text);


                                stockOut.ActionType = "Sell";

                                outputLabel.Text = stockOutManager.AddStockOut(stockOut);
                            }
                       

        }

        protected void damageButton_Click(object sender, EventArgs e)
        {
           
                            StockOut stockOut = new StockOut();
                            foreach (GridViewRow row in itemQuantityGridView.Rows)
                            {
                                stockOut.ItemName = (((Label) row.FindControl("ItemNameLabel")).Text);
                                stockOut.CompanyName = (((Label) row.FindControl("companyNameLabel")).Text);
                                stockOut.StockOutQuantity =
                                    Convert.ToInt32(((Label) row.FindControl("quantityLabel")).Text);


                                stockOut.ActionType = "Damage";

                                outputLabel.Text = stockOutManager.AddStockOut(stockOut);
                            }

                       

        }

        protected void lostButton_Click(object sender, EventArgs e)
        {
           
                            StockOut stockOut = new StockOut();
                            foreach (GridViewRow row in itemQuantityGridView.Rows)
                            {
                                stockOut.ItemName = (((Label) row.FindControl("ItemNameLabel")).Text);
                                stockOut.CompanyName = (((Label) row.FindControl("companyNameLabel")).Text);
                                stockOut.StockOutQuantity =
                                    Convert.ToInt32(((Label) row.FindControl("quantityLabel")).Text);


                                stockOut.ActionType = "Lost";

                                outputLabel.Text = stockOutManager.AddStockOut(stockOut);
                            }

                     
        }

        public List<StockOut> AddItemsInGrid()
        {
          
           StockOut stockOut=new StockOut();
            if (ViewState["AddItemListVS"] == null)
            {
                List<StockOut> gridList = new List<StockOut>();
                
                stockOut.ItemName = itemDropDownList.SelectedItem.Text;
                stockOut.CompanyName = companyDropDownList.SelectedItem.Text;
                stockOut.StockOutQuantity = Convert.ToInt32(stockOutQuantityTextBox.Text);
                gridList.Add(stockOut);


                ViewState["AddItemListVS"] = gridList;
                return gridList;

                    

            }
            else
            {
                List<StockOut> secondGridList = (List<StockOut>) (ViewState["AddItemListVS"]);

                stockOut.ItemName = itemDropDownList.SelectedItem.Text;
                stockOut.CompanyName = companyDropDownList.SelectedItem.Text;
                stockOut.StockOutQuantity = Convert.ToInt32(stockOutQuantityTextBox.Text);
                secondGridList.Add(stockOut);
                ViewState["AddItemListVS"] = secondGridList;
                return secondGridList;


               
            }

        }




        }




    }


