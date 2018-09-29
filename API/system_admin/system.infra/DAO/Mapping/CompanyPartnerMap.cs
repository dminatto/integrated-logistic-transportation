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
    class CompanyPartnerMap : IEntityTypeConfiguration<CompanyPartner>
    {
        public void Configure(EntityTypeBuilder<CompanyPartner> builder)
        {
            builder.ToTable("company_partner");

            builder.HasKey(c => c.idCompanyPartner);

            builder.Property(c => c.cnpjCompanyPartner)
                   .IsRequired();

            builder.Property(c => c.stateRegistrationCompanyPartner)
                   .IsRequired();

            builder.Property(c => c.nameCompanyPartner)
                   .IsRequired();

            builder.Property(c => c.emailCompanyPartner)
                   .IsRequired();

            builder.Property(c => c.cepCompanyPartner)
                   .IsRequired();

            builder.Property(c => c.countryCompanyPartner.idCountry)
                   .IsRequired();

            builder.Property(c => c.stateCompanyPartner.idState)
                   .IsRequired();

            builder.Property(c => c.cityCompanyPartner)
                   .IsRequired();

            builder.Property(c => c.aderessCompanyPartner)
                   .IsRequired();

            builder.Property(c => c.numberAderessCompanyPartner)
                   .IsRequired();

            builder.Property(c => c.complementCompanyPartner)
                   .IsRequired();

            builder.Property(c => c.districtCompanyPartner)
                   .IsRequired();

            builder.Property(c => c.typeCompanyPartner)
                   .IsRequired();
        }
    }
}
