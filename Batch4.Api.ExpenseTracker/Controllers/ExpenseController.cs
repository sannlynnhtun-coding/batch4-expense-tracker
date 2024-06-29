using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Batch4.Api.ExpenseTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
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
