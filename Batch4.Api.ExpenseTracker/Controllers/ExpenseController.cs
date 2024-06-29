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
            var item = _bl_Expense.GetExpense(id);
            if (item is null)
            {
                return NotFound("No data found.");
            }

            return Ok(item);
        }

        [HttpPut("id")]
        public IActionResult Update(int id , ExpenseModel requestModel) 
        { 
            var result = _bl_Expense.UpdateExpense(id , requestModel);
            string message = result > 0 ? "Update Successful." : "Update Failed";
            return Ok(message);
        }

        [HttpPost]
        public IActionResult Create()
        {
            return Ok();
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
