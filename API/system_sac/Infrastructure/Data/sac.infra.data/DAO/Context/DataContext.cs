using System.Data;
using sac.domain.Entities;
using sac.infra.data.DAO.Mapping;
using sac.infra.data.DAO.Migration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace sac.infra.data.DAO.Context
{
    public class DataContext : DbContext
    {
        public DbSet<HelpDesk> HelpDesk { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<InteractionTicket> InteractionTicket { get; set; }

        public DataContext() : base("AppDatabaseConnectionString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>("AppDatabaseConnectionString"));
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new HelpDeskMap());
            modelBuilder.Configurations.Add(new TicketMap());
            modelBuilder.Configurations.Add(new InteractionTiketMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
