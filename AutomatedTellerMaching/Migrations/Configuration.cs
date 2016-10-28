namespace AutomatedTellerMaching.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using Services;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AutomatedTellerMaching.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "AutomatedTellerMaching.Models.ApplicationDbContext";
        }

        protected override void Seed(AutomatedTellerMaching.Models.ApplicationDbContext context)
        {
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            if (!context.Users.Any(t => t.UserName == "admin@mvcatm.com"))
            {
                var user = new ApplicationUser { UserName = "admin@mvcatm.com", Email = "admin@mvcatm.com" };
                userManager.Create(user, "passW0rd!");
                var service = new CheckingAccountService(context);
                service.CreateCheckingAccount("admin", "user", user.Id, 1000);

                //now to create roles
                context.Roles.AddOrUpdate(r => r.Name, new IdentityRole { Name = "Admin" });
                context.SaveChanges();
                userManager.AddToRole(user.Id, "Admin");


            }

            context.Transactions.Add(new Transaction { Amount = -300, CheckingAccountId = 5 });
            context.Transactions.Add(new Transaction { Amount = 500, CheckingAccountId = 5 });
            context.Transactions.Add(new Transaction { Amount = 255, CheckingAccountId = 5 });
            context.Transactions.Add(new Transaction { Amount = 800, CheckingAccountId = 5 });
            context.Transactions.Add(new Transaction { Amount = 450, CheckingAccountId = 5 });
            context.Transactions.Add(new Transaction { Amount = 900, CheckingAccountId = 5 });
            context.Transactions.Add(new Transaction { Amount = 19875, CheckingAccountId = 5 });
            context.Transactions.Add(new Transaction { Amount = -30009, CheckingAccountId = 5 });
            context.Transactions.Add(new Transaction { Amount = 87645, CheckingAccountId = 5 });
            context.Transactions.Add(new Transaction { Amount = 900, CheckingAccountId = 5 });
            context.Transactions.Add(new Transaction { Amount = 1234, CheckingAccountId = 5 });
            context.Transactions.Add(new Transaction { Amount = -742, CheckingAccountId = 5 });
            context.Transactions.Add(new Transaction { Amount = 2922, CheckingAccountId = 5 });
            context.Transactions.Add(new Transaction { Amount = 1209, CheckingAccountId = 5 });

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
        }
    }
}
