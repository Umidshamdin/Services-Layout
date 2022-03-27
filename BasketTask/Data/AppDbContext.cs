using BasketTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketTask.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<DesignCard> DesignCards { get; set; }
        public DbSet<OwlCarusel> OwlCarusels { get; set; }

        public DbSet<Setting> Settings { get; set; }




    }
}
