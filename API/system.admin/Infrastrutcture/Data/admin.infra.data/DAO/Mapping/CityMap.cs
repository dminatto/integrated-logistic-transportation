﻿using admin.domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace admin.infra.data.DAO.Mapping
{
    public class CityMap : EntityTypeConfiguration<City>
    {
        public void Configure()
        {
            HasKey(c => c.Id);

            Property(c => c.NameCity).IsRequired();
        }
    }
}
