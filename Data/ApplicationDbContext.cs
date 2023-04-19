using Microsoft.EntityFrameworkCore;
using RazorPizza.Models;

namespace RazorPizza.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<pizzaOrder> PizzaOrders{ get; set; } //PizzaOrders is the name of the table.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}
