using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StockManagementSystemApp.DAL.Gateway;
using StockManagementSystemApp.DAL.Model;

namespace StockManagementSystemApp.BLL
{
    public class CategoryManager
    {
        CategoryGateway categoryGateway=new CategoryGateway();

        public string Save(Category category)
        {
            if (categoryGateway.IsExistsCategoryName(category.CategoryName))
            {
                return "Name Already Exists";
            }
            else
            {


                int rowAffect = categoryGateway.Save(category);
                if (rowAffect > 0)
                {
                    return "Save Successful";
                }
                else
                {
                    return "Save Failed";
                }
            }
            


        }

        public List<Category> GetAllCategories()
        {
            return categoryGateway.GetAllCategories();
        }

        public Category GetCategoryById(int id)
        {
            return categoryGateway.GetCategoryById(id);
        }

        public string UpdateById(Category category)
        {
            if (categoryGateway.IsExistsCategoryName(category.CategoryName))
            {
                return "Name Already Exists";
            }
            else
            {
                int rowAffect = categoryGateway.UpdateById(category);
                if (rowAffect > 0)
                {
                    return "Update Successful";
                }
                else
                {
                    return "Update Failed";
                }
            }
        }
        }
    }
