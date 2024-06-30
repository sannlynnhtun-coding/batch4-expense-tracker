using Batch4.Api.ExpenseTracker.DataAccess.Models;
using Batch4.Api.ExpenseTracker.DataAccess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch4.Api.ExpenseTracker.BusinessLogic.Services
{
    public class BL_Expense
    {
        private readonly DA_Expense _da_Expense;

        public BL_Expense(DA_Expense da_Expense)
        {
            _da_Expense = da_Expense;
        }

        public ExpenseModel? GetExpense(int id)
        {
            var item = _da_Expense.GetExpense(id);
            return item;
        }

        public int CreateExpense(ExpenseRequestModel expense)
        {
            var result = _da_Expense.CreateExpense(expense);
            return result;
        }

        public List<ExpenseDetailModel> GetExpenseByCategory(int categoryId)
        {
            var lst = _da_Expense.GetExpenseByCategory(categoryId);
            return lst;
        }

        public decimal GetTotalExpense()
        {
            var total = _da_Expense.GetTotalExpense();
            return total;
        }

        public int UpdateExpense(int id , ExpenseModel requestModel)
        {
            var result = _da_Expense.UpdateExpense(id, requestModel);
            return result;
        }

        public int DeleteExpense(int id)
        {
            var result = _da_Expense.DeleteExpense(id);
            return result;
        }
    }
}
