using admin.domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace system.infra.DAO.Mapping
{
    public class CompanyMap : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("company");

            builder.HasKey(c => c.idCompany);

            builder.Property(c => c.cnpjCompany)
                   .IsRequired();

            builder.Property(c => c.stateRegistrationCompany);

            builder.Property(c => c.nameCompany)
                   .IsRequired();

            builder.Property(c => c.nameFantasy);

            builder.Property(c => c.emailCompany);

            builder.Property(c => c.cepCompany);

            builder.Property(c => c.countryCompany.idCountry)
                    .IsRequired();

            builder.Property(c => c.stateCompany.idState);

            builder.Property(c => c.cityCompany);

            builder.Property(c => c.aderessCompany);

            builder.Property(c => c.numberAderessCompany);

            builder.Property(c => c.complementCompany);

            builder.Property(c => c.districtCompany);

            builder.Property(c => c.emailAcessCTE);

            builder.Property(c => c.passwordAcessCTE);
          
        }
    }
}
