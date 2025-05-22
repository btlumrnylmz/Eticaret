using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Reflection;

namespace Eticaret.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {//local
           optionsBuilder.UseSqlServer(@"Server=DESKTOP-98P21PR;Database=EticaretDb;Trusted_Connection=True;TrustServerCertificate=True;");

            // optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
           //free server
           // optionsBuilder.UseSqlServer(@"workstation id=E_ticaret.mssql.somee.com;packet size=4096;user id=betulumran_SQLLogin_4;pwd=l5u7gp216a;data source=E_ticaret.mssql.somee.com;persist security info=False;initial catalog=E_ticaret;TrustServerCertificate=True;");
            //base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }

}
