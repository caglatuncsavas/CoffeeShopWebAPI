using CoffeeShop.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.WebAPI.Context;

public class AppDbContext :DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
    {
        
    }

    public DbSet<Menu> Menus { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
}
