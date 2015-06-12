namespace Data
{
    using System.Data.Entity;
    using Data.Models;
    using Data.Migrations;

    public class AppDbContext:DbContext
    {
        public AppDbContext()
            : base("DefaultConnection")
            {
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, Configuration>());
            }

            public DbSet<User> Users { get; set; }

            public DbSet<Absence> Absences { get; set; }

             public DbSet<Class> Classes { get; set; }



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
