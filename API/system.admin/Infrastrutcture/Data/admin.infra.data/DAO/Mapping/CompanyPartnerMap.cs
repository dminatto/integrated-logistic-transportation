using admin.domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace admin.Infra.data.DAO.Mapping
{
    public class CompanyPartnerMap : EntityTypeConfiguration<CompanyPartner>
    {
        public void Configure()
        {
            HasKey(c => c.Id);

            Property(c => c.CnpjCompanyPartner).IsRequired();
            
            Property(c => c.NameCompanyPartner).IsRequired();

            Property(c => c.EmailCompanyPartner).IsRequired();

            Property(c => c.AderessCompanyPartner).IsRequired();

            Property(c => c.TypeCompanyPartner).IsRequired();
        }
    }
}
