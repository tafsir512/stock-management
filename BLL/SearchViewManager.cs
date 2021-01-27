
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagementSystemApp.DAL.Gateway;
using StockManagementSystemApp.DAL.Model.ViewModel;

namespace StockManagementSystemApp.BLL
{
    public class SearchViewManager
    {
         private SearchViewGateway searchandviewGateway;

        public SearchViewManager()
        {
            searchandviewGateway = new SearchViewGateway();
        }
        public List<GetAllCompaniesViewModel> GetAllCompany()
        {
            return searchandviewGateway.GetAllCompany();
        }
        public List<GetAllCategoriesViewModel> GetAllItemsById(int companyId)
        {
            return searchandviewGateway.GetAllItemsById(companyId);
        }

        public List<GetAllCategoriesViewModel> GetAllCompanyItem()
        {
            return searchandviewGateway.GetAllCompanyItem();
        }

        public List<GetAllCategoriesViewModel> GetAllCompanyById(int companyId)
        {
            return searchandviewGateway.GetAllCompanyById(companyId);
        }

        public List<GetAllCategoriesViewModel> GetAllCompanyAndCategoryById(int categoryId, int companyId)
        {
            return searchandviewGateway.GetAllCompanyAndCategoryById(categoryId, companyId);
        }

        public List<GetAllCategoriesViewModel> GetAllCategoryItem()
        {
            return searchandviewGateway.GetAllCategoryItem();
        }

        public List<GetAllCategoriesViewModel> GetCategoryById(int categoryId)
        {
            return searchandviewGateway.GetCategoryById(categoryId);
        }

    }
}