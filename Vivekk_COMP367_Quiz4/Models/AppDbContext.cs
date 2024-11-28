using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Vivekk_COMP367_Quiz4.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; } // DbSet for Person entities

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
