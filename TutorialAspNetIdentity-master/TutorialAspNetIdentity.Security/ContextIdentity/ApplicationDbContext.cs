using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using TutorialAspNetIdentity.Security.Models;

namespace TutorialAspNetIdentity.Security.ContextIdentity
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("strConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer<ApplicationDbContext>(null);
        }

        public DbSet<Client> Client { get; set; }

        public DbSet<Claims> Claims { get; set; }

        public DbSet<Place> Place { get; set; }

        public DbSet<Obj> Obj { get; set; }

        public DbSet<UserInfo> UserInfo { get; set; }

        public DbSet<Air> Air { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<MyBasket> MyBasket { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
}
