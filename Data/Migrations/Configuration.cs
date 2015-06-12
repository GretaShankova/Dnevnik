namespace Data.Migrations
{
    using Data.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.AppDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(Data.AppDbContext context)
        {
            //context.Users.Add(new User() { Username = "admin", PassHash = "admin", Role = Role.Administrator });
            //context.SaveChanges();
        }
    }
}
