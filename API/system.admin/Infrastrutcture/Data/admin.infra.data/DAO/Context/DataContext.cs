using admin.domain.Entities;
using admin.infra.data.DAO.Mapping;
using admin.infra.data.DAO.Migration;
using admin.Infra.data.DAO.Mapping;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace admin.infra.data.DAO.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Address> Address { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyPartner> CompanyPartner { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserPermissions> UserPermissions { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }
        
        public DataContext() : base("AppDatabaseConnectionString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>("AppDatabaseConnectionString"));
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new CompanyMap());
            modelBuilder.Configurations.Add(new CompanyPartnerMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new StateMap());

            modelBuilder.Configurations.Add(new UserPermissionsMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserProfileMap());
            

            base.OnModelCreating(modelBuilder);
        }
    }
}
