namespace NewAssign2.Migrations
{
    using Models;
    using System.Collections.Generic;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NewAssign2.DAL.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NewAssign2.DAL.StoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var categories = new List<Category>
            {
                new Category {Name = "Audi" },
                new Category {Name = "BMW" },
                new Category {Name = "Honda" },
                new Category {Name = "Holden" },
                new Category {Name = "Toyota" },
                new Category {Name = "Tesla" },
                new Category {Name = "Suzki" },
                new Category {Name = "Ford" },
                new Category {Name = "Nissan" },
                new Category {Name = "Land Rover" },
             };
            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
            var products = new List<Product>
            {
                new Product {Name = "A6",Year="2012",Type="Automatic", Price = 30000, Description = "Comfortable", CategoryID= categories.Single(c=>c.Name == "Audi").ID},
                new Product {Name = "330i",Year="2009",Type="Automatic", Price = 8000, Description = "Drive Interesting", CategoryID= categories.Single(c=>c.Name == "BMW").ID},
                new Product {Name = "Bluebird",Year="2005",Type="Tiptronic", Price = 6000, Description = "Affordable", CategoryID= categories.Single(c=>c.Name == "Nissan").ID},
                new Product {Name = "Prius",Year="2012",Type="Automatic", Price = 12000, Description = "Hybrid", CategoryID= categories.Single(c=>c.Name == "Toyota").ID},
                new Product {Name = "Corrolla",Year="2016",Type="Tiptronic", Price = 23000, Description = "New Zealand New", CategoryID= categories.Single(c=>c.Name == "Toyota").ID},
                new Product {Name = "Range Rover",Year="2010",Type="Automatic", Price = 46995, Description = "Strong Power", CategoryID= categories.Single(c=>c.Name == "Land Rover").ID},
                new Product {Name = "Model S",Year="2015",Type="Automatic", Price = 109000, Description = "Electric Engine", CategoryID= categories.Single(c=>c.Name == "Tesla").ID},
                new Product {Name = "Swift",Year="2009",Type="Automatic", Price = 10000, Description = "Good Shape", CategoryID= categories.Single(c=>c.Name == "Suzki").ID},
                new Product {Name = "CH-R",Year="2017",Type="Automatic", Price = 32990, Description = "Fuel Save", CategoryID= categories.Single(c=>c.Name == "Toyota").ID},
                new Product {Name = "Civic",Year="2009",Type="Manual", Price = 7000, Description = "Durable", CategoryID= categories.Single(c=>c.Name == "Honda").ID},
                new Product {Name = "A4",Year="2011",Type="Automatic", Price = 17890, Description = "Full Service History", CategoryID= categories.Single(c=>c.Name == "Audi").ID},
            };
            products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
        }
    }
}
