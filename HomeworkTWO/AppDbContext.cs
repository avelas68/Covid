using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HomeworkTWO

{
    class AppDbContext : DbContext
    {
        private static readonly string ConnectionString;

        static AppDbContext()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            ConnectionString = config.GetConnectionString("Default");
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(ConnectionString);
        }

        public DbSet<MyCity> Cities { get; set; }

     
    }
}

