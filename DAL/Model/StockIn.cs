using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagementSystemApp.DAL.Gateway;

namespace StockManagementSystemApp.DAL.Model
{
    public class StockIn :BaseGateway
    {
        public int StockInItemId { get; set; }
        public int ItemId { get; set; }
        public int AvailableQuantity { get; set; }
        public int ReorderLevel { get; set; }
    }
}