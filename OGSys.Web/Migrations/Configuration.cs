namespace OGSys.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using OGSys.Web.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<OGSys.Web.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "OGSys.Web.Models.ApplicationDbContext";
        }

        protected override void Seed(OGSys.Web.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Customers.AddOrUpdate(
              p => p.FirstName,
              new Customer
              {
                  FirstName = "Ryan",
                  LastName = "Turek",
                  CompanyName = "Improving Enterprises, Inc.",
                  Address = "16633 Dallas Pwky #100",
                  City = "Addison",
                  State = "Texas",
                  Zip = "75001",
                  PhoneNumber = "2146134444",
                  Email = "Improver@ImprovingEnterprises.com"
              },
              new Customer
              {
                  FirstName = "Jon",
                  LastName = "Livesay",
                  CompanyName = "Improving Enterprises, Inc.",
                  Address = "16633 Dallas Pwky #100",
                  City = "Addison",
                  State = "Texas",
                  Zip = "75001",
                  PhoneNumber = "2146134444",
                  Email = "Improver@ImprovingEnterprises.com"
              },
              new Customer
              {
                  FirstName = "Sam",
                  LastName = "Marsh",
                  CompanyName = "Improving Enterprises, Inc.",
                  Address = "16633 Dallas Pwky #100",
                  City = "Addison",
                  State = "Texas",
                  Zip = "75001",
                  PhoneNumber = "2146134444",
                  Email = "Improver@ImprovingEnterprises.com"
              },
              new Customer
              {
                  FirstName = "Kevin",
                  LastName = "Berry",
                  CompanyName = "Improving Enterprises, Inc.",
                  Address = "16633 Dallas Pwky #100",
                  City = "Addison",
                  State = "Texas",
                  Zip = "75001",
                  PhoneNumber = "2146134444",
                  Email = "Improver@ImprovingEnterprises.com"
              },
              new Customer
              {
                  FirstName = "David",
                  LastName = "Ford",
                  CompanyName = "Improving Enterprises, Inc.",
                  Address = "16633 Dallas Pwky #100",
                  City = "Addison",
                  State = "Texas",
                  Zip = "75001",
                  PhoneNumber = "2146134444",
                  Email = "Improver@ImprovingEnterprises.com"
              },
              new Customer
              {
                  FirstName = "Walton",
                  LastName = "Leavell",
                  CompanyName = "Improving Enterprises, Inc.",
                  Address = "16633 Dallas Pwky #100",
                  City = "Addison",
                  State = "Texas",
                  Zip = "75001",
                  PhoneNumber = "2146134444",
                  Email = "Improver@ImprovingEnterprises.com"
              }
            );
        }
    }
}
