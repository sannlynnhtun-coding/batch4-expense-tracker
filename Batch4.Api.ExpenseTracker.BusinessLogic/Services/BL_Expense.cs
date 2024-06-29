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
    }
}
