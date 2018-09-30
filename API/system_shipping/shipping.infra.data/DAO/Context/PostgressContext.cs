using shipping.infra.data.DAO.Migrations;
using System.Data.Entity;

namespace shipping.infra.data.DAO.Context
{
    public class PostgressContext : DbContext
    {
        //public DbSet<Livro> Livros { get; set; }

        public PostgressContext() : base ("DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<PostgressContext, Configuration>("DefaultConnection"));
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           /* modelBuilder.Entity<Company>(new CompanyMap().Configure);
            modelBuilder.Entity<CompanyPartner>(new CompanyPartnerMap().Configure);
            modelBuilder.Entity<Country>(new CountryMap().Configure);
            modelBuilder.Entity<State>(new StateMap().Configure);
            modelBuilder.Entity<User>(new UserMap().Configure);
            modelBuilder.Entity<UserProfile>(new UserProfileMap().Configure);
            modelBuilder.Entity<Customer>(new CustomerMap().Configure);*/
        }
    }
}
