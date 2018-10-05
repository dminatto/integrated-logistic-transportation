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

            Property(c => c.NameCompany).IsRequired();

            Property(c => c.NameFantasy).IsRequired();

            Property(c => c.EmailCompany).IsRequired();

            Property(c => c.AddressCompany).IsRequired();

            Property(c => c.EmailAcessCTE).IsOptional();

            Property(c => c.PasswordAcessCTE).IsOptional();

        }
    }
}
