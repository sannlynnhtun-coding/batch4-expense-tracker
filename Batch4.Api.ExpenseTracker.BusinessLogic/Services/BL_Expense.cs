using Batch4.Api.ExpenseTracker.DataAccess.Services;
using Microsoft.IdentityModel.Tokens;
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
        public BL_Expense()
        {
            _da_Expense = new DA_Expense();
        }
        public int DeleteExpense(int id)
        {
            var result = _da_Expense.DeleteExpense(id);
            return result;
        }
    }
}
