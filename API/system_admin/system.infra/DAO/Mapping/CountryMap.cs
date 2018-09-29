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
    class CountryMap : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("country");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.nameCountry)
                   .IsRequired();
        }
    }
}
