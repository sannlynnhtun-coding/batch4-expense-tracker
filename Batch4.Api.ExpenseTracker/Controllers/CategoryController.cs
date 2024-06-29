using Batch4.Api.ExpenseTracker.BusinessLogic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Batch4.Api.ExpenseTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly BL_Category _bl_Category;

        public CategoryController()
        {
            _bl_Category = new BL_Category();
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

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _bl_Category.DeleteCategory(id);
            string message = result > 0 ? "Delete Successful." : "Delete Failed";
            return Ok(message);
        }
    }
}
