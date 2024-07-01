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

        public List<ExpenseModel> GetExpense()
        {
            var lst = _context.Expenses.ToList() ;
            return lst;
        }
        public ExpenseModel? GetExpense(int id)
        {
            var item = _context.Expenses.FirstOrDefault(x => x.ExpenseId == id && x.IsDelete == false);
            return item;
        }

        public int CreateExpense(ExpenseRequestModel expense)
        {
            var item = new ExpenseModel
            {
                CategoryId = expense.CategoryId,
                Description = expense.Description,
                Amount = expense.Amount,
                Date = DateTime.Now,
                IsDelete = false
            };

            _context.Expenses.Add(item);
            var result = _context.SaveChanges();
            return result;
        }

        public List<ExpenseDetailModel> GetExpenseByCategory(int categoryId)
        {
            var result = _context.Expenses.Where(x => x.CategoryId == categoryId);

            List<ExpenseDetailModel> lst = result.Select(x => new ExpenseDetailModel
            {
                Description = x.Description,
                Amount = x.Amount,
                Date = x.Date
            }).ToList();
            return lst;
        }

        public decimal GetTotalExpense()
        {
            var total = _context.Expenses
                .Where(x => x.IsDelete == false)
                .Sum(x => x.Amount);
            return total;
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
