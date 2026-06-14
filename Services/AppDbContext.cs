using HomeworkTHREE.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeworkTHREE
{

        public class AppDbContext : DbContext
        {
       
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

            public DbSet<MyCity> Cities { get; set; }
        }
    }