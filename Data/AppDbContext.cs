using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Data.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Data.Migrations;

namespace Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
            : base("DefaultConnection")
            {
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, Configuration>());
            }

            public DbSet<User> Users { get; set; }



            public static AppDbContext Create()
            {
                return new AppDbContext();
            }

            public override int SaveChanges()
            {
                return base.SaveChanges();
            }
        }
}
