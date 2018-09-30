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
    class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("customer");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.nameCustomer)
                   .IsRequired();

            builder.Property(c => c.emailCustomer)
                   .IsRequired();

            builder.Property(c => c.cpfCustomer)
                   .IsRequired();

            builder.Property(c => c.phoneCustomer)
                   .IsRequired();

            builder.Property(c => c.countryCustomer)
                   .IsRequired();

            builder.Property(c => c.stateCustomer)
                   .IsRequired();

            builder.Property(c => c.cepCustomer)
                   .IsRequired();

            builder.Property(c => c.aderessCustomer)
                   .IsRequired();

            builder.Property(c => c.complementCustomer)
                   .IsRequired();

            builder.Property(c => c.numberAderessCustomer)
                   .IsRequired();

            builder.Property(c => c.cityCustomer)
                   .IsRequired();

            builder.Property(c => c.districtCustomer)
                   .IsRequired();

        }
    }
}
