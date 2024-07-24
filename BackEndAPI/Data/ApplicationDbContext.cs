using BackEndAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEndAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Productos> Productos { get; set; }
    }
}
