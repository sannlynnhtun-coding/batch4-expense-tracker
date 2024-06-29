using Batch4.Api.ExpenseTracker.BusinessLogic.Services;
using Batch4.Api.ExpenseTracker.DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Batch4.Api.ExpenseTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly BL_Expense _bl_Expense;

        public ExpenseController(BL_Expense bl_Expense)
        {
            _bl_Expense = bl_Expense;
        }

        [HttpGet]
        public IActionResult Read()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Edit(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Create(ExpenseRequestModel expense)
        {
            var result = _bl_Expense.CreateExpense(expense);
            string message = result > 0 ? "Saving Successful" : "Saving Failded";
            return Ok(message);
        }

        [HttpGet("category/{categoryId}")]
        public IActionResult GetExpenseByCategory(int categoryId)
        {
            var lst = _bl_Expense.GetExpenseByCategory(categoryId);
            if (lst is null || lst.Count == 0)
            {
                return NotFound("No data found");
            }
            return Ok(lst);
        }
        
        [HttpGet("totalamount")]
        public IActionResult GetTotalAmount()
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //var item = _bl_Expense.GetExpense(id);
            //if (item is null)
            //{
            //    return NotFound("No Data Found");
            //}

            var result = _bl_Expense.DeleteExpense(id);
            string message = result > 0 ? "Delete Successful." : "Delete Failed";
            return Ok(message);
        }
    }
}
