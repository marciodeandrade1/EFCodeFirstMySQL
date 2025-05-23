using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstMySQL.Model
{
    public class MeuContexto : DbContext
    {
        public MeuContexto() : base("name=MeuContexto") => Database.SetInitializer(new CreateDatabaseIfNotExists<MeuContexto>());
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
