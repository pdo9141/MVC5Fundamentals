namespace IdentityDemo.Migrations
{
    using System.Linq;
    using System.Data.Entity.Migrations;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<IdentityDemo.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "IdentityDemo.Models.ApplicationDbContext";
        }

        protected override void Seed(IdentityDemo.Models.ApplicationDbContext context)
        {
            /*
            var hasher = new PasswordHasher();
            context.Users.AddOrUpdate(u => u.UserName,
                new ApplicationUser { UserName = "widowmaker", PasswordHash = hasher.HashPassword("password") });
            */

            if (!context.Users.Any(u => u.UserName == "pdo9141@yahoo.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "pdo9141@yahoo.com", Email = "pdo9141@yahoo.com" };
                manager.Create(user, "Phd@78799141");
            }
        }
    }
}
