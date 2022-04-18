using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DAL
{
    class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string connectionString = "Data Source=.;Initial Catalog=FreamworkTask;"
        + "Integrated Security=true;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Course>courses { get; set; }
    }
}
