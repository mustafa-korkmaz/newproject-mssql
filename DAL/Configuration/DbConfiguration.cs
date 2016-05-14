using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Configuration
{
    public class YodaDbContextConfiguration : DbConfiguration
    {
        public YodaDbContextConfiguration()
        {
            this.SetDatabaseInitializer(new DropCreateDatabaseIfModelChanges<YodaDbContext>());
            this.SetProviderServices(SqlProviderServices.ProviderInvariantName, SqlProviderServices.Instance);
        }
    }
}


