using Batch4.Api.ExpenseTracker.DataAccess.Db;
using Batch4.Api.ExpenseTracker.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch4.Api.ExpenseTracker.DataAccess.Services
{
    public class DA_Expense
    {
        private readonly AppDbContext _context;

        public DA_Expense(AppDbContext context)
        {
            _context = context;
        }

        public ExpenseModel? GetExpense(int id)
        {
            var item = _context.Expenses.FirstOrDefault(x => x.ExpenseId == id);
            return item;
        }

        public int UpdateExpense(int id, ExpenseModel requestModel)
        {
            var item = _context.Expenses.FirstOrDefault(x => x.ExpenseId == id);
            if (item is null) return 0;

            item.CategoryId = requestModel.CategoryId;
            item.Description = requestModel.Description;
            item.Amount = requestModel.Amount;

            var result = _context.SaveChanges();
            return result;
        }

        public int DeleteExpense(int id)
        {
            var item = _context.Expenses.FirstOrDefault(x => x.ExpenseId == id);
            if (item is null) return 0;

            item.IsDelete = true;
            var result = _context.SaveChanges();
            return result;
        }
    }
}
