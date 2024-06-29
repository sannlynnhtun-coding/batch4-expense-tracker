using Batch4.Api.ExpenseTracker.BusinessLogic.Services;
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
        public IActionResult Create()
        {
            return Ok();
        }

        [HttpGet("totalamount")]
        public IActionResult GetTotalAmount()
        {
            return Ok();
        }
    }
}
