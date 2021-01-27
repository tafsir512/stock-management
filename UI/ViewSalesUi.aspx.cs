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
    public partial class ViewSalesUi : System.Web.UI.Page
    {
        ViewSalesManager viewSalesManager=new ViewSalesManager();
        public string fromDate;
        public string toDate;
        protected void Page_Load(object sender, EventArgs e)
        {
            fromDateCalendar.Visible = false;
            toDateCalendar.Visible = false;
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            fromDate = fromDateTextBox.Text;
            toDate = toDateTextBox.Text;

            if (fromDate == "" && toDate == "")
            {
                

                {
                    outputLabel.Text = "Please Select Date";
                }
            }

            else
            {
                DateTime dt1 = DateTime.Parse(fromDate);
                DateTime dt2 = DateTime.Parse(toDate);

                if (dt1.Date > dt2.Date)
                {
                    outputLabel.Text = "From Date is Larger Then To Date";
                    viewSalesGridView.DataSource = null;
                    viewSalesGridView.DataBind();

                }
                else
                {
                    outputLabel.Text = "";
                    viewSalesGridView.DataSource = viewSalesManager.GetAllDates(fromDate, toDate);
                    viewSalesGridView.DataBind();
                }
            }
           
        }





        protected void fromDateCalendar_SelectionChanged(object sender, EventArgs e)
        {
            fromDateTextBox.Text = fromDateCalendar.SelectedDate.ToShortDateString();
            fromDateCalendar.Visible = false;
        }

        protected void toDateCalendar_SelectionChanged(object sender, EventArgs e)
        {
            toDateTextBox.Text = toDateCalendar.SelectedDate.ToShortDateString();
            toDateCalendar.Visible = false;
        }

        protected void searchButton1_Click(object sender, EventArgs e)
        {
            fromDateCalendar.Visible = true;
            fromDateTextBox.Visible = true;
        }

        protected void searchButton2_Click(object sender, EventArgs e)
        {
            toDateCalendar.Visible = true;
            toDateTextBox.Visible = true;
        }
    }
}