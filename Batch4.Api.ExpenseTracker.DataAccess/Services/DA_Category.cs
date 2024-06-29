using Batch4.Api.ExpenseTracker.DataAccess.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch4.Api.ExpenseTracker.DataAccess.Services;

public class DA_Category
{
    private readonly AppDbContext _context;
    public DA_Category(AppDbContext context)
    {
        //_context = new AppDbContext();
        _context = context;
    }

    public int DeleteCategory(int id)
    {
        var item = _context.Categories.FirstOrDefault(x => x.CategoryId == id);
        if (item is null) return 0;

        _context.Categories.Remove(item);
        var result = _context.SaveChanges();
        return result;
    }
}
