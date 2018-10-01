using admin.domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace admin.infra.data.DAO.Mapping
{
    public class CountryMap : EntityTypeConfiguration<Country>
    {
        public void Configure()
        {
            HasKey(c => c.Id);

            Property(c => c.NameCountry).IsRequired();
        }
    }
}
