using admin.domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace admin.infra.data.DAO.Mapping
{
    public class CompanyMap : EntityTypeConfiguration<Company>
    {
        public void Configure()
        {
            HasKey(c => c.Id);

            Property(c => c.CnpjCompany).IsRequired();

            Property(c => c.StateRegistrationCompany).IsRequired();

            Property(c => c.NameCompany).IsRequired();

            Property(c => c.NameFantasy).IsRequired();

            Property(c => c.EmailCompany).IsRequired();

            Property(c => c.CepCompany).IsRequired();

            Property(c => c.CountryCompany).IsRequired();

            Property(c => c.StateCompany).IsRequired();

            Property(c => c.CityCompany).IsRequired();

            Property(c => c.AderessCompany).IsRequired();

            Property(c => c.NumberAderessCompany).IsRequired();

            Property(c => c.ComplementCompany).IsRequired();

            Property(c => c.DistrictCompany).IsRequired();

            Property(c => c.EmailAcessCTE).IsOptional();

            Property(c => c.PasswordAcessCTE).IsOptional();

        }
    }
}
