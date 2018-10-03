using System;
using System.Data.Entity.ModelConfiguration;
using admin.domain.Entities;

namespace admin.infra.data.DAO.Mapping
{
    public class UserPermissionsMap : EntityTypeConfiguration<UserPermissions>
    {
        public void Configure()
        {
            HasKey(c => c.Id);

            Property(c => c.IdModule).IsRequired();

            Property(c => c.Permission).IsRequired();
        }
    }
}
