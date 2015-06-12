namespace Data.Migrations
{
    using Data.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.AppDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            //this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Data.AppDbContext context)
        {
            context.Users.Add(new User() { Username = "admin", PassHash = "admin", Role = Role.Administrator });
            context.SaveChanges();
        }
    }
}
