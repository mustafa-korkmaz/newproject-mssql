using System.Data.Entity;
using DAL.Configuration;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DAL.Models
{
    public class YodaDbContext : IdentityDbContext<ApplicationUser>
    {
        public YodaDbContext() : base("YodaDbConnection")
        {
        }

        public static YodaDbContext Create()
        {
            return new YodaDbContext();
        }

        public DbSet<TestCodeFirstModel> TestsFirstModels { get; set; }
        //public DbSet<Market> Markets { get; set; }
        //public DbSet<MarketUser> MarketUsers { get; set; }
        //public DbSet<MarketUserIntegration> MarketUserIntegrations { get; set; }
        //public DbSet<IntegrationDetail> IntegrationDetails { get; set; }
        //public DbSet<Integration> Integrations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Properties<string>().Configure(x => x.HasColumnType("VARCHAR")); // dont use unicode for string columns
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUserClaim>().Property(x => x.ClaimType).HasMaxLength(10);
            modelBuilder.Entity<IdentityUserClaim>().Property(x => x.ClaimValue).HasMaxLength(20);

            modelBuilder.Entity<IdentityRole>().Property(x => x.Name).HasMaxLength(10);
        }

        //public void FixEfProviderServicesProblem()
        //{
        //    //The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
        //    //for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
        //    //Make sure the provider assembly is available to the running application. 
        //    //See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.

        //    var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        //}

    }

}
