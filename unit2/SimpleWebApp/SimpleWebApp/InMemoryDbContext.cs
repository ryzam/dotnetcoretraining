using Microsoft.EntityFrameworkCore;
using SimpleWebApp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp
{
    public class InMemoryDbContext : DbContext
    {
        public InMemoryDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}
