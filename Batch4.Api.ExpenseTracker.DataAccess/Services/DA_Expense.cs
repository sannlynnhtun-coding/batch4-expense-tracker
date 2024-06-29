using Batch4.Api.ExpenseTracker.DataAccess.Db;
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
    }
}
