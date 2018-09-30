using admin.domain.Entities;
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace system.infra.DAO.Mapping
{
    public class CompanyMap : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("company");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.cnpjCompany)
                   .IsRequired();

            builder.Property(c => c.stateRegistrationCompany)
                   .IsRequired();

            builder.Property(c => c.nameCompany)
                   .IsRequired();

            builder.Property(c => c.nameFantasy)
                   .IsRequired();

            builder.Property(c => c.emailCompany)
                   .IsRequired();

            builder.Property(c => c.cepCompany)
                   .IsRequired();

            builder.Property(c => c.countryCompany)
                    .IsRequired();

            builder.Property(c => c.stateCompany)
                   .IsRequired();

            builder.Property(c => c.cityCompany)
                   .IsRequired();

            builder.Property(c => c.aderessCompany)
                   .IsRequired();

            builder.Property(c => c.numberAderessCompany)
                   .IsRequired();

            builder.Property(c => c.complementCompany)
                   .IsRequired();

            builder.Property(c => c.districtCompany)
                   .IsRequired();

            builder.Property(c => c.emailAcessCTE);

            builder.Property(c => c.passwordAcessCTE);

        }
    }
}
