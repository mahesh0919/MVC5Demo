namespace MVC5Demo.Migrations
{
    using MVC5Demo.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC5Demo.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "MVC5Demo.Models.ApplicationDbContext";
        }

        protected override void Seed(MVC5Demo.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Products.AddOrUpdate(
              p => p.ProductName,
              new Product { ProductName = "Pen", UnitsinStock = 2 },
              new Product { ProductName = "Book", UnitsinStock = 3 },
              new Product { ProductName = "Ball" , UnitsinStock = 4 }
            );
            
        }
    }
}
