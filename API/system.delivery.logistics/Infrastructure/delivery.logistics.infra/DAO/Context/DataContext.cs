using delivery.logistics.infra.DAO.Migration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delivery.logistics.infra.DAO.Context
{
    public class DataContext : DbContext
    {
        //public DbSet<HelpDesk> HelpDesk { get; set; }
        
        public DataContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>("DefaultConnection"));
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //modelBuilder.Configurations.Add(new HelpDeskMap());
           
            base.OnModelCreating(modelBuilder);
        }
    }
}
