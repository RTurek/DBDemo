namespace OGSys.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using OGSys.Web.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<OGSys.Web.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "OGSys.Web.Models.ApplicationDbContext";
        }

        bool AddUserAndRole(OGSys.Web.Models.ApplicationDbContext context)
        {
            IdentityResult ir;
            var rm = new RoleManager<IdentityRole>
                (new RoleStore<IdentityRole>(context));
            ir = rm.Create(new IdentityRole("canEdit"));
            var um = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            var user = new ApplicationUser()
            {
                UserName = "admin@RTurek.com",
            };
            ir = um.Create(user, "123456");
            if (ir.Succeeded == false)
                return ir.Succeeded;
            ir = um.AddToRole(user.Id, "canEdit");
            return ir.Succeeded;
        }

        protected override void Seed(OGSys.Web.Models.ApplicationDbContext context)
        {
            AddUserAndRole(context);

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
