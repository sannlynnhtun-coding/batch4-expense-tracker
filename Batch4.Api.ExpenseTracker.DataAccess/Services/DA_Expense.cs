﻿using Batch4.Api.ExpenseTracker.DataAccess.Db;
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

        public DA_Expense()
        {
            _context = new AppDbContext();
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
