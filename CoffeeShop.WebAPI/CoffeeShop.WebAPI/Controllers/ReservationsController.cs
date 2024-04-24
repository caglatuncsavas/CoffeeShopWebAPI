using CoffeeShop.WebAPI.Context;
using CoffeeShop.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ReservationsController : ControllerBase
{

    AppDbContext _context;
    public ReservationsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]

    public IActionResult Post(Reservation reservation)
    {
        _context.Reservations.Add(reservation);
        _context.SaveChanges();
        return StatusCode(StatusCodes.Status201Created);
    }
}
