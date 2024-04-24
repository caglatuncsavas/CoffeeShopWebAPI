using CoffeeShop.WebAPI.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MenusController : ControllerBase
{
    AppDbContext _context;
    public MenusController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetMenus()
    {
        //Eager loading
        var menus = _context.Menus.Include("SubMenus");
        return Ok(menus);
    }

    [HttpGet("{id}")]
    public IActionResult GetMenu(int id)
    {
        var menu = _context.Menus.Include("SubMenus").FirstOrDefault(p => p.Id == id);
        if(menu is null)
        {
            return NotFound();
        }

        return Ok(menu);
    }
}
