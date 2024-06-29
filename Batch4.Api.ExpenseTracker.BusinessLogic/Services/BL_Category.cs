using Batch4.Api.ExpenseTracker.DataAccess.Models;
using Batch4.Api.ExpenseTracker.DataAccess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch4.Api.ExpenseTracker.BusinessLogic.Services
{
    public class BL_Category
    {
        private readonly DA_Category _da_Category;

        //public BL_Category()
        //{
        //    _da_Category = new DA_Category();
        //}

        public BL_Category(DA_Category da_Category)
        {
            _da_Category = da_Category;
        }

        public int UpdateCategory(int id,CategoryModel requestModel)
        {
            var result = _da_Category.UpdateCategory(id, requestModel);
            return result;
        }

        public int DeleteCategory(int id)
        {
            var result = _da_Category.DeleteCategory(id);
            return result;
        }
    }
}
