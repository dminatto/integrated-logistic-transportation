using delivery.logistics.infra.DAO.Migration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using delivery.logistics.domain.Entities;
using delivery.logistics.infra.DAO.Mapping;

namespace delivery.logistics.infra.DAO.Context
{
    public class DataContext : DbContext
    {
        public DbSet<DeliveryOrder> DeliveryOrder { get; set; }
        public DbSet<DeliveryProgress> DeliveryProgress { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<LocationTravel> LocationTravel { get; set; }

        public DataContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>("DefaultConnection"));
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new DeliveryOrderMap());
            modelBuilder.Configurations.Add(new DeliveryProgressMap());
            modelBuilder.Configurations.Add(new FeedbackMap());
            modelBuilder.Configurations.Add(new LocationTravelMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
