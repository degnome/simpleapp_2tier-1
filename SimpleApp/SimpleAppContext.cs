using Microsoft.EntityFrameworkCore;
using SimpleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp
{
    public class SimpleAppContext : DbContext
    {
        public SimpleAppContext(DbContextOptions<SimpleAppContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

    }
}
