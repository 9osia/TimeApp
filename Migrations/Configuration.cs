namespace TimeApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TimeApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TimeApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TimeApp.Models.ApplicationDbContext context)
        {
            context.Projects.AddOrUpdate(c => c.Name, new Project { Name = "Skrzynka odbiorcza", Description = "Zadania nieprzydzielone do ¿adnej kategorii" });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
