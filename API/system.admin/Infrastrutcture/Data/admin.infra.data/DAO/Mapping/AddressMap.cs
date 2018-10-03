﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using admin.domain.Entities;

namespace admin.infra.data.DAO.Mapping
{
    public class AddressMap : EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            HasKey(c => c.Id);

            Property(c => c.IdCountry).IsRequired();

            Property(c => c.IdState).IsRequired();

            Property(c => c.Cep).IsRequired();

            Property(c => c.Dwelling).IsRequired();

            Property(c => c.City).IsRequired();
        }
    }
}
