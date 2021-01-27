using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagementSystemApp.DAL.Model.ViewModel
{
    public class GetAllCategoriesViewModel
    {
        public string ItemName { get; set; }
        public string CompanyName { get; set; }
        public int AvailableQuantity { get; set; }
        public int ReorderLevel { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}