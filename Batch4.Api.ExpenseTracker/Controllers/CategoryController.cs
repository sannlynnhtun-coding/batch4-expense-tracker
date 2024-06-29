using Batch4.Api.ExpenseTracker.BusinessLogic.Services;
using Batch4.Api.ExpenseTracker.DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Batch4.Api.ExpenseTracker.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly BL_Category _bl_Category;

    public CategoryController(BL_Category bl_Category)
    {
        _bl_Category = bl_Category;
    }

    //public CategoryController()
    //{
    //    _bl_Category = new BL_Category();
    //}

    [HttpGet]
    public IActionResult Read()
    {
        var lst = _bl_Category.GetCategorys();
        return Ok(lst);
    }

    [HttpGet("{id}")]
    public IActionResult Edit(int id)
    {   
        var item = _bl_Category.GetCategory(id);
        if(item is null)
        {
            return NotFound("No Data Found.");
        }
        return Ok(item);
    }

    [HttpPost]
    public IActionResult Create()
    {
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, CategoryModel requestModel)
    {
        //var item = _bl_Category.GetCategory(id);
        //if (item is null)
        //{
        //    return NotFound("No Data Found");
        //}

        var result = _bl_Category.UpdateCategory(id, requestModel);
        string message = result > 0 ? "Updating Successful." : "Updating Failed.";
        return Ok(message);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var result = _bl_Category.DeleteCategory(id);
        string message = result > 0 ? "Delete Successful." : "Delete Failed";
        return Ok(message);
    }
}
