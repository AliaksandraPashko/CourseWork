namespace PassWebService.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using PassWebService.Infrastructure;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PassWebService.Infrastructure.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PassWebService.Infrastructure.ApplicationDbContext context)
        {
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "a.pashko",
                Email = "sasha_pashko@mail.ru",
                EmailConfirmed = true,
                FirstName = "Aliaksandra",
                LastName = "Pashko",
                Level = 1,
                JoinDate = DateTime.Now
            };

            manager.Create(user, "mypassword");
        }
    }
}
