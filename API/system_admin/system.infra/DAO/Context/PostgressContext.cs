using Microsoft.EntityFrameworkCore;
using admin.domain.Entities;
using system.infra.DAO.Mapping;
using System;

namespace admin.infra.DAO.Context
{
    public class PostgressContext : DbContext
    {
        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyPartner> CompanyPartner { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<Customer> Customer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseNpgsql("Server=[SERVIDOR];Port=[PORTA];Database=modelo;Uid=[USUARIO];Pwd=[SENHA]");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Company>(new CompanyMap().Configure);
            modelBuilder.Entity<CompanyPartner>(new CompanyPartnerMap().Configure);
            modelBuilder.Entity<Country>(new CountryMap().Configure);
            modelBuilder.Entity<State>(new StateMap().Configure);
            modelBuilder.Entity<User>(new UserMap().Configure);
            modelBuilder.Entity<UserProfile>(new UserProfileMap().Configure);
            modelBuilder.Entity<Customer>(new CustomerMap().Configure);
        }
    }
}
