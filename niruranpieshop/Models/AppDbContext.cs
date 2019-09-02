using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace niruranpieshop.Models
{
    public class AppDbContext: DbContext 
    {
        // The class between Code, Application and Database ( part of using EF Core)

         public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Pie> Pies { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }


    }
}

