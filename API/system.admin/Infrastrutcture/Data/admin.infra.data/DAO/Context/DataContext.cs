using admin.domain.Entities;
using admin.infra.data.DAO.Mapping;
using admin.infra.data.DAO.Migration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace admin.infra.data.DAO.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyPartner> CompanyPartner { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<Customer> Customer { get; set; }

        public DataContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>("DefaultConnection"));
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new CompanyMap());
            modelBuilder.Configurations.Add(new CompanyPartnerMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new StateMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserProfileMap());
            modelBuilder.Configurations.Add(new CustomerMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
