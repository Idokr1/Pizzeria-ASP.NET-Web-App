using Microsoft.EntityFrameworkCore;
using PizzeriaASP.Models;

namespace PizzeriaASP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
